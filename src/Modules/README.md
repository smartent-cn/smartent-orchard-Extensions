# Orchard 模块 | Modules（M5）

**中文**：`src/Modules/` 为迁入后的 Orchard 模块根。PackageId 多为 `Smartent.Orchard.*`（见各子目录 `Readme.md`）。

**English**: Orchard modules live here after M5 migration; NuGet ids are typically `Smartent.Orchard.*`.

## 模块索引 | Index

| 目录 | 原 Lombiq 产品线（参考） |
|------|---------------------------|
| [Smartent.Orchard.AuditTrail](Smartent.Orchard.AuditTrail/) | Lombiq.AuditTrailExtensions |
| [Smartent.Orchard.ChartJs](Smartent.Orchard.ChartJs/) | Lombiq.ChartJs |
| [Smartent.Orchard.ContentEditors](Smartent.Orchard.ContentEditors/) | Lombiq.ContentEditors |
| [Smartent.Orchard.DataTables](Smartent.Orchard.DataTables/) | Lombiq.DataTables |
| [Smartent.Orchard.EmailClient](Smartent.Orchard.EmailClient/) | Lombiq.EmailClient |
| [Smartent.Orchard.Extensions.Cms](Smartent.Orchard.Extensions.Cms/) | Lombiq.HelpfulExtensions |
| [Smartent.Orchard.Hosting.ApplicationInsights](Smartent.Orchard.Hosting.ApplicationInsights/) | Lombiq.Hosting.Azure.ApplicationInsights |
| [Smartent.Orchard.Hosting.BuildVersion](Smartent.Orchard.Hosting.BuildVersion/) | Lombiq.Hosting.BuildVersionDisplay |
| [Smartent.Orchard.Hosting.Tenants](Smartent.Orchard.Hosting.Tenants/) | Lombiq.Hosting.Tenants.* |
| [Smartent.Orchard.JsonEditor](Smartent.Orchard.JsonEditor/) | Lombiq.JsonEditor |
| [Smartent.Orchard.LoginAsAnybody](Smartent.Orchard.LoginAsAnybody/) | Lombiq.LoginAsAnybody |
| [Smartent.Orchard.Marketing](Smartent.Orchard.Marketing/) | Lombiq.Marketing.* |
| [Smartent.Orchard.Privacy](Smartent.Orchard.Privacy/) | Lombiq.Privacy |
| [Smartent.Orchard.TrainingDemo](Smartent.Orchard.TrainingDemo/) | Lombiq.TrainingDemo |
| [Smartent.Orchard.UIKit](Smartent.Orchard.UIKit/) | Lombiq.UIKit |
| [Smartent.Orchard.VueJs](Smartent.Orchard.VueJs/) | Lombiq.VueJs |
| [Smartent.Orchard.Walkthroughs](Smartent.Orchard.Walkthroughs/) | Lombiq.Walkthroughs |

构建：仓库根目录 `dotnet build Smartent.Orchard.sln -c Release`。