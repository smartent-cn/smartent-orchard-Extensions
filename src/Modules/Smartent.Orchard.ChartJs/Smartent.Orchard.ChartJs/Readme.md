<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.ChartJs

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.ChartJs` · **Path**: `src/Modules/Smartent.Orchard.ChartJs`

## Summary

An Orchard Core wrapper around the Chart.js library for displaying datasets as various charts.

## When to use

Use for Chart.js widgets, admin charts, and sample dashboards in Orchard Core.

## Quick start

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Smartent.Orchard.ChartJs`** (and dependencies listed above).
4. Apply setup recipe if needed: `Smartent.Orchard.ChartJs.Samples/Recipes/Smartent.Orchard.ChartJs.Samples.Content.recipe.json` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `Smartent.Orchard.ChartJs` | Smartent Orchard Chart.js | OrchardCore.Contents |

Enable in **Configuration → Features** (per tenant unless the module is host-only).

## Configuration

No dedicated `appsettings` section in this package; configuration is optional or via Orchard settings.

> Config sections use `Smartent_*` / `Smartent_Orchard_*` only (no legacy `Lombiq_*` in this demo repo).

## Usage (site owners & admins)

Enable feature, add Chart widgets or use samples; see `Smartent.Orchard.ChartJs.Samples` recipes.

## Usage (developers)

Reference module, register Chart.js resources via shapes/widgets. Sample CSS class: `smartentChartJsSamplesChartContainer`.

### References

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.ChartJs" Version="1.0.0" />
```

## Samples & recipes

- `Smartent.Orchard.ChartJs.Samples/Recipes/Smartent.Orchard.ChartJs.Samples.Content.recipe.json`

## Pitfalls & cautions

- Load Chart.js only on pages that need charts (resource management).
- Align Chart.js version with bundled scripts in `wwwroot`.

## Tests

```powershell
dotnet build src/Modules/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs.csproj
dotnet test src/Modules/Smartent.Orchard.ChartJs/*.Tests*.csproj
```

## Related projects in this folder

- `Smartent.Orchard.ChartJs` — main module
- `Smartent.Orchard.ChartJs.Samples` — samples & recipes
- `Smartent.Orchard.ChartJs.Tests.UI` — automated/UI tests

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.