# src — Product code tree

> **中文说明**: [Readme-CN.md](Readme-CN.md)

本目录是 **Smartent 产品代码唯一根目录**（原 `Smartent-src`，2026-11 收口）。仓库根 Legacy `src/` 指针已删除；说明见 [src-old/README.md](../src-old/README.md)。

**与旧 Smartent 路径对照**：[docs/migration/Legacy-to-Smartent-src-Mapping.md](../docs/migration/Legacy-to-Smartent-src-Mapping.md) · 更名记录：[docs/migration/Rename-Smartent-src-to-src.md](../docs/migration/Rename-Smartent-src-to-src.md)

## 目录约定

| 路径 | 用途 |
|------|------|
| `Platform/Core/` | 无 Orchard 依赖：`Smartent.Core.*` |
| `Platform/Orchard/` | Orchard 开发底座：原 HelpfulLibraries 演进为 `Smartent.Orchard.Platform.*` |
| `Build/` | MSBuild SDK、Npm、Node、Tailwind、Setup 等（自 Legacy `src/Utilities` 迁入；见 [Build/README.md](Build/README.md)） |
| `Libraries/` | ApiClient、EInvoice 等独立库 |
| `Modules/` | Orchard 模块 |
| `Themes/` | 主题 |
| `Demo/` | 演示 Web、聚合样例 |
| `Test/` | 测试工具与验收项目（自 `test/` 逐步迁入） |

## 迁移纪律（每个项目必须满足后再删 Legacy）

1. 新路径下 `dotnet build` 通过。  
2. 主解决方案（`Smartent.Orchard.sln`，原 `Smartent.Demo.sln`）已包含新 csproj，且 **无任何 ProjectReference 仍指向旧路径**。  
3. 本阶段约定测试通过（见 `重构-重组-改名项目方案/第一步-计划.md`）。  
4. 删除 Git 历史中 Legacy 路径（或 `test/`）下 **仅属于该项目** 的旧文件夹；若目录内仍有未迁工程则保留父目录。  
5. 在 `重构-重组-改名项目方案/项目清单.md` 中标记该行为「已迁入 src」。

## 当前状态

- 脚手架已建立（目录 + `build/` 全局属性）。  
- **M2 完成**：`Platform/Core/` 下五包已迁入（`Smartent.Core.*`）。  
- **M3 基本完成**：Platform/Orchard 与 `Smartent.Test.OrchardCore` 已迁入；Legacy 元包已移除。见 `projects/M3-Platform-HelpfulLibraries.md`。
- **M4 首期完成**：Sdk 与 Samples/Tests 均在 `Build/`；Legacy `src/Utilities/Smartent.MSBuild.Targets` 仅 shim + Readme。见 `projects/M4-MSBuild-Targets.md`。
- **M7 进行中**：`NuGetVerify`、本地 feed 脚本见仓库根 `scripts/` 与 `projects/M7-Batch-*.md`。
- **M5**：Orchard 模块与主题已基本迁入 `Modules/`、`Themes/`、`Demo/Smartent.Demo.Samples`；见 `projects/M5-Batch-*.md`。
- **M6**：宿主与测试工具链已迁入；`Smartent.Test.Platform`（原 HelpfulLibraries.Tests）；见 `projects/M6-Batch-*.md`。
- **net10 对齐**：VueJs / BaseTheme.Samples / `Smartent.Build.NodeJs.Tests` 已升至 net10，Orchard 包引用统一 `$(OrchardCoreVersion)`。
- **Release 门禁**：`dotnet build Smartent.Orchard.sln -c Release` 已通过；VueJs 消费 `.nx` 见 `projects/M4-MSBuild-Targets.md` §M4#11。

## Orchard modules documentation

- Index: [docs/src-projects/README.md](../docs/src-projects/README.md) · [src/Modules/README.md](Modules/README.md)

## 文档与规范

- 每个迁入项目的 csproj 目录须含 **`Readme.md`（英文）** 与 **`Readme-CN.md`（中文）**（模板见 `docs/templates/PROJECT_README.en.template.md`、`PROJECT_README.cn.template.md`；批量补齐：`scripts/Ensure-BilingualProjectReadmes.py`）。  
- 代码公共 API：**中文** XML 注释（见 `docs/standards/csharp.md`）。  
- 带 `package.json` 的项目须按 `docs/standards/frontend-dependencies.md` 写明前端依赖。  
- 测试通过后再提交（见 `docs/standards/workflow-commits.md`）。

## 与根目录 `build/` 的关系

- `build/Smartent.Orchard.props`、`build/Smartent.Packaging.props` 供 **全仓库** MSBuild 导入。  
- 新工程应使用 Smartent 包 ID / 命名空间；Legacy 工程在迁移前仍可编译。