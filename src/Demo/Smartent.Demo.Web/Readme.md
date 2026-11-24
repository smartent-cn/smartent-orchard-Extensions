# Smartent.Demo.Web

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Demo/Smartent.Demo.Web`

## Summary

Smartent.Demo.Web

## Features

**Implements**

- - Smartent.Demo.Web

**Out of scope**

- - Local training host only.

## References

### Monorepo (development)

```xml
<ProjectReference Include="../../Test/Smartent.Test.UI/Smartent.Test.UI.AdminTheme/Smartent.Test.UI.AdminTheme.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Demo.Web" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `—`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Run as the startup project: `dotnet run --project Smartent.Demo.Web.csproj`.

## Dependencies

### .NET / Orchard

| Dependency | Type | Purpose |
|------------|------|---------|
| `OrchardCore.Application.Cms.Targets` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Logging.NLog` | Package | Version `$(OrchardCoreVersion)` |
| `Microsoft.AspNetCore.WebUtilities` | Package | Version `2.3.14` |

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
dotnet build "src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj"
dotnet test "src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
