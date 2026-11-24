<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.Walkthroughs

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.Walkthroughs` · **Path**: `src/Modules/Smartent.Orchard.Walkthroughs`

## Summary

Orchard Core module to teach you the fundamentals of using the CMS features with step-by-step guides.

## When to use

Guided on-site walkthroughs (Shepherd.js-style) for onboarding editors.

## Quick start

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.Walkthroughs/Smartent.Orchard.Walkthroughs/Smartent.Orchard.Walkthroughs.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.Walkthroughs/Smartent.Orchard.Walkthroughs/Smartent.Orchard.Walkthroughs.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Smartent.Orchard.Walkthroughs`** (and dependencies listed above).
4. Apply setup recipe if needed: `Smartent.Orchard.Walkthroughs/Recipes/Smartent.Orchard.Walkthroughs.Setup.recipe.json` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `Smartent.Orchard.Walkthroughs` | Smartent Orchard Walkthroughs | OrchardCore.Contents, OrchardCore.ResourceManagement |

Enable in **Configuration → Features** (per tenant unless the module is host-only).

## Configuration

No dedicated `appsettings` section in this package; configuration is optional or via Orchard settings.

> Config sections use `Smartent_*` / `Smartent_Orchard_*` only (no legacy `Lombiq_*` in this demo repo).

## Usage (site owners & admins)

Import `Smartent.Orchard.Walkthroughs.Setup.recipe.json` then configure walks in admin.

## Usage (developers)

Extend via DI, handlers, shapes, and optional recipes in the Samples project.

### References

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.Walkthroughs/Smartent.Orchard.Walkthroughs/Smartent.Orchard.Walkthroughs.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.Walkthroughs" Version="1.0.0" />
```

## Samples & recipes

- `Smartent.Orchard.Walkthroughs/Recipes/Smartent.Orchard.Walkthroughs.Setup.recipe.json`

## Pitfalls & cautions

- Walkthrough scripts run in admin/front UI; test after theme changes.

## Tests

```powershell
dotnet build src/Modules/Smartent.Orchard.Walkthroughs/Smartent.Orchard.Walkthroughs/Smartent.Orchard.Walkthroughs.csproj
dotnet test src/Modules/Smartent.Orchard.Walkthroughs/*.Tests*.csproj
```

## Related projects in this folder

- `Smartent.Orchard.Walkthroughs` — main module
- `Smartent.Orchard.Walkthroughs.Tests.UI` — automated/UI tests

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.