# Smartent 训练演示仓库 — 重构 · 重组 · 改名 项目方案

> 仓库路径：`G:\Smartent-Training-Demo-Modules`（Gitee：`smartent/smartent-training-demo-modules`）  
> 文档版本：1.1  
> 状态：总体规划；**M1 脚手架见 [第一步-计划.md](第一步-计划.md)**

---

## 1. 背景与目标

### 1.1 背景

本仓库源自 Lombiq Open-Source Orchard Core Extensions（OSOCE）能力合集，已改为 **无 Git 子模块** 的 monorepo。团队计划在既有代码上 **自主扩展**，**不跟随 Lombiq  upstream 升级**，并在条件成熟时 **发布自有 NuGet 包**。

当前痛点：

| 痛点 | 说明 |
|------|------|
| 品牌与所有权 | 大量 `Lombiq.*` 命名空间、程序集、PackageId，与 Smartent 产品不一致 |
| 语义不清 | 如 `HelpfulLibraries`、`HelpfulExtensions`、`OSOCE` 等泛化名称，难以理解职责 |
| 引用过重 | 元包与 `HelpfulLibraries.OrchardCore` 等聚合大量 Orchard 依赖，模块实际只用到一小部分 |
| 结构历史包袱 | 目录、解决方案、MSBuild SDK 仍按 Lombiq/OSOCE 组织 |

### 1.2 目标

1. **统一 Smartent 品牌**：可发布物（程序集、NuGet PackageId、主要命名空间）使用 `Smartent.*` 体系。  
2. **仓库可长期维护**：目录与解决方案结构清晰，依赖方向自上而下单向、无环。  
3. **引用按需、语义明确**：消除默认「全家桶」依赖；具体拆成几个 NuGet 包 **按项目推进时再定**。  
4. **质量门禁**：**全部改完且测试稳定后** 再执行 NuGet 打包与发布（开发期以 `ProjectReference` 为主）。  
5. **合规**：保留原开源许可与版权说明；新版权/作者信息使用 Smartent。

### 1.3 非目标（本阶段不做）

- 不承诺与 Lombiq NuGet 版本号或 API 二进制兼容。  
- 不在本总方案中敲定每个 csproj 的拆包细节（见 [§8](#8-具体项目子方案何时编写)）。  
- 不重写业务功能（除非改名/拆包必需）。

---

## 2. 范围

### 2.1 在范围内

| 区域 | 当前典型路径 | 改造性质 |
|------|----------------|----------|
| 构建与规范 | 根 `Directory.Build.props`、`NuGet.config`、`.github` | 品牌、版本、分析器引用 |
| 平台库 | `src/Libraries/Lombiq.HelpfulLibraries` | 改名、拆包（重点）、减依赖 |
| 其它库 | `Lombiq.OrchardCoreApiClient`、`Lombiq.EInvoiceValidator` | 改名、依赖梳理 |
| 工具链 | `src/Utilities/Lombiq.MSBuild.Targets`、`Npm.Targets`、`NodeJs.Extensions`、`SetupExtensions`、`Tailwind.Targets` | 改名、SDK 包名 |
| 分析器 | `tools/Lombiq.Analyzers*` | 改名（可选拆分） |
| Orchard 模块 | `src/Modules/Lombiq.*` | 改名、模块 Id 策略、减引用 |
| 主题 | `src/Themes/Lombiq.*` | 同上 |
| 演示宿主 | `src/Smartent.Demo.Web` | 改名、引用更新 |
| 测试 | `test/*`、`NuGetVerify` | 改名、门禁用例 |
| 文档与脚本 | `Readme.md`、`Releasing.md`、`*.ps1`、`renovate*.json5` | Smartent 化、去 Lombiq 上游耦合 |

### 2.2 在范围外（保持不变名或仅版本管理）

| 项 | 说明 |
|----|------|
| `OrchardCore.*` 官方 NuGet | 仅由 `OrchardCoreVersion` 等属性指定版本，不改包名 |
| 第三方依赖 | HtmlSanitizer、linq2db、Refit 等保持原名 |
| Lombiq 历史链接 | 可在「来源说明」中保留，不作为主文档路径 |

---

## 3. 命名与品牌规范

### 3.1 包 ID 与程序集（发布后对外）

推荐前缀：

```text
Smartent.{产品线}.{具体名称}
```

| 产品线 | 用途 | 示例 |
|--------|------|------|
| `Smartent.Core` | 无 Orchard 依赖的基础库 | `Smartent.Core.Primitives` |
| `Smartent.Orchard.Platform` | Orchard 模块开发底座（原 HelpfulLibraries 演进） | `Smartent.Orchard.Platform.*`（具体子包实施时命名） |
| `Smartent.Orchard` | 可安装的 Orchard 模块、主题 | `Smartent.Orchard.TrainingDemo` |
| `Smartent.Orchard.Hosting` | 多租户、Azure、部署类模块 | `Smartent.Orchard.Hosting.Tenants` |
| `Smartent.Build` | MSBuild SDK、Targets | `Smartent.Build.OrchardCore.Module.Sdk` |
| `Smartent.Test` | 测试工具箱 | `Smartent.Test.UI` |
| `Smartent.Demo` | 聚合演示 Web、样例模块 | `Smartent.Demo.Web` |

元包/全家桶：**不计划作为默认依赖**；若需要，可单独设 `Smartent.Orchard.Platform.DevKit` 等名称，实施时再定。

### 3.2 命名空间

与程序集名一致：`Smartent.Orchard.TrainingDemo`、`Smartent.Orchard.Platform.Content` 等。

### 3.3 Orchard 模块 Id（Manifest）

| 策略 | 适用 |
|------|------|
| **新模块 / 大版本** | Module Id 与 Smartent 包名对齐 |
| **已有站点兼容** | 可在子方案中评估是否保留旧 Id 一版或提供 Recipe 迁移 |

### 3.4 NuGet 元数据（统一属性）

在根级 `build/Smartent.Packaging.props`（待建）中约定：

- `Authors` / `Company`：`Smartent`  
- `PackageLicenseExpression`：与根 `License.md` 一致  
- 图标：替换 Lombiq logo 为 Smartent 图标（待设计）  
- `RepositoryUrl`：Gitee 本仓库地址  

### 3.5 版本线

- Smartent 自有版本从 **1.0.0** 起，与 Lombiq `13.x` **无对应关系**。  
- `CHANGELOG` 或发布说明标注「基于 OSOCE / Lombiq 某快照」即可。

---

## 4. 目标仓库结构（宏观）

### 4.1 双树过渡期

- **`Smartent-src/`**：重构后的 **目标代码树**（新建、迁入、扩编均在此进行）。  
- **`src/`、`test/`、`tools/`**：**Legacy**，每完成一个项目的迁移与验收后 **删除** 对应 Lombiq 目录。  
- **`build/`**：全仓库 MSBuild 基线（Legacy 与 Smartent-src **共用**）。

纪律见 [Smartent-src/README.md](../Smartent-src/README.md) 与 **[第一步-计划.md](第一步-计划.md)**。

### 4.2 终态目录示意

```text
Smartent-Training-Demo-Modules/
  build/
    Smartent.Orchard.props
    Smartent.Packaging.props
  Smartent-src/
    Platform/Core/                  # Smartent.Core.*
    Platform/Orchard/               # Smartent.Orchard.Platform.*
    Build/                          # Smartent.Build.*
    Libraries/
    Modules/
    Themes/
    Demo/
    Test/
  tools/                            # 分析器等（逐步 Smartent 化）
  Smartent.Orchard.sln              # 原 Lombiq.OSOCE.sln
  重构-重组-改名项目方案/
```

Legacy 的 `src/` 在终态 **应不存在**（或仅保留无意义占位说明）。各子目录下的 **独立 .sln** 可保留供局部开发；**CI 以主解决方案为准**。

---

## 5. 依赖分层与改造顺序

### 5.1 原则：**自下而上**，顶层只做验收

```text
  Layer 0   构建规范、分析器（仅包名/引用）
  Layer 1   Smartent.Core.*（原 Common / AspNet / Cli / CodeGen）
  Layer 2   Smartent.Orchard.Platform.*（原 HelpfulLibraries；拆包细节后续定）
  Layer 3   Smartent.Build.*（MSBuild SDK、Npm/Tailwind Targets）
  Layer 4   其它 Libraries（ApiClient、EInvoice）
  Layer 5   Orchard 模块与主题（按模块间依赖从叶子到核心）
  Layer 6   Demo Web + 全量测试
  Layer 7   NuGet 打包与发布验证
```

**黄金路径验收**（每层或每阶段结束建议执行）：

1. `dotnet build` 主解决方案  
2. 关键单元测试（Platform、Tests）  
3. 阶段完成后：`Smartent.Demo.Web` + `Smartent.Test.UI` 全量回归  

### 5.2 引用减重原则（总纲）

进入具体项目时须遵守：

1. **禁止**新建对 `Lombiq.HelpfulLibraries` 元包的依赖。  
2. 模块 **只引用** 其代码实际使用的 Platform 子包（拆包完成后）。  
3. 每个可发布 csproj **独立维护** `PackageReference` 列表，禁止复制粘贴整表 Orchard 包。  
4. 用 `dotnet list package --include-transitive` 抽检模块，确保无意外传递依赖。  

---

## 6. 分阶段里程碑

| 阶段 | 名称 | 主要交付 | 完成标准 |
|------|------|----------|----------|
| **M0** | 方案与跟踪 | 本目录文档、项目清单表、分支策略 | 团队评审通过 |
| **M1** | 构建身份 | `build/*.props`、Authors、Orchard 版本属性、根 Readme 定位 Smartent | 主 sln 可编译（尚未大规模改名） |
| **M2** | Core 层 | `Smartent.Core.*` 改名完成，原 Common/AspNet/Cli/Attributes/SourceGenerators | 对应单测通过 |
| **M3** | Platform 层 | HelpfulLibraries → Platform 目录/包名；**拆包方案在该阶段逐个子文档编写** | Platform 测试 + 依赖模块改为新引用后编译通过 |
| **M4** | Build 层 | MSBuild SDK、Npm/Node/Setup/Tailwind Targets 改名 | 模块 Sdk 样例工程可构建 |
| **M5** | 模块与主题 | 全部 `Lombiq.*` 模块/主题 Smartent 化 | 模块单测/UI 测试通过 |
| **M6** | 宿主与整体验收 | Demo Web、OSOCE.Tests.UI、NuGetVerify | 全量测试稳定 |
| **M7** | 发布 | PackageId 终审、打包、Gitee/NuGet 源验证 restore | 从空项目仅引用 Smartent 包可建站 |

阶段之间允许在同一长期分支上推进；**每个阶段结束打 tag 或记 commit 范围**，便于回滚。

---

## 7. 测试与验收

### 7.1 测试分层

| 层级 | 内容 |
|------|------|
| L1 | Platform / Core 单元测试 |
| L2 | 各模块 `*.Tests`、`*.Tests.UI` |
| L3 | 仓库级 `Smartent.*.Tests.UI`（原 Smartent.Test.Acceptance） |
| L4 | NuGet 还原 + 仅包引用构建（M7） |

### 7.2 通过标准（M6）

- 主解决方案 **Release** 配置构建无错误（警告策略团队另定）。  
- 约定 UI 测试套件在本地/CI 全绿。  
- 全局搜索：无待发布的 `PackageId` 仍含 `Lombiq.`（分析器/Dev 工具可列例外清单）。  

### 7.3 CI

- 将 workflow 中 checkout、缓存、展示名改为 Smartent；  
- 是否继续引用 Lombiq GitHub Actions 可 **复制改为 Gitee Actions** 或保留 workflow 仅改环境（M1/M4 定）。  

---

## 8. 具体项目子方案何时编写

总则：**本 README 只定顺序与规范**；进入某一目录前，在同目录下增加子方案，例如：

```text
重构-重组-改名项目方案/
  projects/
    M3-Platform-HelpfulLibraries.md    # 拆成几个包、文件夹映射、Orchard 包最小集
    M5-Module-TrainingDemo.md            # 模块 Id、Recipe、引用清单
    ...
```

子方案模板见 [projects/_模板.md](projects/_模板.md)。

---

## 9. 风险与 Orchard 注意事项

| 风险 | 缓解 |
|------|------|
| Recipe / Migration 中类型全名变化 | 子方案列出 Recipe 扫描清单；必要时保留类型转发或迁移脚本 |
| Module Feature Id 变化导致站点无法启用 | 新 Id 策略写清；大版本一次性切换 |
| MSBuild SDK 改名导致所有模块 csproj 失效 | M4 集中改 Sdk 属性 + 批量验证 |
| 大批量重命名 merge 冲突 | 按阶段分支；单阶段内尽量避免与功能开发并行 |
| OrchardCore 大版本升级 | 与 Lombiq 脱钩后由 Smartent 自行评估；本方案不绑定 upstream |

---

## 10. NuGet 发布（最后执行）

开发期 **不发布**；M7 执行：

1. 确认 `Smartent.Packaging.props` 中 `GeneratePackageOnBuild` 或专用 pack 脚本。  
2. 配置 Gitee Packages / 私有 feed（`NuGet.config` 增加源）。  
3. 对 [项目清单](项目清单.md) 中「是否发布=N」的项不打包。  
4. 对发布包执行 `dotnet pack` + 测试项目 **仅 PackageReference** 验证。  

---

## 11. 治理与协作

- **分支**：建议 `refactor/smartent-rename` 长期分支，阶段完成后合并 `master`。  
- **提交信息**：说明阶段与范围，例如 `M3: rename Platform Content package and update TrainingDemo refs`。  
- **代码评审**：每阶段至少一人对照 [项目清单](项目清单.md) 勾选。  
- **Renovate**：移除对 Lombiq OSOCE 上游 config 的 extends；仅保留 OrchardCore 与安全依赖策略（M1）。  

---

## 12. 文档索引

| 文档 | 说明 |
|------|------|
| [docs/standards/README.md](../docs/standards/README.md) | **Smartent 开发规范总览**（C#、中英 Readme、前端依赖、测试门禁提交） |
| [.cursor/rules/](../.cursor/rules/) | Cursor Agent 规则（与上表同步） |
| [第一步-计划.md](第一步-计划.md) | **M1：Smartent-src 脚手架与下步迁移动作** |
| [Smartent-src/README.md](../Smartent-src/README.md) | 新树目录约定与「迁一删一」纪律 |
| [项目清单.md](项目清单.md) | 现名 → 目标 Smartent 产品线映射（拆包列 TBD） |
| [projects/_模板.md](projects/_模板.md) | 单项目子方案模板 |
| [阶段检查表.md](阶段检查表.md) | M0–M7 勾选项 |
| [projects/M7-Batch-NuGetTest-PackageIds.md](projects/M7-Batch-NuGetTest-PackageIds.md) | M7#1：`NuGetTest` → `NuGetVerify`、包 ID |
| [projects/M7-Batch-LocalNuGetFeed.md](projects/M7-Batch-LocalNuGetFeed.md) | M7#3–#4：本地 feed、Monorepo sln、CI |
| [projects/M7-Batch-6-FeedHygiene.md](projects/M7-Batch-6-FeedHygiene.md) | M7#6：core pack 列表、NodeJs Samples、`-CorePack` |
| [projects/M7-Batch-7-FullSlnValidation.md](projects/M7-Batch-7-FullSlnValidation.md) | M7#7：feed 校验脚本、全 sln 还原流程 |
| [projects/M7-Batch-9-CIPackageRestore.md](projects/M7-Batch-9-CIPackageRestore.md) | M7#9：本地 feed CI、独立 PackageReference 还原 |
| [projects/M7-Batch-10-GiteePublish.md](projects/M7-Batch-10-GiteePublish.md) | M7#10：Gitee Packages、首版发布清单 |
| [projects/M7-Batch-10a-BuildFolderRename.md](projects/M7-Batch-10a-BuildFolderRename.md) | **插入**：`Build/Lombiq.MSBuild.*` → `Smartent.Build.*` 目录改名 |
| [projects/M7-Batch-11-SdkPackageIdRename.md](projects/M7-Batch-11-SdkPackageIdRename.md) | M7#11：Sdk PackageId → `Smartent.Build.*` |
| [projects/M7-Batch-12-FeedCentralVersions.md](projects/M7-Batch-12-FeedCentralVersions.md) | M7#12：feed 与中央版本 assert |
| [docs/releases/M7-FirstNuGet-Release-Draft.md](../docs/releases/M7-FirstNuGet-Release-Draft.md) | 首版 NuGet 发布说明（草案） |
| [projects/M7-Batch-13-FullNuGetVerifyPack.md](projects/M7-Batch-13-FullNuGetVerifyPack.md) | M7#13：全量 `-Full` pack 运行手册 |
| [projects/M7-Batch-14-LegacyPublishSurface.md](projects/M7-Batch-14-LegacyPublishSurface.md) | M7#14：Legacy 元包 / MSBuild 发布面 |
| [projects/M7-Batch-15-GiteeNuGetConfig.md](projects/M7-Batch-15-GiteeNuGetConfig.md) | M7#15：Gitee / mapping 配置模板 |
| [projects/M7-Batch-16-CoreFeedExpansion.md](projects/M7-Batch-16-CoreFeedExpansion.md) | M7#16：LibMan core pack、manifest 摘要 |
| [projects/M7-Batch-17-ReleaseReadiness.md](projects/M7-Batch-17-ReleaseReadiness.md) | M7#17：发布就绪文档、SmartentLocal 源、门禁 |
| [projects/M7-Batch-NuGetVerify-Feed.md](projects/M7-Batch-NuGetVerify-Feed.md) | M7：包版本同步脚本（占位） |

### 12.1 迁入项目时的文档义务

每完成一个 `Smartent-src` 项目迁入且测试通过：

1. 按 [PROJECT_README.template.md](../docs/templates/PROJECT_README.template.md) 编写或更新 `Readme.md`（中英文）。  
2. 为新增/变更的 **public API** 补 **中文** XML 注释。  
3. 若有前端，补全 npm 依赖表（见 [frontend-dependencies.md](../docs/standards/frontend-dependencies.md)）。  
4. 通过测试门禁后再提交（见 [workflow-commits.md](../docs/standards/workflow-commits.md)）。

---

## 修订记录

| 版本 | 日期 | 说明 |
|------|------|------|
| 1.0 | 2026-11-21 | 初版总方案 |