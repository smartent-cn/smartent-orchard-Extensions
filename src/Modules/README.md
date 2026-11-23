# Orchard 模块 | Modules（M5）

**中文**：`src/Modules/` 为迁入后的 Orchard 模块根。PackageId 多为 `Smartent.Orchard.*`（见各子目录 `Readme.md`）。

**English**: Orchard modules live here after M5 migration; NuGet ids are typically `Smartent.Orchard.*`.

## 模块索引 | Index

| 目录 | 原 Smartent 产品线（参考） |
|------|---------------------------|
| [Smartent.Orchard.AuditTrail](Smartent.Orchard.AuditTrail/) | Smartent.AuditTrailExtensions |
| [Smartent.Orchard.ChartJs](Smartent.Orchard.ChartJs/) | Smartent.ChartJs |
| [Smartent.Orchard.ContentEditors](Smartent.Orchard.ContentEditors/) | Smartent.ContentEditors |
| [Smartent.Orchard.DataTables](Smartent.Orchard.DataTables/) | Smartent.DataTables |
| [Smartent.Orchard.EmailClient](Smartent.Orchard.EmailClient/) | Smartent.EmailClient |
| [Smartent.Orchard.Extensions.Cms](Smartent.Orchard.Extensions.Cms/) | Smartent.HelpfulExtensions |
| [Smartent.Orchard.Hosting.ApplicationInsights](Smartent.Orchard.Hosting.ApplicationInsights/) | Smartent.Hosting.Azure.ApplicationInsights |
| [Smartent.Orchard.Hosting.BuildVersion](Smartent.Orchard.Hosting.BuildVersion/) | Smartent.Hosting.BuildVersionDisplay |
| [Smartent.Orchard.Hosting.Tenants](Smartent.Orchard.Hosting.Tenants/) | Smartent.Hosting.Tenants.* |
| [Smartent.Orchard.JsonEditor](Smartent.Orchard.JsonEditor/) | Smartent.JsonEditor |
| [Smartent.Orchard.LoginAsAnybody](Smartent.Orchard.LoginAsAnybody/) | Smartent.LoginAsAnybody |
| [Smartent.Orchard.Marketing](Smartent.Orchard.Marketing/) | Smartent.Marketing.* |
| [Smartent.Orchard.Privacy](Smartent.Orchard.Privacy/) | Smartent.Privacy |
| [Smartent.Orchard.TrainingDemo](Smartent.Orchard.TrainingDemo/) | Smartent.TrainingDemo |
| [Smartent.Orchard.UIKit](Smartent.Orchard.UIKit/) | Smartent.UIKit |
| [Smartent.Orchard.VueJs](Smartent.Orchard.VueJs/) | Smartent.VueJs |
| [Smartent.Orchard.Walkthroughs](Smartent.Orchard.Walkthroughs/) | Smartent.Walkthroughs |

构建：仓库根目录 `dotnet build Smartent.Orchard.sln -c Release`。