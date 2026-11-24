# Smartent.Orchard.Hosting.Tenants.Maintenance.Tests

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Maintenance.Tests`

## Summary

Smartent.Orchard.Hosting.Tenants.Maintenance.Tests

## Features

**Implements**

- - Smartent.Orchard.Hosting.Tenants.Maintenance.Tests

**Out of scope**

- - Not shipped to production.

## References

### Monorepo (development)

```xml
<ProjectReference Include="../Smartent.Orchard.Hosting.Tenants.Maintenance/Smartent.Orchard.Hosting.Tenants.Maintenance.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Orchard.Hosting.Tenants.Maintenance.Tests" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `—`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Run unit tests with `dotnet test` on this project.

## Dependencies

### .NET / Orchard

| Dependency | Type | Purpose |
|------------|------|---------|
| — | — | No direct PackageReference (may use central props) |

### Frontend (if applicable)

See [frontend-dependencies standard](../../docs/standards/frontend-dependencies.md). Run `pnpm`/`npm` scripts only when this folder has `package.json`.

| npm package | Version | Purpose | Build |
|-------------|---------|---------|-------|
| | — | — | — | — | | | | |

## Upgrade & extension

- **Orchard**: Aligns with repository `OrchardCoreVersion` / central package management.
- **Extension points**: Public APIs documented with Chinese XML comments in source.
- **Customization**: Prefer configuration keys under `Smartent_*` / `Smartent_Orchard_*`; this demo repo does not read legacy `Lombiq_*` sections.

## Tests

```powershell
dotnet build "src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Maintenance.Tests/Smartent.Orchard.Hosting.Tenants.Maintenance.Tests.csproj"
dotnet test "src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Maintenance.Tests/Smartent.Orchard.Hosting.Tenants.Maintenance.Tests.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
