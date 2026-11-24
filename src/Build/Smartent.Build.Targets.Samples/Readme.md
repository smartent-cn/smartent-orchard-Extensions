# Smartent.Build.Targets.Samples

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Build/Smartent.Build.Targets.Samples`

## Summary

Smartent.Build.Targets.Samples

## Features

**Implements**

- - Smartent.Build.Targets.Samples

**Out of scope**

- - Demonstration content only; not for production sites.

## References

### Monorepo (development)

```xml
<ProjectReference Include="src/Build/Smartent.Build.Targets.Samples/Smartent.Build.Targets.Samples.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Build.Targets.Samples" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `—`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Enable together with the parent module in `Smartent.Demo.Web` or your sample host.

## Dependencies

### .NET / Orchard

| Dependency | Type | Purpose |
|------------|------|---------|
| `Microsoft.Web.LibraryManager.Build` | Package | Version `3.0.114` |
| `Smartent.Build.LibMan.Targets` | Package | Version `2.1.1` |
| `Smartent.Core.CodeGen.Attributes` | Package | Version `13.0.0` |
| `Smartent.Core.CodeGen.SourceGenerators` | Package | Version `13.0.0` |

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
dotnet build "src/Build/Smartent.Build.Targets.Samples/Smartent.Build.Targets.Samples.csproj"
dotnet test "src/Build/Smartent.Build.Targets.Samples/Smartent.Build.Targets.Samples.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
