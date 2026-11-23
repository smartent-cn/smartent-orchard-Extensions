# Orchard 配置节更名（appsettings）

> 路径均在 `OrchardCore` 节点下（环境变量形如 `OrchardCore__Smartent_Marketing__Pirsch__...`）。

| Legacy 节 | Smartent 节 | 代码 |
|-----------|-------------|------|
| `Lombiq_Marketing` | `Smartent_Marketing` | `MarketingConfigurationKeys` + `GetMarketingSection()` @ `Smartent.Orchard.Marketing` |
| `Lombiq_TrainingDemo` | `Smartent_TrainingDemo` | `TrainingDemoConfigurationKeys` + `GetTrainingDemoSection()` @ `Smartent.Orchard.TrainingDemo` |

**兼容**：未配置 Smartent 节名时仍读取对应 Legacy 节。

已更新示例：

- `Smartent-src/Demo/Smartent.Demo.Web/appsettings.json`（`Smartent_Marketing`、`Smartent_TrainingDemo`）
- `NuGetVerify/src/Smartent.NuGet.Web/appsettings.json`（Marketing）
- `Smartent.Orchard.Marketing.Pirsch/Readme.md`

仍待改名（其它批次）：`Lombiq_Hosting_*`（ApplicationInsights、Tenants 各子功能）。