<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.Extensions.Cms

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.Extensions.Cms` · **Path**: `src/Modules/Smartent.Orchard.Extensions.Cms`

## Summary

Orchard Core module containing some handy extensions (e.g. useful content types and widgets). It's also available on all sites of DotNest, the Orchard SaaS.

## When to use

Orchard Core extension module in the Smartent demo monorepo.

## Quick start

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj`.
3. Run the site, open **Configuration → Features**, enable **`CodeGeneration`** (and dependencies listed above).
4. Apply setup recipe if needed: `Smartent.Orchard.Extensions.Cms.Tests.UI/Recipes/Smartent.Orchard.Extensions.Cms.Tests.UI.Lucide.Tests.recipe.json` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `CodeGeneration` | Smartent Orchard Extensions - Code Generation Helpful Extensions | OrchardCore.Resources |
| `ContentSets` | Smartent Orchard Extensions - Content Sets | OrchardCore.ContentManagement |
| `Flows` | Smartent Orchard Extensions - Flows Helpful Extensions | OrchardCore.Flows |
| `Widgets` | Smartent Orchard Extensions - Helpful Widgets | OrchardCore.Html, OrchardCore.Liquid, OrchardCore.Title |
| `ContentTypes` | Smartent Orchard Extensions - Helpful Content Types | OrchardCore.Autoroute, OrchardCore.Flows, OrchardCore.Title |
| `Security` | Smartent Orchard Extensions - Security Helpful Extensions | — |
| `ShapeTracing` | Smartent Orchard Extensions - Shape Tracing Helpful Extensions | — |
| `FeatureIds.Shortcodes` | Smartent Orchard Extensions - Shortcode Extensions | — |
| `Emails` | Smartent Orchard Extensions - Emails | OrchardCore.Email |
| `TargetBlank` | Smartent Orchard Extensions - Target Blank | — |
| `SiteTexts` | Smartent Orchard Extensions - Site Texts | OrchardCore.Markdown |
| `OrchardRecipeMigration` | Smartent Orchard Extensions - Orchard 1 Recipe Migration | OrchardCore.Contents |
| `ResetPasswordActivity` | Smartent Orchard Extensions - Reset password workflow activity | OrchardCore.Users.ResetPassword, OrchardCore.Workflows |
| `Trumbowyg` | Smartent Orchard Extensions - Trumbowyg code snippet | — |
| `TrumbowygBlogPosts` | Smartent Orchard Extensions - Trumbowyg code snippet - Blog Posts | — |
| `GoogleTag` | Smartent Orchard Extensions - Google Tag | — |
| `Liquid` | Smartent Orchard Extensions - Liquid Tags | — |
| `Lucide` | Smartent Orchard Extensions - Lucide | OrchardCore.ContentFields, OrchardCore.Resources |
| `SimpleIcons` | Smartent Orchard Extensions - Simple Icons | OrchardCore.DisplayManagement |

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
<ProjectReference Include="src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.Extensions.Cms" Version="1.0.0" />
```

## Samples & recipes

- `Smartent.Orchard.Extensions.Cms.Tests.UI/Recipes/Smartent.Orchard.Extensions.Cms.Tests.UI.Lucide.Tests.recipe.json`
- `Smartent.Orchard.Extensions.Cms.Tests.UI/Recipes/Smartent.Orchard.Extensions.Cms.Tests.UI.TrumbowygBlogPosts.Tests.recipe.json`
- `Smartent.Orchard.Extensions.Cms/Recipes/Smartent.Orchard.Extensions.Cms.ContentSets.Sample.recipe.json`
- `Smartent.Orchard.Extensions.Cms/Recipes/Smartent.Orchard.Extensions.Cms.Liquid.Sample.recipe.json`

## Pitfalls & cautions

- Enable only required features per tenant.
- Test with `*.Tests` / `*.Tests.UI` before upgrading Orchard Core.

## Tests

```powershell
dotnet build src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj
dotnet test src/Modules/Smartent.Orchard.Extensions.Cms/*.Tests*.csproj
```

## Related projects in this folder

- `Smartent.Orchard.Extensions.Cms` — main module
- `Smartent.Orchard.Extensions.Cms.Tests.UI` — automated/UI tests

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.