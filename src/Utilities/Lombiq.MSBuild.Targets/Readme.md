# Lombiq MSBuild Targets

> **Smartent 单仓**：各 `Lombiq.MSBuild.*` Sdk/LibMan **源码**在 [`Smartent-src/Build/`](../../../Smartent-src/Build/Readme.md)。本目录保留 **Samples、Tests** 与 Legacy **Readme 占位**。NuGet **PackageId** 仍为 `Lombiq.MSBuild.*`（目标草案 `Smartent.Build.*.Sdk`，见 [M6-PackageId-Exceptions.md](../../../重构-重组-改名项目方案/M6-PackageId-Exceptions.md)）。

[![Lombiq.MSBuild.Base.Sdk NuGet](https://img.shields.io/nuget/v/Lombiq.MSBuild.Base.Sdk?label=Lombiq.MSBuild.Base.Sdk)](https://www.nuget.org/packages/Lombiq.MSBuild.Base.Sdk/) [![Lombiq.MSBuild.LibMan.Targets NuGet](https://img.shields.io/nuget/v/Lombiq.MSBuild.LibMan.Targets?label=Lombiq.MSBuild.LibMan.Targets)](https://www.nuget.org/packages/Lombiq.MSBuild.LibMan.Targets/) [![Lombiq.MSBuild.Library.Sdk NuGet](https://img.shields.io/nuget/v/Lombiq.MSBuild.Library.Sdk?label=Lombiq.MSBuild.Library.Sdk)](https://www.nuget.org/packages/Lombiq.MSBuild.Library.Sdk/) [![Lombiq.MSBuild.OrchardCore.Module.Sdk NuGet](https://img.shields.io/nuget/v/Lombiq.MSBuild.OrchardCore.Module.Sdk?label=Lombiq.MSBuild.OrchardCore.Module.Sdk)](https://www.nuget.org/packages/Lombiq.MSBuild.OrchardCore.Module.Sdk/) [![Lombiq.MSBuild.OrchardCore.Tests.Sdk NuGet](https://img.shields.io/nuget/v/Lombiq.MSBuild.OrchardCore.Tests.Sdk?label=Lombiq.MSBuild.OrchardCore.Tests.Sdk)](https://www.nuget.org/packages/Lombiq.MSBuild.OrchardCore.Tests.Sdk/) [![Lombiq.MSBuild.OrchardCore.Tests.UI.Library.Sdk NuGet](https://img.shields.io/nuget/v/Lombiq.MSBuild.OrchardCore.Tests.UI.Library.Sdk?label=Lombiq.MSBuild.OrchardCore.Tests.UI.Library.Sdk)](https://www.nuget.org/packages/Lombiq.MSBuild.OrchardCore.Tests.UI.Library.Sdk/) [![Lombiq.MSBuild.OrchardCore.Tests.UI.Sdk NuGet](https://img.shields.io/nuget/v/Lombiq.MSBuild.OrchardCore.Tests.UI.Sdk?label=Lombiq.MSBuild.OrchardCore.Tests.UI.Sdk)](https://www.nuget.org/packages/Lombiq.MSBuild.OrchardCore.Tests.UI.Sdk/) [![Lombiq.MSBuild.OrchardCore.Theme.Sdk NuGet](https://img.shields.io/nuget/v/Lombiq.MSBuild.OrchardCore.Theme.Sdk?label=Lombiq.MSBuild.OrchardCore.Theme.Sdk)](https://www.nuget.org/packages/Lombiq.MSBuild.OrchardCore.Theme.Sdk/)

## About

Contains MSBuild Targets and Props files to streamline repetitive project configuration.

Do you want to quickly try out this project and see it in action? Check it out in our [Open-Source Orchard Core Extensions](https://github.com/Lombiq/Open-Source-Orchard-Core-Extensions) full Orchard Core solution and also see our other useful Orchard Core-related open-source projects!

## Documentation

To learn about the packages maintained in this repository, check out their individual Readmes:

- Targets (`Lombiq.MSBuild.*.Targets`):
  - [LibMan](../../../Smartent-src/Build/Lombiq.MSBuild.LibMan.Targets/Readme.md): [Microsoft Library Manager](https://github.com/aspnet/LibraryManager) integration.
- MSBuild SDKs (`Lombiq.MSBuild.*.Sdk`) — source under `Smartent-src/Build/`:
  - [Base](../../../Smartent-src/Build/Lombiq.MSBuild.Base.Sdk/Readme.md): Root SDK (rarely used directly).
  - [OrchardCore.Module](../../../Smartent-src/Build/Lombiq.MSBuild.OrchardCore.Module.Sdk/Readme.md): Orchard Core modules.
  - [OrchardCore.Tests](../../../Smartent-src/Build/Lombiq.MSBuild.OrchardCore.Tests.Sdk/Readme.md): Unit tests with `Smartent.Test.Unit`.
  - [OrchardCore.Tests.UI](../../../Smartent-src/Build/Lombiq.MSBuild.OrchardCore.Tests.UI.Sdk/Readme.md): UI tests with `Smartent.Test.UI`.
  - [OrchardCore.Tests.UI.Library](../../../Smartent-src/Build/Lombiq.MSBuild.OrchardCore.Tests.UI.Library.Sdk/Readme.md): Reusable UI test libraries.
  - [OrchardCore.Theme](../../../Smartent-src/Build/Lombiq.MSBuild.OrchardCore.Theme.Sdk/Readme.md): Orchard Core themes.

> [!NOTE]
> Read about how to use and configure our MSBuild SDKs [here](Docs/UsingMSBuildSdks.md).

> [!TIP]
> Check out the [`Lombiq.MSBuild.Targets.Samples` project](Lombiq.MSBuild.Targets.Samples/Readme.md) for examples.

## Contributing and support

Bug reports, feature requests, comments, questions, code contributions and love letters are warmly welcome. You can send them to us via GitHub issues and pull requests. Please adhere to our [open-source guidelines](https://lombiq.com/open-source-guidelines) while doing so.

This project is developed by [Lombiq Technologies](https://lombiq.com/). Commercial-grade support is available through Lombiq.
