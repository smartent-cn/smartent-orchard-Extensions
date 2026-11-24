# Smartent Orchard Hosting - Build Version Display for Orchard Core
> **中文说明**: [Readme-CN.md](Readme-CN.md)


[![Smartent.Orchard.Hosting.BuildVersion NuGet](https://img.shields.io/nuget/v/Smartent.Orchard.Hosting.BuildVersion?label=Smartent.Orchard.Hosting.BuildVersion)](https://www.nuget.org/packages/Smartent.Orchard.Hosting.BuildVersion/) [![Smartent.Orchard.Hosting.BuildVersion.Tests.UI NuGet](https://img.shields.io/nuget/v/Smartent.Orchard.Hosting.BuildVersion.Tests.UI?label=Smartent.Orchard.Hosting.BuildVersion.Tests.UI)](https://www.nuget.org/packages/Smartent.Orchard.Hosting.BuildVersion.Tests.UI/)

## About

[Orchard Core](https://www.orchardcore.net/) module to display the build version (i.e. .NET assembly version or other) on the admin of the `Default` tenant. This is useful to see at a glance which version of the app you have deployed currently to the given environment. You can also display a link to the CI build's page. Watch a demo video of it from the Orchard Community Meeting [here](https://www.youtube.com/watch?v=fq5UnVGw_QA).

![Screenshot of Build Version Display on the Orchard Core dashboard](Smartent.Orchard.Hosting.BuildVersion/Docs/Attachments/Screenshot.png)

We at [Smartent](https://gitee.com/smartent/) also used this module for the new [Smartent website](https://gitee.com/smartent/) when migrating it from Orchard 1 to Orchard Core ([see case study](https://gitee.com/smartent/blog/how-we-renewed-and-migrated-orchard-site-from-orchard-1-to-orchard-core)). It also makes [DotNest, the Orchard Core SaaS](https://dotnest.com/) better.

Do you want to quickly try out this project and see it in action? Check it out in our [Open-Source Orchard Core Extensions](https://github.com/smartent-cn/smartent-orchard-Extensions) full Orchard Core solution and also see our other useful Orchard Core-related open-source projects!

## Documentation

Just enable the "Smartent Orchard Hosting - Build Version Display" feature on the `Default` tenant to display the Orchard Core version and the app's .NET version on the dashboard (i.e. _/admin_).

Optionally, a link to the CI build's page can be display as well. During `dotnet build`, provide this in the `BuildVersionDisplay_BuildUrl` property. E.g.:

```pwsh
dotnet build .\MyApp.sln -p:BuildVersionDisplay_BuildUrl=https://github.com/smartent-cn/smartent-orchard-Extensions/actions/runs/123
```

The [Deploy to Azure App Service workflow](https://gitee.com/smartent/smartent-orchard-Extensions) also takes care of this.

## Contributing and support

Bug reports, feature requests, comments, questions, code contributions and love letters are warmly welcome. You can send them to us via GitHub issues and pull requests. Please adhere to our [open-source guidelines](https://gitee.com/smartent/open-source-guidelines) while doing so.

This project is developed by [Smartent](https://gitee.com/smartent/). Commercial-grade support is available through Smartent.