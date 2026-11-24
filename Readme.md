# Smartent Orchard Extensions (Orchard Core)

> **Smartent 开源 Orchard 扩展单体仓**（Gitee [`smartent/smartent-orchard-Extensions`](https://gitee.com/smartent/smartent-orchard-Extensions) · GitHub [`smartent-cn/smartent-orchard-Extensions`](https://github.com/smartent-cn/smartent-orchard-Extensions)）：应用代码在 [`src/`](src/README.md)；重构方案见 [`重构-重组-改名项目方案/`](重构-重组-改名项目方案/README.md)；M7 本地 NuGet 门禁：`./scripts/Invoke-M7CoreFeedGate.ps1`。  
> **Smartent Orchard Extensions monorepo**: application code under `src/`; M7 feed gate: `./scripts/Invoke-M7CoreFeedGate.ps1`. Module list below is being migrated from legacy Lombiq OSOCE naming to `Smartent.*` PackageIds.

[![Build and Test](https://github.com/smartent-cn/smartent-orchard-Extensions/actions/workflows/build-and-test.yml/badge.svg)](https://github.com/smartent-cn/smartent-orchard-Extensions/actions/workflows/build-and-test.yml) [![Build and Test Windows](https://github.com/smartent-cn/smartent-orchard-Extensions/actions/workflows/build-and-test-windows.yml/badge.svg)](https://github.com/smartent-cn/smartent-orchard-Extensions/actions/workflows/build-and-test-windows.yml) [![GitHub commit activity](https://img.shields.io/github/commit-activity/m/smartent-cn/smartent-orchard-Extensions)](https://github.com/smartent-cn/smartent-orchard-Extensions/commits/dev) [![GitHub last commit](https://img.shields.io/github/last-commit/smartent-cn/smartent-orchard-Extensions)](https://github.com/smartent-cn/smartent-orchard-Extensions/commits/dev) [![GitHub contributors](https://img.shields.io/github/contributors/smartent-cn/smartent-orchard-Extensions)](https://github.com/smartent-cn/smartent-orchard-Extensions/graphs/contributors)

## About

Looking for useful Orchard Core extensions? This solution bundles Smartent's open-source Orchard Core modules and themes. Clone and try them out!

This is an [Orchard Core](https://orchardcore.net/) Visual Studio solution that contains most of [Smartent](https://gitee.com/smartent)'s open-source Orchard modules and themes, as well as related utilities and libraries. Please keep in mind that only those extensions are included which use the latest released version of Orchard (i.e. the very cutting-edge ones depending on a nightly build are not yet here).

This also serves as an example of an ASP.NET Core web app using Orchard from NuGet.

Note that this solution also has an Orchard 1 counterpart, [Lombiq's Open-Source Orchard Extensions](https://gitee.com/smartent/smartent-orchard-Extensions)
## Prerequisites and getting started

- To develop and test scripts written in PowerShell, install and use [PowerShell 7](https://docs.microsoft.com/en-us/powershell/scripting/install/installing-powershell) instead of Windows PowerShell (i.e., up to version 5.x). Static code analysis is only executed through PowerShell 7.
- All extensions are included directly in this repository (no git submodules). Clone the repo and build the solution as usual.

## Included Projects

### Libraries

- [`Lombiq.HelpfulLibraries`](https://gitee.com/smartent/smartent-orchard-Extensions) Various libraries that can be handy when developing for Orchard Core, to be used from your own Orchard modules.
- [`Lombiq.HelpfulLibraries.Cli`](https://gitee.com/smartent/smartent-orchard-Extensions) Command Line Libraries. This project helps with executing command line calls.
- [`Lombiq.HelpfulLibraries.LinqToDb`](https://gitee.com/smartent/smartent-orchard-Extensions) With the help of this project you can write LINQ expressions and run them with a [YesSql](https://github.com/sebastienros/yessql) `ISession` extension method to query from the DB instead of writing plain SQL queries. Uses the [LINQ to DB project](https://linq2db.github.io/). You can watch a demo video of the project [here](https://www.youtube.com/watch?v=ldJOdCSsWJo).
- [`Lombiq.HelpfulLibraries.Refit`](https://gitee.com/smartent/smartent-orchard-Extensions) Adds helpers for working with [Refit](https://github.com/reactiveui/refit).
- [`Lombiq.HelpfulLibraries.RestEase`](https://gitee.com/smartent/smartent-orchard-Extensions) Adds a typed HTTP client to the service collection using RestEase.
- [`Lombiq.HelpfulLibraries.SourceGenerators`](https://gitee.com/smartent/smartent-orchard-Extensions) A collection of helpful source generators. You can watch a demo video of the project [here](https://www.youtube.com/watch?v=MluV1ocZGiE).
- [`Lombiq.OrchardCoreApiClient`](https://gitee.com/smartent/smartent-orchard-Extensions) A client library for communicating with the [Orchard Core](https://www.orchardcore.net/) web APIs, it contains an implementation for the tenant and content management APIs and a console application for testing and demonstration. You can watch a demo video of the project [here](https://www.youtube.com/watch?v=VrYoN34uFQI).

### Modules

> **Smartent 模块**：源码与 PackageId 索引见 [`src/Modules/README.md`](src/Modules/README.md)。下列 Lombiq 外链为 Legacy OSOCE 说明，逐项迁移中。

- [`Lombiq.AuditTrailExtensions`](https://gitee.com/smartent/smartent-orchard-Extensions) A module with additional features for the [Audit Trail module](https://docs.orchardcore.net/en/latest/docs/reference/modules/AuditTrail/) in Orchard Core.
- [`Smartent.Orchard.ChartJs`](https://gitee.com/smartent/smartent-orchard-Extensions) An Orchard Core wrapper around the [Chart.js](https://www.chartjs.org/) library for displaying datasets as various charts.
- [`Lombiq.ContentEditors`](https://gitee.com/smartent/smartent-orchard-Extensions) With the help of this module you can create custom multi-page editors with async loading and saving. Watch a demo video of it from the Orchard Community Meeting [here](https://www.youtube.com/watch?v=WJ4dmbG9oVs).
- [`Lombiq.ContentEditors.Samples`](https://gitee.com/smartent/smartent-orchard-Extensions) Example Orchard Core module that makes use of Smartent Orchard Content Editors.
- [`Smartent.Orchard.DataTables`](https://gitee.com/smartent/smartent-orchard-Extensions) An Orchard Core wrapper around the [DataTables](https://datatables.net/) library for displaying tabular data from custom data sources.
- [`Smartent.Orchard.DataTables.Samples`](https://gitee.com/smartent/smartent-orchard-Extensions) Example Orchard Core module that makes use of Smartent Orchard Data Tables for Orchard Core.
- [`Lombiq.EmailClient`](https://gitee.com/smartent/smartent-orchard-Extensions) An Orchard Core module that fetches emails from an IMAP server either periodically from a background task or on-demand.
- [`Smartent.Orchard.Extensions.Cms`](https://gitee.com/smartent/smartent-orchard-Extensions) Orchard Core module containing some handy extensions (e.g. useful content types and widgets). This module is also available on all sites of [DotNest, the Orchard Core SaaS](https://dotnest.com/).
- [`Smartent.Demo.Platform.Samples`](https://gitee.com/smartent/smartent-orchard-Extensions) Example Orchard Core module that makes use of Lombiq Helpful Libraries.
- [`Lombiq.Hosting.Azure.ApplicationInsights`](https://gitee.com/smartent/smartent-orchard-Extensions) This [Orchard Core](https://orchardcore.net/) module enables easy integration of [Azure Application Insights](https://docs.microsoft.com/en-us/azure/azure-monitor/app/app-insights-overview) telemetry into Orchard. Just install the module, configure the instrumentation key from a configuration source (like the _appsettings.json_ file) as normally for AI, and collected data will start appearing in the Azure Portal. As seen on [the Orchard community meeting](https://www.youtube.com/watch?v=NKKR4R3UPog). Note that this module has an Orchard 1 version in the [`dev-orchard-1` branch](https://gitee.com/smartent/smartent-orchard-Extensions) Note that the module depends on [Helpful Libraries](https://gitee.com/smartent/smartent-orchard-Extensions)
- [`Lombiq.Hosting.BuildVersionDisplay`](https://gitee.com/smartent/smartent-orchard-Extensions) Module to display the build version (i.e. .NET assembly version or other) on the admin of the `Default` tenant. This is useful to see at a glance which version of the app you have to deployed currently to the given environment.
- [`Lombiq.Hosting.MediaTheme.Bridge`](https://gitee.com/smartent/smartent-orchard-Extensions) With the help of this module, you'll be able to host your theme assets and templates from Media Library. It can be used together with the [`Lombiq.Hosting.MediaTheme`](https://gitee.com/smartent/smartent-orchard-Extensions)
- [`Lombiq.Hosting.Tenants.Admin.Login`](https://gitee.com/smartent/smartent-orchard-Extensions) With the help of this module, you can log in from the Default tenant's admin dashboard to any other tenants as an administrator user. This is useful if you manage a lot of customer tenants and don't want to create individual logins of yours for each of them.
- [`Lombiq.Hosting.Tenants.EnvironmentRobots`](https://gitee.com/smartent/smartent-orchard-Extensions) With the help of this module, you can ensure that your sites will not be indexed by search bots. Check out a demo video of this module [here](https://youtu.be/Rp3ao2ZbNRs).
- [`Lombiq.Hosting.Tenants.FeaturesGuard`](https://gitee.com/smartent/smartent-orchard-Extensions) A module that makes it possible to conditionally enable and conditionally keep enabled, or entirely prevent enabling, configurable sets of features on tenants.
- [`Lombiq.Hosting.Tenants.HealthChecks`](https://gitee.com/smartent/smartent-orchard-Extensions) A module that makes [Health Checks](https://docs.orchardcore.net/en/main/reference/modules/HealthChecks/) in tenants report back to the Default tenant.
- [`Lombiq.Hosting.Tenants.IdleTenantManagement`](https://gitee.com/smartent/smartent-orchard-Extensions) With the help of this module, you can ensure that any tenant where the feature is enabled will shutdown after a preset time is elapsed. This can be used to free up resources.
- [`Lombiq.Hosting.Tenants.Maintenance`](https://gitee.com/smartent/smartent-orchard-Extensions) With the help of this module, you can execute maintenance tasks on tenants.
- [`Lombiq.Hosting.Tenants.Management`](https://gitee.com/smartent/smartent-orchard-Extensions) With the help of this module, you can set restrictions on tenant creation and set tenant level shell settings in the tenant editor.
- [`Lombiq.JsonEditor`](https://gitee.com/smartent/smartent-orchard-Extensions) Orchard Core module for displaying a JSON Editor like on [jsoneditoronline.org](https://jsoneditoronline.org/). Watch a demo video of it from the Orchard Community Meeting [here](https://www.youtube.com/watch?app=desktop&v=nFhRjhXTKAY).
- [`Lombiq.LoginAsAnybody`](https://gitee.com/smartent/smartent-orchard-Extensions) With the help of this module, an administrator can log in as anybody on the admin dashboard. Watch a demo video of it from the Orchard Community Meeting [here](https://www.youtube.com/watch?v=UlZhblts1BI).
- [`Lombiq.Marketing`](https://gitee.com/smartent/smartent-orchard-Extensions) Shared base project for Orchard Core marketing features. It contains common abstractions for client-side tracking and short URL hit registration. Watch a demo video of it from the Orchard Community Meeting [here](https://www.youtube.com/watch?v=RUDKOZKfXrY).
- [`Lombiq.Marketing.Pirsch`](https://gitee.com/smartent/smartent-orchard-Extensions) Basic [Pirsch](https://pirsch.io/ref/BQdZP2jgqM) integration for Orchard Core, with client-side tracking, a first-party script proxy, and server-side tracking for short URL redirects.
- [`Lombiq.Marketing.UrlShortener`](https://gitee.com/smartent/smartent-orchard-Extensions) Adds short URL support to Orchard Core. It can also store UTM values that marketing provider modules can use for server-side tracking during redirects.
- [`Smartent.Demo.Samples`](https://github.com/smartent-cn/smartent-orchard-Extensions/tree/dev/src/Modules/Smartent.Demo.Samples): This is a placeholder module that will contain sample code for UI tests and demonstration content for our open-source Orchard Core extensions.
- [`Lombiq.Privacy`](https://gitee.com/smartent/smartent-orchard-Extensions) Orchard module containing features related to data protection/privacy and the EU law on it, the [General Data Protection Regulation](https://eur-lex.europa.eu/legal-content/EN/TXT/?qid=1462439808430&uri=CELEX:32016R0679) (GDPR). Check out a demo video of this module [here](https://www.youtube.com/watch?v=GnyYL9Zdo8Q). **Important!** Using this module will not make your site GDPR-compliant alone. Do not forget to create a privacy policy page that you need to link to from the various consent-asking features.
- [`Lombiq.TrainingDemo`](https://gitee.com/smartent/smartent-orchard-Extensions) Demo Orchard Core module for training purposes guiding you to become an Orchard developer. Note that this module also has an Orchard 1.x version in the [`dev-orchard-1` branch of the repository](https://gitee.com/smartent/smartent-orchard-Extensions) If you prefer tutorial videos more then check out the [Dojo Course 3, the complete Orchard Core tutorial series](https://orcharddojo.net/orchard-training/dojo-course-3-the-full-orchard-core-tutorial).
- [`Smartent.Orchard.UIKit`](https://gitee.com/smartent/smartent-orchard-Extensions) This module contains reusable shapes like text editors, custom-style checkboxes, dropdown editors, and in the future potentially more complex editors. [Here](https://www.youtube.com/watch?v=PONfn2K8AHg) you can also see a demo of it. The module's Widgets feature provides widgets based on the Lombiq UI Kit reusable shapes.
- [`Lombiq.VueJs`](https://gitee.com/smartent/smartent-orchard-Extensions) [Orchard Core](https://orchardproject.net/) module that contains [Vue.js](https://vuejs.org/) resources.
- [`Lombiq.Walkthroughs`](https://gitee.com/smartent/smartent-orchard-Extensions) Do you want to learn about the most important Orchard Core features with a hands-on tutorial that guides you with interactive tooltips, right there in Orchard Core? This module is for you! Check out a demo video of it [here](https://www.youtube.com/watch?v=mWfngBADvX0).

### Themes（`src/`）

源码与 PackageId 见 [`src/Themes/README.md`](src/Themes/README.md)。

- `Smartent.Orchard.Theme.Base` / `.Native` / `.Samples`（原 Lombiq.BaseTheme.*）
- `Smartent.Orchard.Theme.Media` / `.Bridge` / `.Tests.Theme`（原 Lombiq.Hosting.MediaTheme.*）
- `Smartent.Build.Tailwind` 样例主题（原 Lombiq.Tailwind.Targets.Samples）

### Utilities / Build（src/Build）

见 [`src/Build/`](src/Build/) 与各子项目 `Readme.md`。

- `Smartent.Build.LibMan.Targets`、`Smartent.Build.Base.Sdk` 与各 Orchard Sdk（原 Lombiq.MSBuild.*）
- `Smartent.Build.Npm.Targets`、`Smartent.Build.NodeJs`（原 Lombiq.Npm / Lombiq.NodeJs.Extensions）
- `Smartent.Orchard.Setup`（原 Lombiq.SetupExtensions）
- `Smartent.Build.Tailwind`（原 Lombiq.Tailwind.Targets）

### Testing

- [`Smartent.Test.Unit`](https://gitee.com/smartent/smartent-orchard-Extensions) General and unit testing extensions and helpers, mostly for ASP.NET Core and Orchard Core. Also see our [UI Testing Toolbox](https://gitee.com/smartent/smartent-orchard-Extensions)
- [`Smartent.Test.UI`](https://gitee.com/smartent/smartent-orchard-Extensions) Web UI testing toolbox mostly for Orchard Core applications. Everything you need to do UI testing with Selenium for an Orchard app is here.
- [`Smartent.Test.UI.AppExtensions`](https://gitee.com/smartent/smartent-orchard-Extensions) UI testing-related configuration extensions for the web app under test. Note that the module depends on [Helpful Libraries](https://gitee.com/smartent/smartent-orchard-Extensions)
- [`Smartent.Test.UI.Samples`](https://gitee.com/smartent/smartent-orchard-Extensions) Example UI testing project. The whole project is heavily documented to teach you how to write UI tests with the UI Testing Toolbox. It guides you through this process just like the [Lombiq Training Demo for Orchard Core](https://gitee.com/smartent/smartent-orchard-Extensions) teaches Orchard Core and Orchard 1 development.
- [`Smartent.Test.UI.Shortcuts`](https://gitee.com/smartent/smartent-orchard-Extensions) Provides some useful shortcuts for common operations that UI tests might want to do or check, e.g. turning features on or off, or logging in users. This way, UI tests needn't use multi-step UI processes to do these operations (and thus implicitly be coupled with and tests those features). Note that the module depends on [Helpful Libraries](https://gitee.com/smartent/smartent-orchard-Extensions)
### Tools

- [`Smartent.Build.Analyzers`](https://gitee.com/smartent/smartent-orchard-Extensions) .NET code analyzers and code convention settings for [Smartent](https://gitee.com/smartent) projects, predominantly for [Orchard Core](https://orchardcore.net/) apps but also any .NET apps. We use these to enforce common standards across all our .NET projects, including e.g. all of our [open-source Orchard Core extensions](https://github.com/smartent-cn/smartent-orchard-Extensions).
- [`Smartent.Build.Analyzers.PowerShell`](https://gitee.com/smartent/smartent-orchard-Extensions) PowerShell static code analysis via [PSScriptAnalyzer](https://github.com/PowerShell/PSScriptAnalyzer) and Lombiq's recommended configuration for it. Use it from the CLI, in GitHub Actions, or integrated into MSBuild builds.
- [`Smartent.GitHub.Actions`](https://gitee.com/smartent/smartent-orchard-Extensions) Some common workflows and actions for GitHub Actions shared between Lombiq projects, e.g. to build and test Orchard Core apps, publish packages to NuGet, verify that a Git submodule pull request has a corresponding superproject one. These can be invoked from any other repository's build.

## Samples and Recipes

You can activate various sample content in the site:

- [`Lombiq.JsonEditor`](https://gitee.com/smartent/smartent-orchard-Extensions) Go to Recipes in the admin dashboard and select "Lombiq Open Source Orchard Core Extensions - JSON Editor Sample".
  - Content Items > JSON Example Page: Shows the sample item in action. Edit shows the JSON Editor where you can change the JSON value. View demonstrates simple JavaScript consuming the JSON content.
  - Content Definition > Content Types > JSON Example Page > JsonExampleField: You can edit the this field's JSON Editor's configuration object here. Check out the Templates property!
- [`Smartent.Test.UI`](https://gitee.com/smartent/smartent-orchard-Extensions) Web UI testing toolbox mostly for Orchard Core applications. Check out [its samples](https://gitee.com/smartent/smartent-orchard-Extensions) in this solution.
- [`Lombiq.TrainingDemo`](https://gitee.com/smartent/smartent-orchard-Extensions) Select the _Training Demo_ setup recipe when you first run the site.
- [`Smartent.Orchard.DataTables`](https://gitee.com/smartent/smartent-orchard-Extensions)
  - Go to Features in the admin dashboard and select "Smartent Orchard Data Tables - Samples".
  - Go to Recipes in the admin dashboard and select "Smartent Orchard Data Tables - Sample Content - Employee".
- [`Smartent.Orchard.Theme.Base.Samples`](src/Themes/Smartent.Orchard.Theme.Base/): Run recipe `Smartent.Demo.BaseTheme` or NuGetVerify `Smartent.NuGet.BaseTheme` in tests; feature id `Smartent.Orchard.Theme.Base.Samples`.
- [`Smartent.Orchard.ChartJs`](https://gitee.com/smartent/smartent-orchard-Extensions) Go to Recipes in the admin dashboard and select "Smartent Orchard Chart.js - Sample Content - Income/Expense".
- [`Lombiq.Privacy`](https://gitee.com/smartent/smartent-orchard-Extensions) Go to Recipes in the admin dashboard and select "Lombiq Privacy - Sample Content - Privacy, Forms, Workflows".
- [`Smartent.Orchard.Theme.Media`](src/Themes/Smartent.Orchard.Theme.Media/): Media Theme 部署配方见 `Smartent.NuGet.Web.recipe.json` / 主题模块文档。

## Contributing and support

Bug reports, feature requests, comments, questions, code contributions and love letters are warmly welcome. You can send them to us via GitHub issues and pull requests. Please adhere to our [open-source guidelines](https://lombiq.com/open-source-guidelines) while doing so.

This project is developed by [Smartent](https://lombiq.com/). Commercial-grade support is available through Lombiq.

### Adding a new extension or significant new features

When adding a new extension, or significant new features to existing extensions, do the following:

- For user-facing features add a recipe to it, demonstrating its usage with sample data. In that case, refer to it in the above section.
- If no data is needed or if the feature is more library-like, add a sample project (or in addition to the recipe). Put this project into the root of the submodule, so to have the main project's and sample project's folders side by side.
- Add lower-level unit/integration tests as necessary with the [Lombiq Testing Toolbox for Orchard Core](https://gitee.com/smartent/smartent-orchard-Extensions)
- If the sample project includes MVC actions, create a service that inherits from `MainMenuNavigationProviderBase` and adds front-end main menu items. The top level menu item should have the project's shortened name and the submenu items the individual actions. If you have several controllers, use separators and labels as you can see in the [TrainingDemoNavigationProvider.cs](https://gitee.com/smartent/smartent-orchard-Extensions)
- If the feature is user-facing, also add UI test extension method(s) with the [Smartent UI Testing for Orchard Core](https://gitee.com/smartent/smartent-orchard-Extensions) that assert on some important aspects, and execute them from a new UI test in `Smartent.Test.Acceptance` (for inspiration, see the examples there). These methods are also meant to be executed from UI tests in other projects when testing how it integrated with other features. If you've added a demo recipe or sample project to it then utilize that in the test too (see `ExecuteRecipeDirectlyAsync()`). For this, you'll also need to enable the feature in _Lombiq.OSOCE.Tests.recipe_.
- If the project is published on NuGet, reference it from the app in the `Smartent.NuGet` solution (`NuGetVerify/`) as well, and enable its features in the _Smartent.NuGet.Tests.recipe_. If it has UI testing methods, also run them from `Smartent.NuGet.Tests.UI`.
- If an extension is added, removed or significantly updated in this project, then add, remove or update its description under the "Included Projects" section of this Readme.

### Opening pull requests

- Open a pull request in this repository for every submodule pull request. That way, static code analysis and complex tests can run. If you forget to do so, a check in the submodule will fail. Once you've created the PR here, just click "Re-run jobs" in your submodule.
- If you see build errors under your pull request then check out its details: It will send you to the failed step in the Actions tab. You can also click on the "Summary" on the sidebar to download the artifacts (logs, screenshots, etc) and in case of failed UI tests you find the annotations linking to which test failed.
- Open a pull request for all but trivial changes (like typos) so we can nicely track them, including when generating release notes for the next release.
- If you introduce .NET breaking changes, the Validate NuGet Publish workflow will fail due to [baseline package validation](https://learn.microsoft.com/en-us/dotnet/fundamentals/apicompat/package-validation/baseline-version-validator). Preferably, adjust the change to not be breaking if possible; if it has to be a breaking change, then add a _CompatibilitySuppressions.xml_ file to mark it as deliberate. This will be generated by the workflow and made downloadable as an artifact for your convenience.

### .NET and Orchard Core version support policy

We try to balance allowing everyone to use the most recent .NET and Orchard Core versions they're comfortable with, while not forcing everyone to stay on the bleeding edge. To achieve this, we do the following:

- All of our projects target the latest Long-Term Support (LTS) version of .NET (the even-numbered ones, like .NET 8). While this means that those projects can't use the latest .NET APIs if a non-LTS version is the current one (the odd-numbered ones, like .NET 9), it also allows consumer projects to stay on the LTS version until the next LTS version is released (every two years). At the same time, consumer projects can always use a more recent version of .NET if they want to.
- The .NET build workflows of Lombiq GitHub Actions [always default to a specific version under the latest LTS version of the .NET SDK](https://gitee.com/smartent/smartent-orchard-Extensions) for the same reason. However, the SDK version can be configured if the app being built needs a different one.
- All of our shared Orchard Core-using projects (i.e. the ones that are published to NuGet too) target the latest `.0.0` major version of Orchard Core (barring any incompatibilities requiring us to deviate from this), e.g. `2.0.0`. This allows consumer projects to use them with any later version of Orchard Core under the same major version (like `2.0.1` or `2.1.5`), and we don't force an update beyond that. "Root" web projects, like `Smartent.Demo.Web` in this solution, always target the very latest Orchard Core version (like `2.1.7`) to make the app benefit from the latest improvements.

### Dependencies between Lombiq projects

When making a Lombiq project depend on another one from this solution, apart from adding a project reference and dependency in the extension manifest for Orchard Core extensions, also add a conditional package reference. This way, when published to NuGet, dependencies will still work. See the project file of `Smartent.Orchard.Extensions.Cms` for an example.

You can just have project references between projects in the same repo though if both projects are published on NuGet (like between projects of the [UI Testing Toolbox](https://gitee.com/smartent/smartent-orchard-Extensions) since those will be turned into package dependencies automatically.

You can use the `NuGetBuild` switch in the root _Directory.Build.props_ file to make all projects use NuGet references so you can update Lombiq packages for the whole solution.
