<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.LoginAsAnybody

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.LoginAsAnybody` · **Path**: `src/Modules/Smartent.Orchard.LoginAsAnybody`

## Summary

An Orchard Core module that allows administrator users to log in as any user.

## When to use

Development/staging only: impersonate users for support or QA.

## Quick start

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.LoginAsAnybody/Smartent.Orchard.LoginAsAnybody/Smartent.Orchard.LoginAsAnybody.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.LoginAsAnybody/Smartent.Orchard.LoginAsAnybody/Smartent.Orchard.LoginAsAnybody.csproj`.
3. Run the site, open **Configuration → Features**, enable **`LoginAsAnybody`** (and dependencies listed above).
4. Apply setup recipe if needed: `see Samples folder` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `LoginAsAnybody` | Smartent Orchard Login as Anybody | OrchardCore.Users |

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
<ProjectReference Include="src/Modules/Smartent.Orchard.LoginAsAnybody/Smartent.Orchard.LoginAsAnybody/Smartent.Orchard.LoginAsAnybody.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.LoginAsAnybody" Version="1.0.0" />
```

## Samples & recipes

- Optional: enable `Smartent.Orchard.LoginAsAnybody.Samples` and import its recipes.

## Pitfalls & cautions

- **Never enable in production** without strict network and role controls.
- Audit all impersonation actions.

## Tests

```powershell
dotnet build src/Modules/Smartent.Orchard.LoginAsAnybody/Smartent.Orchard.LoginAsAnybody/Smartent.Orchard.LoginAsAnybody.csproj
dotnet test src/Modules/Smartent.Orchard.LoginAsAnybody/*.Tests*.csproj
```

## Related projects in this folder

- `Smartent.Orchard.LoginAsAnybody` — main module
- `Smartent.Orchard.LoginAsAnybody.Tests.UI` — automated/UI tests

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.