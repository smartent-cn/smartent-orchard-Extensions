<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.Hosting.BuildVersion

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.Hosting.BuildVersion` · **Path**: `src/Modules/Smartent.Orchard.Hosting.BuildVersion`

## Summary

Orchard Core module to display the build version (i.e. .NET assembly version or other) on the admin of the Default tenant.

## When to use

Orchard Core extension module in the Smartent demo monorepo.

## Quick start

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Smartent.Orchard.Hosting.BuildVersion`** (and dependencies listed above).
4. Apply setup recipe if needed: `see Samples folder` from **Tools → Recipes**.
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

Extend via DI, handlers, shapes, and optional recipes in the Samples project.

### References

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.Hosting.BuildVersion" Version="1.0.0" />
```

## Samples & recipes

- Optional: enable `Smartent.Orchard.Hosting.BuildVersion.Samples` and import its recipes.

## Pitfalls & cautions

- Enable only required features per tenant.
- Test with `*.Tests` / `*.Tests.UI` before upgrading Orchard Core.

## Tests

```powershell
dotnet build src/Modules/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion.csproj
dotnet test src/Modules/Smartent.Orchard.Hosting.BuildVersion/*.Tests*.csproj
```

## Related projects in this folder

- `Smartent.Orchard.Hosting.BuildVersion` — main module
- `Smartent.Orchard.Hosting.BuildVersion.Tests.UI` — automated/UI tests

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.