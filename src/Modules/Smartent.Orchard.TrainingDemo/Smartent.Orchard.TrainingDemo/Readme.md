# Smartent.Orchard.TrainingDemo

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo`

## Summary

Smartent Orchard Training Demo

## Features

**Implements**

- - Smartent Orchard Training Demo

**Out of scope**

- - Does not replace Orchard Core built-in features unless documented.

## References

### Monorepo (development)

```xml
<ProjectReference Include="../../../Platform/Orchard/Smartent.Orchard.Platform/Smartent.Orchard.Platform.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Orchard.TrainingDemo" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `Smartent.Orchard.TrainingDemo, Smartent.Orchard.TrainingDemo.Middlewares`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Add the module to the host (`Program` / `Startup`), enable features in Admin → Configuration → Features, and run Recipes if provided under `Recipes/`.

## Dependencies

### .NET / Orchard

| Dependency | Type | Purpose |
|------------|------|---------|
| `Microsoft.Web.LibraryManager.Build` | Package | Version `3.0.114` |
| `OrchardCore.Users.Abstractions` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Workflows.Abstractions` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.BackgroundTasks` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.ContentFields` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.ContentManagement` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.ContentTypes.Abstractions` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Data.Abstractions` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.DynamicCache` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.FileStorage.FileSystem` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Indexing.Abstractions` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Media.Abstractions` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Module.Targets` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.ResourceManagement` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.DisplayManagement` | Package | Version `$(OrchardCoreVersion)` |
| `Smartent.Orchard.Platform` | Package | Version `13.0.1-alpha.5.osoe-344` |
| `MySqlConnector` | Package | Version `2.6.2` |
| `HtmlSanitizer` | Package | Version `9.2.1039` |

### Frontend (if applicable)

See [frontend-dependencies standard](../../docs/standards/frontend-dependencies.md). Run `pnpm`/`npm` scripts only when this folder has `package.json`.

| npm package | Version | Purpose | Build |
|-------------|---------|---------|-------|
| | — | — | — | — | | | | |

## Upgrade & extension

- **Orchard**: Aligns with repository `OrchardCoreVersion` / central package management.
- **Extension points**: Drivers, handlers, shapes, and `IDataTableDataProvider`-style interfaces (see source).
- **Customization**: Prefer configuration keys under `Smartent_*` / `Smartent_Orchard_*`; this demo repo does not read legacy `Lombiq_*` sections.

## Tests

```powershell
dotnet build "src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj"
dotnet test "src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
