<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.TrainingDemo

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.TrainingDemo` · **Path**: `src/Modules/Smartent.Orchard.TrainingDemo`

## Summary

Smartent.Orchard.TrainingDemo

## When to use

Training exercises and sample controllers for learning Orchard Core (demo only).

## Quick start

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Smartent.Orchard.TrainingDemo`** (and dependencies listed above).
4. Apply setup recipe if needed: `Smartent.Orchard.TrainingDemo/Recipes/TrainingDemo.Content.Sample.Person.recipe.json` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `Smartent.Orchard.TrainingDemo` | Smartent Orchard Training Demo | OrchardCore.Admin, OrchardCore.Apis.GraphQL, OrchardCore.BackgroundTasks, OrchardCore.ContentFields, OrchardCore.Contents, OrchardCore.ContentTypes, OrchardCore.DynamicCache, OrchardCore.HomeRoute, OrchardCore.Layers, OrchardCore.Localization, OrchardCore.Media, OrchardCore.Navigation, OrchardCore.Resources, OrchardCore.Roles, OrchardCore.Themes, OrchardCore.Users, OrchardCore.Workflows |
| `Smartent.Orchard.TrainingDemo.Middlewares` | Smartent Orchard Training Demo - Middlewares | Smartent.Orchard.TrainingDemo |

Enable in **Configuration → Features** (per tenant unless the module is host-only).

## Configuration

Configuration keys (under `OrchardCore`):

- `OrchardCore:Smartent_TrainingDemo`

Use double underscore in environment variables, e.g. `OrchardCore__Smartent_TrainingDemo__...`.

> Config sections use `Smartent_*` / `Smartent_Orchard_*` only (no legacy `Lombiq_*` in this demo repo).

## Usage (site owners & admins)

Use Orchard admin and module-specific menus after enabling features.

## Usage (developers)

Configuration section: `OrchardCore:Smartent_TrainingDemo` only (no Lombiq fallback).

### References

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.TrainingDemo" Version="1.0.0" />
```

## Samples & recipes

- `Smartent.Orchard.TrainingDemo/Recipes/TrainingDemo.Content.Sample.Person.recipe.json`
- `Smartent.Orchard.TrainingDemo/Recipes/TrainingDemo.Workflows.Sample.recipe.json`
- `Smartent.Orchard.TrainingDemo/Recipes/TrainingDemo.recipe.json`

## Pitfalls & cautions

- Not for production sites; disable in live environments.

## Tests

```powershell
dotnet build src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj
dotnet test src/Modules/Smartent.Orchard.TrainingDemo/*.Tests*.csproj
```

## Related projects in this folder

- `Smartent.Orchard.TrainingDemo` — main module
- `Smartent.Orchard.TrainingDemo.Tests` — automated/UI tests
- `Smartent.Orchard.TrainingDemo.Web` — main module

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.