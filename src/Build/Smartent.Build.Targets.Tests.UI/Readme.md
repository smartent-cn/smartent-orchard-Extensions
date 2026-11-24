# Smartent.Build.Targets.Tests.UI

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Build/Smartent.Build.Targets.Tests.UI`

## Summary

Smartent.Build.Targets.Tests.UI

## Features

**Implements**

- - Smartent.Build.Targets.Tests.UI

**Out of scope**

- - Not shipped as a runtime module.

## References

### Monorepo (development)

```xml
<ProjectReference Include="../Smartent.Build.Sdk.Samples/Smartent.Build.Sdk.Samples.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Build.Targets.Tests.UI" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `—`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Reference from a UI test project; run with `Smartent.Test.UI` and the main solution filter.

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
dotnet build "src/Build/Smartent.Build.Targets.Tests.UI/Smartent.Build.Targets.Tests.UI.csproj"
dotnet test "src/Build/Smartent.Build.Targets.Tests.UI/Smartent.Build.Targets.Tests.UI.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
