<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.UIKit

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.UIKit` · **Path**: `src/Modules/Smartent.Orchard.UIKit`

## Summary

This module contains reusable shapes like text editors, custom-style checkboxes, dropdown editors, and in the future potentially more complex editors.

## When to use

Orchard Core extension module in the Smartent demo monorepo.

## Quick start

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Base`** (and dependencies listed above).
4. Apply setup recipe if needed: `Smartent.Orchard.UIKit.Widgets/Recipes/Smartent.Orchard.UIKit.Widgets.Content.recipe.json` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `Base` | Smartent Orchard UI Kit | — |
| `Showcase` | Smartent Orchard UI Kit - Showcase page | Smartent.Orchard.UIKit |

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
<ProjectReference Include="src/Modules/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.UIKit" Version="1.0.0" />
```

## Samples & recipes

- `Smartent.Orchard.UIKit.Widgets/Recipes/Smartent.Orchard.UIKit.Widgets.Content.recipe.json`

## Pitfalls & cautions

- Enable only required features per tenant.
- Test with `*.Tests` / `*.Tests.UI` before upgrading Orchard Core.

## Tests

```powershell
dotnet build src/Modules/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit.csproj
dotnet test src/Modules/Smartent.Orchard.UIKit/*.Tests*.csproj
```

## Related projects in this folder

- `Smartent.Orchard.UIKit` — main module
- `Smartent.Orchard.UIKit.Tests.UI` — automated/UI tests
- `Smartent.Orchard.UIKit.Widgets` — main module
- `Smartent.Orchard.UIKit.Widgets.Tests.UI` — automated/UI tests

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.