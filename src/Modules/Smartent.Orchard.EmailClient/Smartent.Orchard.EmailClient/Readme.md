<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.EmailClient

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.EmailClient` · **Path**: `src/Modules/Smartent.Orchard.EmailClient`

## Summary

With the help of this module, you can do advanced email operations such as downloading them using IMAP.

## When to use

IMAP/sync email inside Orchard admin for support or editorial workflows.

## Quick start

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Smartent.Orchard.EmailClient`** (and dependencies listed above).
4. Apply setup recipe if needed: `Smartent.Orchard.EmailClient.Samples/Recipes/Smartent.Orchard.EmailClient.Samples.recipe.json` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `Smartent.Orchard.EmailClient` | Smartent Orchard Email Client - Base | — |
| `Imap` | Smartent Orchard Email Client - IMAP | — |
| `EmailSync` | Smartent Orchard Email Client - Email Sync | — |

Enable in **Configuration → Features** (per tenant unless the module is host-only).

## Configuration

No dedicated `appsettings` section in this package; configuration is optional or via Orchard settings.

> Config sections use `Smartent_*` / `Smartent_Orchard_*` only (no legacy `Lombiq_*` in this demo repo).

## Usage (site owners & admins)

Configure account under module settings after enabling feature; use Samples for demo mailboxes.

## Usage (developers)

Extend via DI, handlers, shapes, and optional recipes in the Samples project.

### References

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.EmailClient" Version="1.0.0" />
```

## Samples & recipes

- `Smartent.Orchard.EmailClient.Samples/Recipes/Smartent.Orchard.EmailClient.Samples.recipe.json`

## Pitfalls & cautions

- Store credentials in secrets, not `appsettings` committed to git.
- Rate limits apply on public IMAP providers.

## Tests

```powershell
dotnet build src/Modules/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient.csproj
dotnet test src/Modules/Smartent.Orchard.EmailClient/*.Tests*.csproj
```

## Related projects in this folder

- `Smartent.Orchard.EmailClient` — main module
- `Smartent.Orchard.EmailClient.Samples` — samples & recipes
- `Smartent.Orchard.EmailClient.Tests.UI` — automated/UI tests

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.