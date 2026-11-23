# Lombiq MSBuild Targets - Library Manager for Orchard Core Modules

**中文**：Library Manager 集成 MSBuild 目标；**PackageId** `Smartent.Build.LibMan.Targets`（**2.1.1** core feed）。

**English**: LibMan MSBuild targets; PackageId rename planned in M7#11. Included in `Pack-SmartentLocalFeed.ps1` core list.

## About

Targets for [Microsoft Library Manager](https://github.com/aspnet/LibraryManager) integration. Include this project via NuGet or import its Props and Targets files to ensure the vendor assets in your _libman.json_ are fetched before build and included during publishing.

This target reduces [configuration boilerplate related to code generation](https://github.com/Lombiq/Helpful-Libraries/tree/dev/Lombiq.HelpfulLibraries.SourceGenerators) and applies necessary workarounds (e.g. issues with deployment mentioned [here](https://github.com/aspnet/LibraryManager/issues/799)).

For general details about and usage instructions see the [root Readme](../Readme.md).

Do you want to quickly try out this project and see it in action? Check it out in our [Open-Source Orchard Core Extensions](https://github.com/Lombiq/Open-Source-Orchard-Core-Extensions) full Orchard Core solution and also see our other useful Orchard Core-related open-source projects!

## Documentation

### Setup

#### From a Git submodule

1. Reference the targets in your project file by adding an `<Import>` element with the relative path of the Props file at the top end of your project file, and one for the Targets file at bottom end.
2. In the monorepo, CodeGen resolves via `Smartent-src/Platform/Core` automatically. Override `_SmartentCoreCodeGenPath` only in non-standard layouts.

For example:

```xml
<Project>
    <Import Project="../Smartent.Build.LibMan.Targets/Smartent.Build.LibMan.Targets.props" />
    
    <ItemGroup>
        <PackageReference Include="Microsoft.Web.LibraryManager.Build" Version="3.0.114" />
    </ItemGroup>

    <Import Project="../Smartent.Build.LibMan.Targets/Smartent.Build.LibMan.Targets.targets" />
</Project>
```

#### From a NuGet package

1. Reference [`Smartent.Build.LibMan.Targets`](https://www.nuget.org/packages/Smartent.Build.LibMan.Targets) (local feed **2.1.1** 或 Gitee Packages)。
2. Add [`Microsoft.Web.LibraryManager.Build`](https://www.nuget.org/packages/Microsoft.Web.LibraryManager.Build).
3. For generated libman version constants, add `Smartent.Core.CodeGen.Attributes` and `Smartent.Core.CodeGen.SourceGenerators` (see `Smartent.Build.Targets.Samples`).

For example:

```xml
<Project>
    <ItemGroup>
        <PackageReference Include="Microsoft.Web.LibraryManager.Build" Version="<latest version>" />
        <PackageReference Include="Smartent.Build.LibMan.Targets" Version="2.1.1" />
        <PackageReference Include="Smartent.Core.CodeGen.Attributes" Version="13.0.0" OutputItemType="Analyzer" ReferenceOutputAssembly="true" />
        <PackageReference Include="Smartent.Core.CodeGen.SourceGenerators" Version="13.0.0" OutputItemType="Analyzer" ReferenceOutputAssembly="false" />
    </ItemGroup>
</Project>
```

### Usage

1. If you don't have a _libman.json_ file yet, build the project after setup. This will copy an empty _libman.json_ file into the project directory, which is pre-configured to use the expected package output directory.
2. Now you can install new NPM packages using the CLI tool like this: `libman install "{NpmPackageName}@{Version}"`, e.g. `libman install chart.js@4.5.1`.
3. If you want to use the automatically generated version numbers (e.g. when declaring an asset in the Orchard Core resource manager), follow [the instructions in the Helpful Libraries documentation](https://github.com/Lombiq/Helpful-Libraries/tree/dev/Lombiq.HelpfulLibraries.SourceGenerators#using-the-libmanresourceversiongenerator).

## Contributing and support

Bug reports, feature requests, comments, questions, code contributions and love letters are warmly welcome. You can send them to us via GitHub issues and pull requests. Please adhere to our [open-source guidelines](https://lombiq.com/open-source-guidelines) while doing so.

This project is developed by [Lombiq Technologies](https://lombiq.com/). Commercial-grade support is available through Lombiq.
