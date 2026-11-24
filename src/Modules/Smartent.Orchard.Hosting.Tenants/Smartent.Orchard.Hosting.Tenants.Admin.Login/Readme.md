# Smartent.Orchard.Hosting.Tenants.Admin.Login

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.Hosting.Tenants.Admin.Login` · **Path**: `src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Admin.Login`

## Summary

With the help of this module, you can log in from the Default tenant's admin dashboard to any other tenants as an administrator user. This is useful if you manage a lot of customer tenants and don't want to create individual logins of yours for each of them.

## When to use

Tenant/hosting automation package; enable only on environments that need this capability.

## Quick start

Enable feature `Module` on the host tenant; configure keys under `OrchardCore`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `Module` | Smartent Orchard Hosting - Tenants Admin Login | OrchardCore.Tenants |
| `SubTenant` | Smartent Orchard Hosting - Tenants Admin Login Sub-tenant | — |

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
<ProjectReference Include="src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Admin.Login/Smartent.Orchard.Hosting.Tenants.Admin.Login.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.Hosting.Tenants.Admin.Login" Version="1.0.0" />
```

## Samples & recipes

- See `Smartent.Orchard.Hosting.Tenants` solution Readme.

## Pitfalls & cautions

- Misconfiguration can lock tenants or block admin login; test in staging.
- Secrets (storage, AI keys) belong in user secrets or Key Vault, not git.

## Tests

`dotnet test src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Admin.Login/*.Tests*.csproj`

## Related projects in this folder

- Parent: `src/Modules/Smartent.Orchard.Hosting.Tenants/Readme.md`

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.