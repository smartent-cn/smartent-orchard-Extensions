# Orchard 配置节更名（appsettings）

> 路径均在 `OrchardCore` 节点下（环境变量形如 `OrchardCore__Smartent_Marketing__Pirsch__...`）。

本培训/演示仓库 **不保留** Legacy `Lombiq_*` 配置节读取；仅使用 `Smartent_*` / `Smartent_Orchard_*` 节名。

| 节名 | 代码 |
|------|------|
| `Smartent_Marketing` | `MarketingConfigurationKeys` + `GetMarketingSection()` @ `Smartent.Orchard.Marketing` |
| `Smartent_TrainingDemo` | `TrainingDemoConfigurationKeys` + `GetTrainingDemoSection()` @ `Smartent.Orchard.TrainingDemo` |
| `Smartent_Orchard_Hosting_*` | Hosting / Tenants / ApplicationInsights 各模块（原 `Lombiq_Hosting_*`，已批量更名） |

示例：

- `src/Demo/Smartent.Demo.Web/appsettings.json`
- `NuGetVerify/src/Smartent.NuGet.Web/appsettings.json`
- `Smartent.Orchard.Marketing.Pirsch/Readme.md`