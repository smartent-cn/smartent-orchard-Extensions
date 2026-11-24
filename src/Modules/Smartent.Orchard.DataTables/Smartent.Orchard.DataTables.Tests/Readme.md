# Smartent.Orchard.DataTables.Tests

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.Tests`

## Summary

Smartent.Orchard.DataTables.Tests

## Features

**Implements**

- - Smartent.Orchard.DataTables.Tests

**Out of scope**

- - Not shipped to production.

## References

### Monorepo (development)

```xml
<ProjectReference Include="../Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Orchard.DataTables.Tests" Version="1.0.0" />
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
| `OrchardCore.Liquid` | Package | Version `$(OrchardCoreVersion)` |

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
dotnet build "src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.Tests/Smartent.Orchard.DataTables.Tests.csproj"
dotnet test "src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.Tests/Smartent.Orchard.DataTables.Tests.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
