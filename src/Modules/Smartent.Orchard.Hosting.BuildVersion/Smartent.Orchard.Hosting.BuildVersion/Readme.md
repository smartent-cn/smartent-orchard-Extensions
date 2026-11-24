# Smartent.Orchard.Hosting.BuildVersion

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Modules/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion`

## Summary

Orchard Core module to display the build version (i.e. .NET assembly version or other) on the admin of the Default tenant.

## Features

**Implements**

- - Orchard Core module to display the build version (i.e. .NET assembly version or other) on the admin of the Default tenant.

**Out of scope**

- - Does not replace Orchard Core built-in features unless documented.

## References

### Monorepo (development)

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Orchard.Hosting.BuildVersion" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `（见 Manifest / Module.cs）`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Enable tenant/hosting features and set `OrchardCore:Smartent_Orchard_Hosting_*` sections in `appsettings.json`.

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
dotnet build "src/Modules/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion.csproj"
dotnet test "src/Modules/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
