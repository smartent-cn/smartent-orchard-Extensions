# Smartent.Orchard.Hosting.Tenants.Maintenance

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.Hosting.Tenants.Maintenance` · **Path**: `src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Maintenance`

## Summary

With the help of this module you can execute maintenance tasks on tenants.

## When to use

Tenant/hosting automation package; enable only on environments that need this capability.

## Quick start

Enable feature `Maintenance` on the host tenant; configure keys under `OrchardCore`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `Maintenance` | Smartent Orchard Hosting - Tenants Maintenance | — |
| `UpdateSiteUrl` | Smartent Orchard Hosting - Tenants Maintenance Update Site URL | — |
| `UpdateShellRequestUrls` | Smartent Orchard Hosting - Tenants Maintenance Update Shell Request URLs | — |
| `AddAdministratorRoleToUsersWithRole` | Smartent Orchard Hosting - Tenants Maintenance Add Administrator Role to Users With Role | — |
| `RemoveUsers` | Smartent Orchard Hosting - Tenants Maintenance Remove Users | — |
| `ChangeUserSensitiveContent` | Smartent Orchard Hosting - Tenants Maintenance Change User Sensitive Content | — |
| `DeleteOrRebuildElasticsearchIndices` | Smartent Orchard Hosting - Tenants Maintenance Delete or Rebuild Elasticsearch Indexes | OrchardCore.Elasticsearch |
| `DeleteElasticsearchIndicesBeforeSetup` | Smartent Orchard Hosting - Tenants Maintenance Delete Elasticsearch Indexes Before Setup | — |
| `PurgeMediaCache` | Smartent Orchard Hosting - Tenants Maintenance Purge Media Cache | OrchardCore.Media |
| `UpdateEnabledFeatures` | Smartent Orchard Hosting - Tenants Maintenance Update Enabled Features | — |
| `StaggeredTenantWakeUp` | Smartent Orchard Hosting - Tenants Maintenance Staggered Tenant Wake-up | OrchardCore.Tenants, OrchardCore.ContentFields, OrchardCore.Contents |

Enable in **Configuration → Features** (per tenant unless the module is host-only).

## Configuration

No dedicated `appsettings` section in this package; configuration is optional or via Orchard settings.

> Config sections use `Smartent_*` / `Smartent_Orchard_*` only (no legacy `Lombiq_*` in this demo repo).

## Usage (site owners & admins)

Hosting/tenant admin UI varies per package (see source `Startup.cs` and README in solution root).

## Usage (developers)

Reference this csproj from the SaaS/host web app; most packages register tenant management or health endpoints.

### References

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Maintenance/Smartent.Orchard.Hosting.Tenants.Maintenance.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.Hosting.Tenants.Maintenance" Version="1.0.0" />
```

## Samples & recipes

- See `Smartent.Orchard.Hosting.Tenants` solution Readme.

## Pitfalls & cautions

- Misconfiguration can lock tenants or block admin login; test in staging.
- Secrets (storage, AI keys) belong in user secrets or Key Vault, not git.

## Tests

`dotnet test src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Maintenance/*.Tests*.csproj`

## Related projects in this folder

- Parent: `src/Modules/Smartent.Orchard.Hosting.Tenants/Readme.md`

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.