<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.DataTables

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.DataTables` · **Path**: `src/Modules/Smartent.Orchard.DataTables`

## Summary

An Orchard Core wrapper around the DataTables (https://datatables.net/) library for displaying tabular data from custom data sources. It lets you replace HTML tables with a tag helper or create asynchronous, sortable, searchable server-side generated tables. It also includes a pure Vue.js module that works similarly to DataTables.

## When to use

Sortable/searchable tables from custom data providers, admin grids, or DOM/tag-helper tables.

## Quick start

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Smartent.Orchard.DataTables`** (and dependencies listed above).
4. Apply setup recipe if needed: `Smartent.Orchard.DataTables.Samples/Recipes/Smartent.Orchard.DataTables.Samples.Content.recipe.json` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `Smartent.Orchard.DataTables` | Smartent Orchard Data Tables | OrchardCore.Contents, OrchardCore.ResourceManagement, OrchardCore.Queries |

Enable in **Configuration → Features** (per tenant unless the module is host-only).

## Configuration

No dedicated `appsettings` section in this package; configuration is optional or via Orchard settings.

> Config sections use `Smartent_*` / `Smartent_Orchard_*` only (no legacy `Lombiq_*` in this demo repo).

## Usage (site owners & admins)

Use `/Admin/DataTable/{providerName}/{queryId?}` for single-table admin pages; enable Samples for demos.

## Usage (developers)

Implement `IDataTableDataProvider`, register with `AddDataTableDataProvider<T>()`. JS plugin: `smartent_DataTables`; events `.smartentdt`.

### References

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.DataTables" Version="1.0.0" />
```

## Samples & recipes

- `Smartent.Orchard.DataTables.Samples/Recipes/Smartent.Orchard.DataTables.Samples.Content.recipe.json`

## Pitfalls & cautions

- Index-based providers need migrations/recipes for index rebuild.
- Heavy queries: prefer `IndexBasedDataTableDataProvider` over on-demand SQL.

## Tests

```powershell
dotnet build src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.csproj
dotnet test src/Modules/Smartent.Orchard.DataTables/*.Tests*.csproj
```

## Related projects in this folder

- `Smartent.Orchard.DataTables` — main module
- `Smartent.Orchard.DataTables.Samples` — samples & recipes
- `Smartent.Orchard.DataTables.Tests` — automated/UI tests
- `Smartent.Orchard.DataTables.Tests.UI` — automated/UI tests

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.