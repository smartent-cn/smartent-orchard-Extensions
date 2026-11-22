# 子方案：M5 批次（Samples + ChartJs + DataTables + UIKit + Extensions.Cms）

> 阶段：**M5**  
> 状态：**已迁入 Smartent-src**（2026-11-22）

## 范围

| Legacy | Smartent-src |
|--------|----------------|
| `Lombiq.HelpfulLibraries.Samples` (+ Tests.UI) | `Smartent-src/Demo/Smartent.Demo.Platform.Samples/` |
| `Lombiq.ChartJs` (+ Samples, Tests.UI) | `Smartent-src/Modules/Smartent.Orchard.ChartJs/` |
| `Lombiq.DataTables` (+ Samples, Tests, Tests.UI) | `Smartent-src/Modules/Smartent.Orchard.DataTables/` |
| `Lombiq.UIKit` (+ Widgets, Tests.UI, Widgets.Tests.UI) | `Smartent-src/Modules/Smartent.Orchard.UIKit/` |
| `Lombiq.HelpfulExtensions` (+ Tests.UI) | `Smartent-src/Modules/Smartent.Orchard.Extensions.Cms/` |

## Feature Id（破坏性）

前缀由 `Lombiq.*` 改为下表；子功能保持 `.<Name>` 后缀（Extensions.Cms 全量子功能同理）。

| 原前缀 | 新前缀 |
|--------|--------|
| `Lombiq.HelpfulLibraries.Samples` | `Smartent.Demo.Platform.Samples` |
| `Lombiq.ChartJs` | `Smartent.Orchard.ChartJs` |
| `Lombiq.DataTables` | `Smartent.Orchard.DataTables` |
| `Lombiq.UIKit` | `Smartent.Orchard.UIKit` |
| `Lombiq.HelpfulExtensions` | `Smartent.Orchard.Extensions.Cms` |

已同步：`Smartent.Demo.Web` / `NuGetTest` Recipe（如适用）、测试项目 `ExecuteRecipeDirectlyAsync`、`asp-area` 与主 sln/slnx。

## 验证

```powershell
$env:NUGET_PACKAGES = "$env:USERPROFILE\.nuget\packages"
dotnet build Smartent.Orchard.sln -c Release
dotnet test Smartent-src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.Tests/Smartent.Orchard.DataTables.Tests.csproj -c Release
```

## 迁一删一

Legacy 目录仅留 `Readme.md` 指针（`src/Modules/Lombiq.{ChartJs,DataTables,UIKit,HelpfulExtensions}/`、`src/Libraries/.../Lombiq.HelpfulLibraries.Samples*`）。

## 未决

- `NuGetTest/Directory.Packages.props` 仍为 Lombiq 包版本占位（独立 NuGet 管线未 Smartent 发包）
- 各模块父级 `Readme.md` 双语头与文化可继续与 TrainingDemo 对齐