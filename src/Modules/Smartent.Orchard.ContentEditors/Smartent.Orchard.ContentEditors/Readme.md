<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.ContentEditors

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.ContentEditors` · **Path**: `src/Modules/Smartent.Orchard.ContentEditors`

## Summary

Module for managing advanced content editing processes based on editor groups and asynchronous operations.

## When to use

Orchard Core extension module in the Smartent demo monorepo.

## Quick start

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors.csproj`.
3. Run the site, open **Configuration → Features**, enable **`FeatureIds.AsyncEditor`** (and dependencies listed above).
4. Apply setup recipe if needed: `see Samples folder` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `FeatureIds.AsyncEditor` | Smartent Async Editor | OrchardCore.ContentFields |

Enable in **Configuration → Features** (per tenant unless the module is host-only).

## Configuration

No dedicated `appsettings` section in this package; configuration is optional or via Orchard settings.

> Config sections use `Smartent_*` / `Smartent_Orchard_*` only (no legacy `Lombiq_*` in this demo repo).

## Usage (site owners & admins)

Use Orchard admin and module-specific menus after enabling features.

## Usage (developers)

Extend via DI, handlers, shapes, and optional recipes in the Samples project.

### References

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.ContentEditors" Version="1.0.0" />
```

## Samples & recipes

- Optional: enable `Smartent.Orchard.ContentEditors.Samples` and import its recipes.

## Pitfalls & cautions

- Enable only required features per tenant.
- Test with `*.Tests` / `*.Tests.UI` before upgrading Orchard Core.

## Tests

```powershell
dotnet build src/Modules/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors.csproj
dotnet test src/Modules/Smartent.Orchard.ContentEditors/*.Tests*.csproj
```

## Related projects in this folder

- `Smartent.Orchard.ContentEditors` — main module
- `Smartent.Orchard.ContentEditors.Samples` — samples & recipes
- `Smartent.Orchard.ContentEditors.Tests.UI` — automated/UI tests

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.