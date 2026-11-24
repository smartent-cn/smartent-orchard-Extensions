<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.VueJs

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.VueJs` · **Path**: `src/Modules/Smartent.Orchard.VueJs`

## Summary

Smartent.Orchard.VueJs

## When to use

Host Vue 3 SFC components in Orchard shapes/pages with build pipeline integration.

## Quick start

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Smartent.Orchard.VueJs`** (and dependencies listed above).
4. Apply setup recipe if needed: `Smartent.Orchard.VueJs.Samples/Recipes/Smartent.Orchard.VueJs.Samples.Content.recipe.json` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| — | — | — |

Enable in **Configuration → Features** (per tenant unless the module is host-only).

## Configuration

No dedicated `appsettings` section in this package; configuration is optional or via Orchard settings.

> Config sections use `Smartent_*` / `Smartent_Orchard_*` only (no legacy `Lombiq_*` in this demo repo).

## Usage (site owners & admins)

Use Orchard admin and module-specific menus after enabling features.

## Usage (developers)

Use `vue-component-app` tag helper / `.smartent-vue` root; run `pnpm` scripts via `Smartent.Build.NodeJs`. Package name: `smartent-vuejs`.

### References

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.VueJs" Version="1.0.0" />
```

## Samples & recipes

- `Smartent.Orchard.VueJs.Samples/Recipes/Smartent.Orchard.VueJs.Samples.Content.recipe.json`

## Pitfalls & cautions

- Requires Node/pnpm for asset build before `dotnet build` when scripts change.
- CSP may block inline Vue hydration; align with `Smartent.Orchard.Platform` CSP module.

## Tests

```powershell
dotnet build src/Modules/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.csproj
dotnet test src/Modules/Smartent.Orchard.VueJs/*.Tests*.csproj
```

## Related projects in this folder

- `Smartent.Orchard.VueJs` — main module
- `Smartent.Orchard.VueJs.Resources` — main module
- `Smartent.Orchard.VueJs.Samples` — samples & recipes
- `Smartent.Orchard.VueJs.Tests.UI` — automated/UI tests

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.