<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.JsonEditor

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.JsonEditor` · **Path**: `src/Modules/Smartent.Orchard.JsonEditor`

## Summary

Orchard Core module for displaying a JSON Editor like on (https://jsoneditoronline.org/.

## When to use

Orchard Core extension module in the Smartent demo monorepo.

## Quick start

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Default`** (and dependencies listed above).
4. Apply setup recipe if needed: `Smartent.Orchard.JsonEditor/Recipes/JsonEditor.Sample.recipe.json` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `Default` | Smartent Orchard JSON Editor | OrchardCore.Contents, OrchardCore.ResourceManagement |
| `ContentEditor` | Smartent JSON Content Editor | — |

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
<ProjectReference Include="src/Modules/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.JsonEditor" Version="1.0.0" />
```

## Samples & recipes

- `Smartent.Orchard.JsonEditor/Recipes/JsonEditor.Sample.recipe.json`

## Pitfalls & cautions

- Enable only required features per tenant.
- Test with `*.Tests` / `*.Tests.UI` before upgrading Orchard Core.

## Tests

```powershell
dotnet build src/Modules/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor.csproj
dotnet test src/Modules/Smartent.Orchard.JsonEditor/*.Tests*.csproj
```

## Related projects in this folder

- `Smartent.Orchard.JsonEditor` — main module
- `Smartent.Orchard.JsonEditor.Tests.UI` — automated/UI tests

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.