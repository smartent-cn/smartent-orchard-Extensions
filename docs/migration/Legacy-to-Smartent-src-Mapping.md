# Legacy `src/` / `test/` → `Smartent-src/` 对照表

> **用途**：删除 Legacy 目录**之前**必须查阅并更新本表；与 [项目清单.md](../../重构-重组-改名项目方案/项目清单.md) 互补（清单偏阶段与发布策略，本表偏路径与拆包明细）。  
> **English**: Authoritative path mapping from Lombiq legacy trees to `Smartent-src/` before any Legacy folder removal.

**版本 | Version**: 1.0  
**最近更新 | Last updated**: 2026-11-24  
**维护**：删 Legacy 子目录或新增 `Smartent-src` 工程时，在本表增改一行并注明 `Legacy 删除状态`。

---

## 1. 图例 | Legend

| Legacy 删除状态 | 含义 |
|-----------------|------|
| **指针可删** | Legacy 下仅 `Readme.md`，无 `.csproj`，且仓库内无 `ProjectReference`/`Import` 指向该路径 |
| **保留** | 仍有 `.csproj` 或 MSBuild/工程仍引用，**不得**删 |
| **待脱钩** | 源码已在 `Smartent-src`，但 Legacy 仍被引用（删前需改 csproj/Import） |
| **未迁入** | 仍只有 Legacy 实现或未计划迁入 |

| 拆包 | 含义 |
|------|------|
| **1:1** | 一个旧产品线对应一个主 `PackageId` / 一个主文件夹 |
| **1:N** | 一个旧目录拆成多个 Smartent 项目或 NuGet 包 |
| **TBD** | 是否再拆 NuGet 未定 |

---

## 2. 删除 Legacy 前的检查（每次执行）

1. `rg` 仓库：是否仍有指向待删路径的 `ProjectReference`、`Import`、`PackageId`、CI 脚本路径。  
2. `Smartent.Orchard.sln` / `NuGetVerify/*.sln` 是否仍注册 Legacy 工程。  
3. `dotnet build Smartent.Orchard.sln -c Release` 与约定测试门禁（见 [workflow-commits.md](../standards/workflow-commits.md)）。  
4. 本表该行的 **Legacy 删除状态** 改为「已删」并写 PR 说明。

---

## 3. 仍阻塞「整棵删除 `src/`」的项（快照）

| Legacy 路径 | 原因 |
|-------------|------|
| `src/Utilities/Lombiq.MSBuild.Targets/` | **shim**：`Directory.Build.props` 转发 `Smartent-src/Build/`；各 Sdk 子目录为 Readme |
| `src/Libraries/Lombiq.HelpfulLibraries/` | **仅剩** Readme / CI 残留；元包 **已删** |
| `src/Utilities/Lombiq.Tailwind.Targets/` | 仅文档/残留；源码在 `Smartent-src/Build/Smartent.Build.Tailwind` |
| `tools/Lombiq.Analyzers/*` | 未迁入 `Smartent-src`；主 sln 仍引用 |

`src/Modules/**`、`src/Themes/**`：**已删**（2026-11-24 batch 3）；`test/Lombiq.*` 指针已删。

---

## 4. Platform / Core（原 `Lombiq.HelpfulLibraries` 拆包）

原单仓多 csproj → `Smartent-src/Platform/` + `Smartent-src/Test/`。

| Legacy（旧项目 / 目录） | Smartent-src 路径 | 主 PackageId（发布面） | 拆包 | Legacy 删除状态 |
|-------------------------|-------------------|------------------------|------|-----------------|
| `Lombiq.HelpfulLibraries.Common` | `Platform/Core/Smartent.Core.Primitives` | `Smartent.Core.Primitives` | 1:1 | 指针可删（Libraries 子目录 Readme） |
| `Lombiq.HelpfulLibraries.AspNetCore` | `Platform/Core/Smartent.Core.AspNet` | `Smartent.Core.AspNet` | 1:1 | 同上 |
| `Lombiq.HelpfulLibraries.Cli` | `Platform/Core/Smartent.Core.Cli` | `Smartent.Core.Cli` | 1:1 | 同上 |
| `Lombiq.HelpfulLibraries.Attributes` | `Platform/Core/Smartent.Core.CodeGen.Attributes` | `Smartent.Core.CodeGen.Attributes` | 1:1 | 同上 |
| `Lombiq.HelpfulLibraries.SourceGenerators` | `Platform/Core/Smartent.Core.CodeGen.SourceGenerators` | `Smartent.Core.CodeGen.SourceGenerators` | 1:1 | 同上 |
| `Lombiq.HelpfulLibraries.OrchardCore` | `Platform/Orchard/Smartent.Orchard.Platform` | `Smartent.Orchard.Platform` | 1:1（未来 Platform.* **TBD**） | 同上 |
| `Lombiq.HelpfulLibraries.LinqToDb` | `Platform/Orchard/Smartent.Orchard.Platform.Data.LinqToYesSql` | `Smartent.Orchard.Platform.Data.LinqToYesSql` | 1:1 | 同上 |
| `Lombiq.HelpfulLibraries.Refit` | `Platform/Orchard/Smartent.Orchard.Http.Refit` | `Smartent.Orchard.Http.Refit` | 1:1 | 同上 |
| `Lombiq.HelpfulLibraries.RestEase` | `Platform/Orchard/Smartent.Orchard.Http.RestEase` | `Smartent.Orchard.Http.RestEase` | 1:1 | 发布待定 |
| `Lombiq.HelpfulLibraries.OrchardCore.Testing` | `Test/Smartent.Test.OrchardCore` | `Smartent.Test.OrchardCore` | 1:1 | 同上 |
| `Lombiq.HelpfulLibraries.Samples` | `Demo/Smartent.Demo.Platform.Samples` | （不发布） | 1:1 | 同上 |
| `Lombiq.HelpfulLibraries.Tests` | `Test/Smartent.Test.Platform` | （不发布） | 1:1 | 同上 |
| `Lombiq.HelpfulLibraries`（元包） | *无 Smartent 元包* | （不发布） | — | **已删**（`Smartent.Test.Platform` 直接引用各包） |

---

## 5. Build / Utilities（`src/Utilities`）

| Legacy | Smartent-src | PackageId 备注 | 拆包 | Legacy 删除状态 |
|--------|--------------|----------------|------|-----------------|
| `Lombiq.MSBuild.Base.Sdk` | `Build/Smartent.Build.Base.Sdk` | `Smartent.Build.Base.Sdk`（M7#11） | 1:1 | Sdk 源码已迁；Legacy Sdk 子目录多为 Readme |
| `Lombiq.MSBuild.Library.Sdk` | `Build/Smartent.Build.Library.Sdk` | `Smartent.Build.Library.Sdk` | 1:1 | 同上 |
| `Lombiq.MSBuild.LibMan.Targets` | `Build/Smartent.Build.LibMan.Targets` | `Smartent.Build.LibMan.Targets` | 1:1 | 同上 |
| `Lombiq.MSBuild.OrchardCore.Module.Sdk` | `Build/Smartent.Build.OrchardCore.Module.Sdk` | `Smartent.Build.OrchardCore.Module.Sdk` | 1:1 | 同上 |
| `Lombiq.MSBuild.OrchardCore.Theme.Sdk` | `Build/Smartent.Build.OrchardCore.Theme.Sdk` | `Smartent.Build.OrchardCore.Theme.Sdk` | 1:1 | 同上 |
| `Lombiq.MSBuild.OrchardCore.Tests.Sdk` | `Build/Smartent.Build.OrchardCore.Tests.Sdk` | `Smartent.Build.OrchardCore.Tests.Sdk` | 1:1 | 同上 |
| `Lombiq.MSBuild.OrchardCore.Tests.UI.Sdk` | `Build/Smartent.Build.OrchardCore.Tests.UI.Sdk` | `Smartent.Build.OrchardCore.Tests.UI.Sdk` | 1:1 | 同上 |
| `Lombiq.MSBuild.OrchardCore.Tests.UI.Library.Sdk` | `Build/Smartent.Build.OrchardCore.Tests.UI.Library.Sdk` | 同名 Smartent | 1:1 | 同上 |
| `Lombiq.Npm.Targets` | `Build/Smartent.Build.Npm.Targets` | `Smartent.Build.Npm.Targets` | 1:1 | 指针可删 |
| `Lombiq.NodeJs.Extensions` | `Build/Smartent.Build.NodeJs/`（含 Samples/Tests） | `Smartent.Build.NodeJs` | 1:N 子工程 | 指针可删 |
| `Lombiq.Tailwind.Targets` | `Build/Smartent.Build.Tailwind` | `Smartent.Build.Tailwind` | 1:1 | 指针可删 |
| `Lombiq.SetupExtensions` | `Build/Smartent.Orchard.Setup` | `Smartent.Orchard.Setup` | 1:1 | 指针可删 |
| `Lombiq.MSBuild.Targets.Samples` | `Build/Smartent.Build.Targets.Samples` | — | 1:1 | **已删** |
| `Lombiq.MSBuild.Sdk.Samples` | `Build/Smartent.Build.Sdk.Samples` | — | 1:1 | **已删** |
| `Lombiq.MSBuild.Sdk.NuGet.Samples` | `Build/Smartent.Build.Sdk.NuGet.Samples` | — | 1:1 | **已删** |
| `Lombiq.MSBuild.Targets.Tests` | `Build/Smartent.Build.Targets.Tests` | — | 1:1 | **已删** |
| `Lombiq.MSBuild.Targets.Tests.UI` | `Build/Smartent.Build.Targets.Tests.UI` | — | 1:1 | **已删** |
| `Lombiq.MSBuild.Targets/Directory.Build.props` | `Smartent-src/Build/Directory.Build.props` | — | — | **shim**（转发 Import） |

---

## 6. Libraries（`src/Libraries`）

| Legacy | Smartent-src | PackageId | 拆包 | Legacy 删除状态 |
|--------|--------------|-----------|------|-----------------|
| `Lombiq.OrchardCoreApiClient` | `Libraries/Smartent.Orchard.ApiClient/` | `Smartent.Orchard.ApiClient` + `*.Tests.UI` | 1:N | 指针可删 |
| `Lombiq.EInvoiceValidator` | `Libraries/Smartent.Orchard.EInvoice/` | `Smartent.Orchard.EInvoice` + Sample/Tests/Benchmark | 1:N | 指针可删 |

---

## 7. Orchard 模块（`src/Modules` → `Smartent-src/Modules`）

### 7.1 单主模块 1:1（含 Samples / Tests / Tests.UI 子工程随主模块改名）

| Legacy 目录 `src/Modules/...` | Smartent 根目录 | 主 PackageId | Legacy 删除状态 |
|------------------------------|-----------------|--------------|-----------------|
| `Lombiq.TrainingDemo` | `Smartent.Orchard.TrainingDemo` | `Smartent.Orchard.TrainingDemo` | 指针可删 |
| `Lombiq.HelpfulExtensions` | `Smartent.Orchard.Extensions.Cms` | `Smartent.Orchard.Extensions.Cms` | 指针可删 |
| `Lombiq.ChartJs` | `Smartent.Orchard.ChartJs` | `Smartent.Orchard.ChartJs` | 指针可删 |
| `Lombiq.DataTables` | `Smartent.Orchard.DataTables` | `Smartent.Orchard.DataTables` | 指针可删 |
| `Lombiq.ContentEditors` | `Smartent.Orchard.ContentEditors` | `Smartent.Orchard.ContentEditors` | 指针可删 |
| `Lombiq.JsonEditor` | `Smartent.Orchard.JsonEditor` | `Smartent.Orchard.JsonEditor` | 指针可删 |
| `Lombiq.EmailClient` | `Smartent.Orchard.EmailClient` | `Smartent.Orchard.EmailClient` | 指针可删 |
| `Lombiq.Privacy` | `Smartent.Orchard.Privacy` | `Smartent.Orchard.Privacy` | 指针可删 |
| `Lombiq.AuditTrailExtensions` | `Smartent.Orchard.AuditTrail` | `Smartent.Orchard.AuditTrail` | 指针可删 |
| `Lombiq.Walkthroughs` | `Smartent.Orchard.Walkthroughs` | `Smartent.Orchard.Walkthroughs` | 指针可删 |
| `Lombiq.LoginAsAnybody` | `Smartent.Orchard.LoginAsAnybody` | `Smartent.Orchard.LoginAsAnybody` | 指针可删 |
| `Lombiq.Hosting.Azure.ApplicationInsights` | `Smartent.Orchard.Hosting.ApplicationInsights` | `Smartent.Orchard.Hosting.ApplicationInsights` | 指针可删 |
| `Lombiq.Hosting.BuildVersionDisplay` | `Smartent.Orchard.Hosting.BuildVersion` | `Smartent.Orchard.Hosting.BuildVersion` | 指针可删 |
| `Lombiq.OSOCE.Samples` | `Demo/Smartent.Demo.Samples` | （不发布） | 指针可删 |

### 7.2 一对多拆包

| Legacy | Smartent-src 子项目 / PackageId | 说明 |
|--------|--------------------------------|------|
| `Lombiq.VueJs` | `Smartent.Orchard.VueJs`、`Smartent.Orchard.VueJs.Resources`、`Smartent.Orchard.VueJs.Samples`、`Smartent.Orchard.VueJs.Tests.UI` | Resources 独立包；NuGetVerify Web 引用 Resources |
| `Lombiq.UIKit` | `Smartent.Orchard.UIKit`、`Smartent.Orchard.UIKit.Widgets`、`*.Tests.UI` | Widgets 仍为子 csproj |
| `Lombiq.Marketing` | `Smartent.Orchard.Marketing`、`Marketing.Pirsch`、`Marketing.UrlShortener`、`Marketing.Tests.UI` | 多子包；部分不在 `Smartent.Orchard.sln`，M7 supplemental pack |
| `Lombiq.Hosting.Tenants`（单 Legacy 树） | `Smartent.Orchard.Hosting.Tenants.*`（Admin.Login、Management、Maintenance、IdleTenantManagement、FeaturesGuard、EnvironmentRobots、EmailQuotaManagement、MediaStorageManagement、HealthChecks + 各 `*.Tests.UI`） | **1:N** 按功能拆 csproj；是否每功能独立 NuGet **TBD** |

Legacy 行状态：**指针可删**（`src/Modules/Lombiq.*` 目录），删除前对具体路径做 `rg` 确认。

---

## 8. 主题（`src/Themes`）

| Legacy | Smartent-src | 拆包明细 | Legacy 删除状态 |
|--------|--------------|----------|-----------------|
| `Lombiq.BaseTheme` | `Themes/Smartent.Orchard.Theme.Base/` | 主主题、`Theme.Base.Core`、`Theme.Base.Native`、Samples、`Tests.UI` | 指针可删 |
| `Lombiq.Hosting.MediaTheme` | `Themes/Smartent.Orchard.Theme.Media/` | 主主题、`Bridge`、`Deployer`、`Targets`、`Tests.UI`、`Tests.Theme` | 指针可删 |

---

## 9. 宿主、验收与 UI 测试（`src/` 根与 `test/`）

| Legacy | Smartent-src | 说明 | Legacy 删除状态 |
|--------|--------------|------|-----------------|
| `src/Lombiq.OSOCE.Web` | `Demo/Smartent.Demo.Web` | 演示 Orchard 宿主 | 指针可删（`src/Lombiq.OSOCE.Web`） |
| `test/Lombiq.OSOCE.Tests.UI` | `Test/Smartent.Test.Acceptance` | 仓库级 UI 验收 | `test/` 指针可删 |
| `test/Lombiq.Tests` | `Test/Smartent.Test.Unit` | 单元测试基础设施 | 同上 |
| `test/Lombiq.UITestingToolbox` + `Lombiq.Tests.UI` | `Test/Smartent.Test.UI/` 下多工程 | 见下表 | 同上 |

**`Lombiq.Tests.UI` → `Smartent.Test.UI.*`（1:N）**

| Smartent-src 工程 | 角色 |
|-------------------|------|
| `Smartent.Test.UI` | 核心 UI 测试宿主库 |
| `Smartent.Test.UI.AppExtensions` | 应用扩展 |
| `Smartent.Test.UI.Shortcuts` | Shortcuts 测试辅助 |
| `Smartent.Test.UI.Samples` | 样例 |
| `Smartent.Test.UI.Tests.UI` | 自测 UI |
| `Smartent.Test.UI.TestingModule` | 测试用模块 |
| `Smartent.Test.UI.AdminTheme` | 管理主题测试包（NuGetVerify Recipe） |

---

## 10. NuGet 验证床（非 `src/`，M7）

| Legacy 概念 | 现路径 | 说明 |
|-------------|--------|------|
| `NuGetTest` / Lombiq 包引用验证 | `NuGetVerify/` | `Smartent.NuGet.Web`、`Smartent.NuGet.Tests.UI`；仅 `PackageReference` + 本地/Gitee feed |

---

## 11. 尚未迁入 Smartent-src（仍在 Legacy / tools）

| 路径 | 计划 / 说明 |
|------|-------------|
| `tools/Lombiq.Analyzers/*` | 可选 `Smartent.Build.Analyzers.*`（M1/M4 **TBD**） |
| `tools/Lombiq.GitHub.Actions` | 可选 Smartent CI 复制（**未迁入**） |
| MSBuild Samples/Tests | 已迁 `Smartent-src/Build/Smartent.Build.*` |

PackageId 仍为 Lombiq 的例外清单：[M6-PackageId-Exceptions.md](../../重构-重组-改名项目方案/M6-PackageId-Exceptions.md)。

---

## 12. 建议删除顺序（维护本表时勾选）

1. **指针目录**：`src/Modules/Lombiq.*`、`src/Themes/Lombiq.*`（逐个 `rg` + 删 + 更新本表「已删」）。  
2. **脱钩 MSBuild**：去掉对 `src/Utilities/Lombiq.MSBuild.Targets/Directory.Build.props` 的 Import；迁移或删除 Samples/Tests 引用。  
3. **元包**：废弃并移除 `Lombiq.HelpfulLibraries` 元包工程（NuGetVerify/独立检出策略先对齐）。  
4. **整目录 `src/`**：仅当 §3 无 **保留/待脱钩** 项时考虑。  
5. **`test/` 指针**：与步骤 1 相同。

---

## 13. 变更记录 | Changelog

| 日期 | 变更 |
|------|------|
| 2026-11-23 | 初版：汇总 M2–M7 已迁入路径、1:N 拆包、Legacy 删除状态快照 |
| 2026-11-24 | Legacy batch 3–5：`src/Modules`、`src/Themes`、`test` 指针删除；MSBuild 样例/测试与元包迁 `Smartent-src/Build`；`Smartent.Orchard.slnx` 去 Legacy 工程路径 |