# Using MSBuild SDKs

> [!NOTE]
> **Smartent monorepo**：Sdk 源码在 `src/Build/Smartent.Build.*`；本目录下各 `Smartent.MSBuild.*` 文件夹仅为 Legacy 占位 Readme。PackageId 仍为 `Smartent.MSBuild.*` 直至 M7 切换 `Smartent.Build.*`。
>
> The following document uses [Smartent.MSBuild.OrchardCore.Module.Sdk](../../../../src/Build/Smartent.Build.OrchardCore.Module.Sdk/Readme.md) as an example (all `Smartent.MSBuild.OrchardCore.*.Sdk` behave similarly).

It can be used by updating your project XML's root `Sdk` attribute to contain the NuGet package name and version, like this:

```xml
<Project Sdk="Smartent.Build.OrchardCore.Module.Sdk/1.0.0">
  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
  </PropertyGroup>
  ...
</Project>
```

Or by removing the `Sdk` attribute and importing the .props and .targets files directly form the NuGet package. In this case the `Sdk` attribute of the import indicates where to look for the file in the NuGet package cache.

```xml
<Project>
  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
  </PropertyGroup>

  <Import Project="Sdk.props" Sdk="Smartent.Build.OrchardCore.Module.Sdk" Version="1.0.0" />
  ...
  <Import Project="Sdk.targets" Sdk="Smartent.Build.OrchardCore.Module.Sdk" Version="1.0.0" />
</Project>
```

If you want to use a local copy rather than NuGet, you can import these files by giving a full path, like with any other Targets project:

```xml
<Project>
  <Import Condition="'$(NuGetBuild)' != 'true'" Project="../../../Build/Smartent.Build.OrchardCore.Module.Sdk/Sdk/Import.props" />
  ...
  <Import Condition="'$(NuGetBuild)' != 'true'" Project="../../../Build/Smartent.Build.OrchardCore.Module.Sdk/Sdk/Import.targets" />
</Project>
```

> [!IMPORTANT]
> Make sure to import the _Sdk.props_ and _Sdk.targets_ files for NuGet, but the _Import.props_ and _Import.targets_ files for submodule. They both reference the same [code files](Sdk/Core.props), but there are slight differences accounted in these different consumable files.

You can mix the latter two approaches if you need to support both NuGet and submodule use. We do this in our projects (for example [here](https://gitee.com/smartent/smartent-training-demo-modules because `<Sdk Condition="..." Name="...">` is not supported by .NET, so the two cases can only be toggled using imports.

## Common Features

All of our MSBuild SDK projects share these features and configurations:

- Link and pack _Readme.md_ and _NuGetIcon.png_ files, if they exist.
- Link and pack _../Readme.md_ as _Readme.md_ if it doesn't exist in the project directory. This is useful for the primary project of a repository.
- If the project has `<IsSmartentProject>true</IsSmartentProject>` (or legacy `<IsLombiqProject>true</IsLombiqProject>`), then a lot of NuGet properties are provided with appropriate defaults to reduce boilerplate:
  - Authors: Defaults to `Smartent`.
  - Copyright: Use the `<CopyrightYear>` property to make it `Copyright © $(CopyrightYear), Smartent`.
  - Description: Use the `<DescriptionBody>` property to make it `$(Title): $(DescriptionBody)`.
  - PackageIcon: Defaults to `NuGetIcon.png` if _NuGetIcon.png_ exists.
  - PackageTags: Defaults to `OrchardCore;Smartent;AspNetCore`.
  - PackageProjectUrl: Defaults to the value of `<RepositoryUrl>`, so you don't have to enter both if they are the same.
  - PackageLicenseExpression: Defaults to `BSD-3-Clause`.
- When you import the SDK via the _Import.props_ file, it tries to automatically set these values if they are not yet initialized:
  - SmartentSolutionRootPath: Repository root (alias `LombiqSolutionRootPath` for compatibility).
  - SmartentSrcPath: Path of the repository `src/` tree (Core/Platform/Build).
  - SmartentPlatformPath / `SmartentSrcPath`: 平台库在 _src/Platform_（NuGet：`Smartent.Orchard.Platform`）。
  - LombiqAnalyzersPath: Path of the _tools/Smartent.Build.Analyzers_ directory where the [.NET Analyzers](https://gitee.com/smartent/smartent-training-demo-modules submodule should be.
- If you import the SDK via the `<Sdk>` element or the _Sdk.props_ file, it sets the `<FromNuGet>true</FromNuGet>` property.

## LibMan Integration

If the project importing this SDK has a _libman.json_ file in the project root, then [Smartent.Build.LibMan.Targets](../Smartent.Build.LibMan.Targets/Readme.md) is automatically imported and all of its features can be used. To disable this feature, also include a _.disable-libman_ file in the project root. It can be empty, only file existence is checked.
