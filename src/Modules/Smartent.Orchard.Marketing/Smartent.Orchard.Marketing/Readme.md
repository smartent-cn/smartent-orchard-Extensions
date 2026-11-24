<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.Marketing

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.Marketing` · **Path**: `src/Modules/Smartent.Orchard.Marketing`

## Summary

Shared marketing abstractions, short URL hit handling, and client-side tracking composition.

## When to use

Pirsch analytics, URL shortener, and marketing tracking integration.

## Quick start

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing.csproj`.
3. Run the site, open **Configuration → Features**, enable **`FeatureIds.Base`** (and dependencies listed above).
4. Apply setup recipe if needed: `see Samples folder` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `FeatureIds.Base` | Smartent Orchard Marketing | — |

Enable in **Configuration → Features** (per tenant unless the module is host-only).

## Configuration

Configuration keys (under `OrchardCore`):

- `OrchardCore:Smartent_Marketing`

Use double underscore in environment variables, e.g. `OrchardCore__Smartent_Marketing__...`.

> Config sections use `Smartent_*` / `Smartent_Orchard_*` only (no legacy `Lombiq_*` in this demo repo).

## Usage (site owners & admins)

Use Orchard admin and module-specific menus after enabling features.

## Usage (developers)

Configure `OrchardCore:Smartent_Marketing` in `appsettings.json`; submodules: `Smartent.Orchard.Marketing.Pirsch`, `.UrlShortener`.

### References

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.Marketing" Version="1.0.0" />
```

## Samples & recipes

- Optional: enable `Smartent.Orchard.Marketing.Samples` and import its recipes.

## Pitfalls & cautions

- Do not commit Pirsch tokens; use secrets.
- Short links migrations seed example campaigns only.

## Tests

```powershell
dotnet build src/Modules/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing.csproj
dotnet test src/Modules/Smartent.Orchard.Marketing/*.Tests*.csproj
```

## Related projects in this folder

- `Smartent.Orchard.Marketing` — main module
- `Smartent.Orchard.Marketing.Pirsch` — main module
- `Smartent.Orchard.Marketing.Tests.UI` — automated/UI tests
- `Smartent.Orchard.Marketing.UrlShortener` — main module

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.