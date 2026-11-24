<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.Privacy

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.Privacy` · **Path**: `src/Modules/Smartent.Orchard.Privacy`

## Summary

Orchard module containing features related to data protection/privacy and the EU law on it, the General Data Protection Regulation (GDPR).

## When to use

GDPR-style consent banner, registration checkbox, and privacy widgets.

## Quick start

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Module`** (and dependencies listed above).
4. Apply setup recipe if needed: `Smartent.Orchard.Privacy.Samples/Recipes/Smartent.Orchard.Privacy.Samples.Content.recipe.json` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `Module` | Smartent Orchard Privacy | — |
| `ConsentBanner` | Smartent Orchard Privacy - Consent banner | OrchardCore.CustomSettings |
| `RegistrationConsent` | Smartent Orchard Privacy - Registration consent | OrchardCore.CustomSettings, OrchardCore.Users.Registration |
| `ExternalRegistrationConsent` | Smartent Orchard Privacy - External Registration consent | OrchardCore.Users.ExternalAuthentication |
| `FormConsent` | Smartent Orchard Privacy - Form consent | OrchardCore.CustomSettings, OrchardCore.Forms |

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
<ProjectReference Include="src/Modules/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.Privacy" Version="1.0.0" />
```

## Samples & recipes

- `Smartent.Orchard.Privacy.Samples/Recipes/Smartent.Orchard.Privacy.Samples.Content.recipe.json`
- `Smartent.Orchard.Privacy.Samples/Recipes/Smartent.Orchard.Privacy.Samples.ContentDefinition.recipe.json`
- `Smartent.Orchard.Privacy.Samples/Recipes/Smartent.Orchard.Privacy.Samples.FeaturesAndSettings.recipe.json`
- `Smartent.Orchard.Privacy.Samples/Recipes/Smartent.Orchard.Privacy.Samples.WorkflowType.recipe.json`
- `Smartent.Orchard.Privacy.Samples/Recipes/Smartent.Orchard.Privacy.Samples.recipe.json`
- `Smartent.Orchard.Privacy/Migrations/Recipes/PrivacyConsentBannerSettings.recipe.json`
- `Smartent.Orchard.Privacy/Migrations/Recipes/PrivacyConsentCheckboxSettings.recipe.json`
- `Smartent.Orchard.Privacy/Migrations/Recipes/PrivacyRegistrationConsentSettings.recipe.json`

## Pitfalls & cautions

- Legal text is your responsibility; module provides mechanics only.
- Shapes use `Smartent_Orchard_Privacy_*` ids; update theme overrides accordingly.

## Tests

```powershell
dotnet build src/Modules/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy.csproj
dotnet test src/Modules/Smartent.Orchard.Privacy/*.Tests*.csproj
```

## Related projects in this folder

- `Smartent.Orchard.Privacy` — main module
- `Smartent.Orchard.Privacy.Samples` — samples & recipes
- `Smartent.Orchard.Privacy.Tests.UI` — automated/UI tests

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.