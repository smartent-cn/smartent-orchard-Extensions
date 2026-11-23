# Orchard Recipe Id 更名对照（M5）

> 仓库内 `_Recipes/*.recipe.json` 文件名与 JSON `name` 已与 Smartent 产品线对齐；Orchard 执行 Recipe 时使用 **`name`**，不是文件名。

| 旧 Recipe `name` / 文件前缀 | 新 Recipe `name` | 典型路径 |
|-----------------------------|------------------|----------|
| `Lombiq.OSOCE.Tests` | `Smartent.Demo.Tests` | `Smartent-src/Demo/Smartent.Demo.Web/Recipes/` |
| `Lombiq.OSOCE.BasicOrchardFeaturesTests` | `Smartent.Demo.BasicOrchardFeaturesTests` | 同上 |
| `Lombiq.OSOCE.BaseTheme` | `Smartent.Demo.BaseTheme` | 同上 |
| `Lombiq.OSOCE.Tests.FeaturesGuard` | `Smartent.Demo.Tests.FeaturesGuard` | 同上 |
| `Lombiq.OSOCE.Tests.Elasticsearch` | `Smartent.Test.UI.Samples.Elasticsearch` | `Smartent.Test.UI.Samples/Recipes/` |
| `UseLombiqTestsUIAdminTheme` | `UseSmartent.Test.UI.AdminTheme` | `Smartent.Test.UI.Shortcuts/Recipes/` |
| `Lombiq.OrchardCoreApiClient.*` | `Smartent.Orchard.ApiClient.*` | `Smartent.Orchard.ApiClient*/Recipes/` |

扩展模块样例 Recipe 的 `name` 早即为 `Smartent.Orchard.Extensions.Cms.*`；仅 **文件名** 从 `Lombiq.HelpfulExtensions.*` 改为 `Smartent.Orchard.Extensions.Cms.*`（2026-11-23）。

## NuGetVerify（M7 #21）

Recipe **`name`** 未改；`steps` 内 **feature / theme id** 已与 Smartent 模块对齐：

| 旧 feature / theme id | 新 id |
|------------------------|-------|
| `Lombiq.Hosting.MediaTheme` / `.Bridge` | `Smartent.Orchard.Theme.Media` / `.Bridge` |
| `Lombiq.BaseTheme.Native.Samples` | `Smartent.Orchard.Theme.Base.Samples` |
| `Lombiq.*` 模块（Tests 配方 enable 列表） | `Smartent.Orchard.*` / `Smartent.Demo.*`（见 `Smartent.NuGet.Tests.recipe.json`） |

Demo 侧 `Smartent.Demo.BaseTheme` 配方与 NuGetVerify `Smartent.NuGet.BaseTheme` 使用相同的 Base Samples 主题 id。