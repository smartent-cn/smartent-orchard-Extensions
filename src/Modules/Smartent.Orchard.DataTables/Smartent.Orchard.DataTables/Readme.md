# Smartent.Orchard.DataTables

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables`

## Summary

An Orchard Core wrapper around the DataTables (https://datatables.net/) library for displaying tabular data from custom data sources. It lets you replace HTML tables with a tag helper or create asynchronous, sortable, searchable server-side generated tables. It also includes a pure Vue.js module that works similarly to DataTables.

## Features

**Implements**

- - An Orchard Core wrapper around the DataTables (https://datatables.net/) library for displaying tabular data from custom data sources. It lets you replace HTML tables with a tag helper or create asynchronous, sortable, searchable server-side generated tables. It also includes a pure Vue.js module that works similarly to DataTables.

**Out of scope**

- - Does not replace Orchard Core built-in features unless documented.

## References

### Monorepo (development)

```xml
<ProjectReference Include="../../../Platform/Orchard/Smartent.Orchard.Platform.Data.LinqToYesSql/Smartent.Orchard.Platform.Data.LinqToYesSql.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Orchard.DataTables" Version="1.0.0" />
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
| `ClosedXML` | Package | Version `0.105.1` |
| `Nito.AsyncEx.Tasks` | Package | Version `5.1.2` |
| `OrchardCore.Data.YesSql` | Package | Version `3.0.1` |
| `Smartent.Orchard.Platform.Data.LinqToYesSql` | Package | Version `$(PackageVersionSmartentPlatform)` |
| `MySqlConnector` | Package | Version `2.6.2` |

### Frontend (if applicable)

See [frontend-dependencies standard](../../docs/standards/frontend-dependencies.md). Run `pnpm`/`npm` scripts only when this folder has `package.json`.

| npm package | Version | Purpose | Build |
|-------------|---------|---------|-------|
| | `datatables.net` | 2.3.2 | dependencies | see package.json scripts |
| `datatables.net-bs5` | 2.3.2 | dependencies | see package.json scripts |
| `datatables.net-buttons` | 3.2.4 | dependencies | see package.json scripts |
| `datatables.net-buttons-bs5` | 3.2.4 | dependencies | see package.json scripts |
| `urijs` | 1.19.11 | dependencies | see package.json scripts | | | | |

## Upgrade & extension

- **Orchard**: Aligns with repository `OrchardCoreVersion` / central package management.
- **Extension points**: Drivers, handlers, shapes, and `IDataTableDataProvider`-style interfaces (see source).
- **Customization**: Prefer configuration keys under `Smartent_*` / `Smartent_Orchard_*`; this demo repo does not read legacy `Lombiq_*` sections.

## Tests

```powershell
dotnet build "src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.csproj"
dotnet test "src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
