# Smartent UI Testing Toolbox for Orchard Core
> **中文说明**: [Readme-CN.md](Readme-CN.md)


[![Smartent.Test.Unit NuGet](https://img.shields.io/nuget/v/Smartent.Test.Unit?label=Smartent.Test.Unit)](https://www.nuget.org/packages/Smartent.Test.Unit/)

## About

General and unit testing extensions and helpers, mostly for ASP.NET Core and Orchard Core. Check out the Orchard Harvest 2023 conference talk about automated QA in Orchard Core, including this project, [here](https://youtu.be/CHdhwD2NHBU). Also see our [UI Testing Toolbox](https://gitee.com/smartent/smartent-orchard-Extensions)
Do you want to learn about unit testing in Orchard Core? Check out the [unit testing tutorial of our Training Demo module](https://gitee.com/smartent/smartent-orchard-Extensions)
We at [Smartent](https://gitee.com/smartent/) also used this toolbox for the new [Smartent website](https://gitee.com/smartent/) when migrating it from Orchard 1 to Orchard Core ([see case study](https://gitee.com/smartent/blog/how-we-renewed-and-migrated-lombiq-com-from-orchard-1-to-orchard-core)). It also makes [DotNest, the Orchard Core SaaS](https://dotnest.com/) better.

Do you want to quickly try out this project and see it in action? Check it out in our [Open-Source Orchard Core Extensions](https://github.com/smartent-cn/smartent-orchard-Extensions) full Orchard Core solution and also see our other useful Orchard Core-related open-source projects!

## Documentation

Included helpers:

- [AutoMocker](https://github.com/moq/Moq.AutoMocker) extensions and shortcuts.
- `UserManager<TUser>` mocking helpers.

Inline documentation for methods is always included so be sure to check that out.

## Test runner

Test projects should reference `xunit.v3` and use [Microsoft Testing Platform](https://xunit.net/docs/getting-started/v3/microsoft-testing-platform). The `Smartent.MSBuild.OrchardCore.Tests.Sdk` SDK configures the test executable and reporting extensions.

For `dotnet test` with .NET 10 or later, add this to the solution's _global.json_ (preserving any existing SDK settings):

```json
{
  "test": {
    "runner": "Microsoft.Testing.Platform"
  }
}
```

Run a project with `dotnet test --project path/to/Tests.csproj`, or a solution with `dotnet test --solution path/to/Solution.slnx`. Remove the `Microsoft.NET.Test.Sdk` and `xunit.runner.visualstudio` package references when migrating from VSTest.

## Contributing and support

Bug reports, feature requests, comments, questions, code contributions and love letters are warmly welcome. You can send them to us via GitHub issues and pull requests. Please adhere to our [open-source guidelines](https://gitee.com/smartent/open-source-guidelines) while doing so.

This project is developed by [Smartent](https://gitee.com/smartent/). Commercial-grade support is available through Smartent.