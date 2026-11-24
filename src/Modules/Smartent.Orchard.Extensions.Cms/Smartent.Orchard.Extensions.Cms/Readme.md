# Smartent.Orchard.Extensions.Cms

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms`

## Summary

Orchard Core module containing some handy extensions (e.g. useful content types and widgets). It's also available on all sites of DotNest, the Orchard SaaS.

## Features

**Implements**

- - Orchard Core module containing some handy extensions (e.g. useful content types and widgets). It's also available on all sites of DotNest, the Orchard SaaS.

**Out of scope**

- - Does not replace Orchard Core built-in features unless documented.

## References

### Monorepo (development)

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Orchard.Extensions.Cms" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `（见 Manifest / Module.cs）`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Add the module to the host (`Program` / `Startup`), enable features in Admin → Configuration → Features, and run Recipes if provided under `Recipes/`.

## Dependencies

### .NET / Orchard

| Dependency | Type | Purpose |
|------------|------|---------|
| `OrchardCore.Autoroute` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Contents` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Flows` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Html` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Lists` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Liquid` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Markdown` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.MetaWeblog.Abstractions` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Rules.Abstractions` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Workflows` | Package | Version `$(OrchardCoreVersion)` |
| `Scrutor` | Package | Version `7.0.0` |
| `HtmlSanitizer` | Package | Version `9.2.1039` |

### Frontend (if applicable)

See [frontend-dependencies standard](../../docs/standards/frontend-dependencies.md). Run `pnpm`/`npm` scripts only when this folder has `package.json`.

| npm package | Version | Purpose | Build |
|-------------|---------|---------|-------|
| | `prismjs` | 1.30.0 | dependencies | see package.json scripts |
| `trumbowyg` | 2.31.0 | dependencies | see package.json scripts | | | | |

## Upgrade & extension

- **Orchard**: Aligns with repository `OrchardCoreVersion` / central package management.
- **Extension points**: Drivers, handlers, shapes, and `IDataTableDataProvider`-style interfaces (see source).
- **Customization**: Prefer configuration keys under `Smartent_*` / `Smartent_Orchard_*`; this demo repo does not read legacy `Lombiq_*` sections.

## Tests

```powershell
dotnet build "src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj"
dotnet test "src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
