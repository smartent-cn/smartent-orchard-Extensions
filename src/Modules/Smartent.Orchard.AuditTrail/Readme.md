<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.AuditTrail

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.AuditTrail` · **Path**: `src/Modules/Smartent.Orchard.AuditTrail`

## Summary

A module with additional features for the Audit Trail module in Orchard Core.

## When to use

Use when you need version-style access to content history via Audit Trail events beyond stock OrchardCore.AuditTrail.

## Quick start

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.AuditTrail/Smartent.Orchard.AuditTrail.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.AuditTrail/Smartent.Orchard.AuditTrail.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Smartent.Orchard.AuditTrail`** (and dependencies listed above).
4. Apply setup recipe if needed: `see Samples folder` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `Smartent.Orchard.AuditTrail` | Smartent Orchard Audit Trail Extensions | OrchardCore.Contents, OrchardCore.AuditTrail |

Enable in **Configuration → Features** (per tenant unless the module is host-only).

## Configuration

No dedicated `appsettings` section in this package; configuration is optional or via Orchard settings.

> Config sections use `Smartent_*` / `Smartent_Orchard_*` only (no legacy `Lombiq_*` in this demo repo).

## Usage (site owners & admins)

No dedicated admin menu; features register services used from code and other modules.

## Usage (developers)

Inject `IAuditTrailContentVersionNumberService` in handlers or services. Requires **OrchardCore.AuditTrail** enabled.

### References

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.AuditTrail/Smartent.Orchard.AuditTrail.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.AuditTrail" Version="1.0.0" />
```

## Samples & recipes

- Optional: enable `Smartent.Orchard.AuditTrail.Samples` and import its recipes.

## Pitfalls & cautions

- Depends on Audit Trail event retention; purging audit logs affects history.
- Not a replacement for **Versionable** content definitions unless you design for it.

## Tests

```powershell
dotnet build src/Modules/Smartent.Orchard.AuditTrail/Smartent.Orchard.AuditTrail.csproj
dotnet test src/Modules/Smartent.Orchard.AuditTrail/*.Tests*.csproj
```

## Related projects in this folder

- `.` — `Smartent.Orchard.AuditTrail`

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.