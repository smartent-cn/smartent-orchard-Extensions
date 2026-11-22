# Smartent-src — 新代码树

本目录是 **重构后的唯一目标代码根**。尚未迁出的工程仍留在仓库根下的 `src/`、`test/`、`tools/` 中（Legacy），迁完并验收后删除对应 Legacy 路径。

## 目录约定

| 路径 | 用途 |
|------|------|
| `Platform/Core/` | 无 Orchard 依赖：`Smartent.Core.*` |
| `Platform/Orchard/` | Orchard 开发底座：原 HelpfulLibraries 演进为 `Smartent.Orchard.Platform.*` |
| `Build/` | MSBuild SDK、Npm、Node、Tailwind、Setup 等（自 `src/Utilities` 迁入；见 [Build/README.md](Build/README.md)） |
| `Libraries/` | ApiClient、EInvoice 等独立库 |
| `Modules/` | Orchard 模块 |
| `Themes/` | 主题 |
| `Demo/` | 演示 Web、聚合样例 |
| `Test/` | 测试工具与验收项目（自 `test/` 逐步迁入） |

## 迁移纪律（每个项目必须满足后再删 Legacy）

1. 新路径下 `dotnet build` 通过。  
2. 主解决方案（`Smartent.Orchard.sln`，原 `Lombiq.OSOCE.sln`）已包含新 csproj，且 **无任何 ProjectReference 仍指向旧路径**。  
3. 本阶段约定测试通过（见 `重构-重组-改名项目方案/第一步-计划.md`）。  
4. 删除 `src/`（或 `test/`）中 **仅属于该项目** 的旧文件夹；若目录内仍有未迁工程则保留父目录。  
5. 在 `重构-重组-改名项目方案/项目清单.md` 中标记该行为「已迁入 Smartent-src」。

## 当前状态

- 脚手架已建立（目录 + `build/` 全局属性）。  
- **M2 完成**：`Platform/Core/` 下五包已迁入（`Smartent.Core.*`）。  
- **M3 基本完成**：Platform/Orchard 与 `Smartent.Test.OrchardCore` 已迁入；元包仅 Legacy 聚合。见 `projects/M3-Platform-HelpfulLibraries.md`。
- **M4 进行中**：`Build/` 下 Npm、NodeJs、Tailwind、Setup 已 Smartent 化；MSBuild Sdk 主仓等见 `projects/M4-MSBuild-Targets.md`。

## 文档与规范

- 每个迁入项目的目录须含 **中英文** `Readme.md`：引用、用法、功能、升级扩展、测试（模板见 `docs/templates/PROJECT_README.template.md`）。  
- 代码公共 API：**中文** XML 注释（见 `docs/standards/csharp.md`）。  
- 带 `package.json` 的项目须按 `docs/standards/frontend-dependencies.md` 写明前端依赖。  
- 测试通过后再提交（见 `docs/standards/workflow-commits.md`）。

## 与根目录 `build/` 的关系

- `build/Smartent.Orchard.props`、`build/Smartent.Packaging.props` 供 **全仓库** MSBuild 导入（含 Legacy 与 Smartent-src）。  
- 新工程应使用 Smartent 包 ID / 命名空间；Legacy 工程在迁移前仍可编译。