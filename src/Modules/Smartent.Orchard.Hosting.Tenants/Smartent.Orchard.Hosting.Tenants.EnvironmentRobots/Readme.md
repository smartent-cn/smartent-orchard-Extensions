# Smartent.Orchard.Hosting.Tenants.EnvironmentRobots

> **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **PackageId**: `Smartent.Orchard.Hosting.Tenants.EnvironmentRobots` · **Path**: `src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.EnvironmentRobots`

## Summary

This module contains the EnvironmentRobots feature, which prevents search bots from indexing non-production environments by adding a meta tag and a response header with noindex, nofollow values.

## When to use

Tenant/hosting automation package; enable only on environments that need this capability.

## Quick start

Enable feature `FeatureNames.EnvironmentRobots` on the host tenant; configure keys under `OrchardCore`.

## Orchard features

| Feature Id | Name | Depends on |
|------------|------|------------|
| `FeatureNames.EnvironmentRobots` | Smartent Orchard Hosting - Tenants Environment Robots | — |

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
<ProjectReference Include="src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.EnvironmentRobots/Smartent.Orchard.Hosting.Tenants.EnvironmentRobots.csproj" />
```

### NuGet (when published)

```xml
<PackageReference Include="Smartent.Orchard.Hosting.Tenants.EnvironmentRobots" Version="1.0.0" />
```

## Samples & recipes

- See `Smartent.Orchard.Hosting.Tenants` solution Readme.

## Pitfalls & cautions

- Misconfiguration can lock tenants or block admin login; test in staging.
- Secrets (storage, AI keys) belong in user secrets or Key Vault, not git.

## Tests

`dotnet test src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.EnvironmentRobots/*.Tests*.csproj`

## Related projects in this folder

- Parent: `src/Modules/Smartent.Orchard.Hosting.Tenants/Readme.md`

## Provenance

Smartent Orchard Extensions training/demo monorepo; migrated from Lombiq OSOCE lineage. MIT license at repository root.