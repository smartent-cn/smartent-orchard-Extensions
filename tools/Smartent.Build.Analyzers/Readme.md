# Smartent .NET Analyzers

> **Smartent 单仓说明**：开发期通过 `tools/Smartent.Build.Analyzers` 与 NuGet 包 `Smartent.Build.Analyzers.*` 接入；待发布目标为 `Smartent.Build.Analyzers*`（见 [M6-PackageId-Exceptions.md](../../重构-重组-改名项目方案/M6-PackageId-Exceptions.md)）。MSBuild 属性 `SmartentAnalyzersPath` 与 `LombiqAnalyzersPath` 同源。

[![Smartent.Build.Analyzers NuGet](https://img.shields.io/nuget/v/Smartent.Build.Analyzers?label=Smartent.Build.Analyzers)](https://www.nuget.org/packages/Smartent.Build.Analyzers/) [![Smartent.Build.Analyzers.NetFx NuGet](https://img.shields.io/nuget/v/Smartent.Build.Analyzers.NetFx?label=Smartent.Build.Analyzers.NetFx)](https://www.nuget.org/packages/Smartent.Build.Analyzers.NetFx/) [![Smartent.Build.Analyzers.OrchardCore NuGet](https://img.shields.io/nuget/v/Smartent.Build.Analyzers.OrchardCore?label=Smartent.Build.Analyzers.OrchardCore)](https://www.nuget.org/packages/Smartent.Build.Analyzers.OrchardCore/) [![Smartent.Build.Analyzers.Orchard1 NuGet](https://img.shields.io/nuget/v/Smartent.Build.Analyzers.Orchard1?label=Smartent.Build.Analyzers.Orchard1)](https://www.nuget.org/packages/Smartent.Build.Analyzers.Orchard1/) [![Smartent.Build.Analyzers.VisualStudioExtension NuGet](https://img.shields.io/nuget/v/Smartent.Build.Analyzers.VisualStudioExtension?label=Smartent.Build.Analyzers.VisualStudioExtension)](https://www.nuget.org/packages/Smartent.Build.Analyzers.VisualStudioExtension/)

## About

.NET code analyzers and code convention settings for [Lombiq](https://gitee.com/smartent) projects, for [Orchard Core](https://orchardcore.net/) and any other .NET and .NET Framework apps. We use these to enforce common standards across all our .NET projects, including e.g. all of our [open-source Orchard Core extensions](https://gitee.com/smartent/smartent-orchard-Extensions) If you contribute to our open-source projects while using that solution you'll be guided by these rules, too. You can check out a demo video of the project [here](https://www.youtube.com/watch?v=dtbGRi3Cezs), and the Orchard Harvest 2023 conference talk about automated QA in Orchard Core [here](https://youtu.be/CHdhwD2NHBU).

There is also support for non-SDK-style .NET Framework projects, as long as they use `PackageReference` for their dependencies (in contrast to _packages.config_).

Some other projects you may be interested in:

- Looking for something similar for JavaScript, CSS, and even Markdown and YAML? Check out the [Asset Linting workflow](https://gitee.com/smartent/smartent-orchard-Extensions) of our Lombiq GitHub Actions project.
- Looking not just for static code analysis but also dynamic testing? Check out our [UI Testing Toolbox](https://gitee.com/smartent/smartent-orchard-Extensions) and [Testing Toolbox](https://gitee.com/smartent/smartent-orchard-Extensions) projects.
- Looking for a library that'll help you comply with analyzer rules? Check out our [Helpful Libraries project](https://gitee.com/smartent/smartent-training-demo-modules

We at [Lombiq](https://gitee.com/smartent/) also used this module for the following projects:

- The new [City of Santa Monica website](https://santamonica.gov/) when migrating it from Orchard 1 to Orchard Core ([see case study](https://gitee.com/smartent/blog/helping-the-city-of-santa-monica-with-orchard-core-consulting)).
- The new [Smithsonian Folkways Recordings website](https://folkways.si.edu/) when migrating it from Orchard 1 to Orchard Core ([see case study](https://gitee.com/smartent/blog/smithsonian-folkways-recordings-now-upgraded-to-orchard-core)).
- The new [Lombiq website](https://gitee.com/smartent/) when migrating it from Orchard 1 to Orchard Core ([see case study](https://gitee.com/smartent/blog/how-we-renewed-and-migrated-lombiq-com-from-orchard-1-to-orchard-core)).
- The new client portal for [WTW](https://www.wtwco.com/) ([see case study](https://gitee.com/smartent/blog/lombiq-s-journey-with-wtw-s-client-portal)).
- It also makes [DotNest, the Orchard SaaS](https://dotnest.com/) better.

Do you want to quickly try out this project and see it in action? Check it out in our [Open-Source Orchard Core Extensions](https://gitee.com/smartent/smartent-orchard-Extensions) full Orchard Core solution and also see our other useful Orchard Core-related open-source projects!

## Analyzer packages used

We added and configured analyzers which are widely used and complement each other.

- [.NET code style analysis](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview#code-style-analysis)
- [.NET code quality analysis](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview#code-quality-analysis)
- [AsyncFixer](https://www.nuget.org/packages/AsyncFixer)
- [DotNetAnalyzers.DocumentationAnalyzers](https://www.nuget.org/packages/DotNetAnalyzers.DocumentationAnalyzers/)
- [Meziantou.Analyzer](https://www.nuget.org/packages/Meziantou.Analyzer/) (Note: not used directly in `Smartent.Build.Analyzers`, different versions of the package are used in `Smartent.Build.Analyzers.OrchardCore` and `Smartent.Build.Analyzers.NetFx`)
- [Microsoft.CodeAnalysis.NetAnalyzers](https://www.nuget.org/packages/Microsoft.CodeAnalysis.NetAnalyzers)
- [Microsoft.VisualStudio.Threading.Analyzers](https://www.nuget.org/packages/microsoft.visualstudio.threading.analyzers)
- [SecurityCodeScan.VS2019](https://www.nuget.org/packages/SecurityCodeScan.VS2019/)
- [StyleCop.Analyzers](https://www.nuget.org/packages/StyleCop.Analyzers/)
- [SonarAnalyzer.CSharp](https://www.nuget.org/packages/SonarAnalyzer.CSharp/)

Furthermore, the project also includes an _.editorconfig_ file with additional configuration for compatible editors.

## Guides

- [Adding analyzers to your project](Smartent.Build.Analyzers/Docs/AddingAnalyzers.md)
- [Using the analyzers during development](Smartent.Build.Analyzers/Docs/UsingAnalyzersDuringDevelopment.md)
- [Using the analyzers during command line builds](Smartent.Build.Analyzers/Docs/UsingAnalyzersDuringCommandLineBuilds.md)
- [Configuring analyzers](Smartent.Build.Analyzers/Docs/ConfiguringAnalyzers.md)

## Contributing and support

Bug reports, feature requests, comments, questions, code contributions and love letters are warmly welcome. You can send them to us via GitHub issues and pull requests. Please adhere to our [open-source guidelines](https://gitee.com/smartent/open-source-guidelines) while doing so.

This project is developed by [Smartent](https://gitee.com/smartent/). Commercial-grade support is available through Lombiq.

### Publishing a new NuGet package

When publishing a new version of the NuGet package, even if it's just a pre-release, also update the package references under _TestSolutions\Smartent.Build.Analyzers.PackageReferences_ to the new version. This is necessary to run the tests there.

### Upgrading to a new version of the .NET SDK

When a new version of the .NET SDK comes out then to the following:

- Change the `LangVersion` and `AnalysisLevel` elements in the _Build.props_ file to opt in to new language features and analyzers. This does not concern non-SDK-style .NET Framework projects.
- Wait for all analyzers to support the new SDK (primarily the new language features). Then update all packages to latest.
- Check if there are new [code analysis categories](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/categories) that we need to surface warnings for by default in the _Smartent.Build.Analyzers.globalconfig_ file.

### Adding a new analyzer

When adding a new analyzer package, do the following:

- Check if the project is actively developed with issues addressed quickly.
- Check if it has any significant impact on build or editing performance.
- Go through all rules in the package and decide one by one whether we need them.
  - Check for rules that are already covered by some other analyzer and disable duplicates.
  - All rules that we need should be surfaced as Warnings. This allows to only break the build on analyzer violations when we need it, i.e. during CI builds but not during development.
  - Add rule configuration to the _.globalconfig_ file of the relevant project, depending on which kind of applications they're applicable to. Editor-only configuration should be in _.editorconfig_ files.
- Test it on multiple significant solutions. Using the [Hastlayer SDK](https://gitee.com/smartent/smartent-orchard-Extensions) is a good example as it's a large C# solution.
