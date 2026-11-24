# Smartent.Build.Base.Sdk

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Build/Smartent.Build.Base.Sdk`

## Summary

Smartent MSBuild SDK - Base

## Features

**Implements**

- - Smartent MSBuild SDK - Base

**Out of scope**

- - Does not replace Orchard Core built-in features unless documented.

## References

### Monorepo (development)

```xml
<ProjectReference Include="src/Build/Smartent.Build.Base.Sdk/Smartent.Build.Base.Sdk.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Build.Base.Sdk" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `—`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Import the Sdk or targets from your `.csproj` / `Directory.Build.props` per `src/Build/docs/UsingMSBuildSdks.md`.

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
- **Extension points**: MSBuild targets and Sdk hooks in `build/*.targets`.
- **Customization**: Prefer configuration keys under `Smartent_*` / `Smartent_Orchard_*`; this demo repo does not read legacy `Lombiq_*` sections.

## Tests

```powershell
dotnet build "src/Build/Smartent.Build.Base.Sdk/Smartent.Build.Base.Sdk.csproj"
dotnet test "src/Build/Smartent.Build.Base.Sdk/Smartent.Build.Base.Sdk.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
