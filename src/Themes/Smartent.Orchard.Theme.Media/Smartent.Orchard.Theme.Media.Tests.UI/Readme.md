# Smartent.Orchard.Theme.Media.Tests.UI

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Themes/Smartent.Orchard.Theme.Media/Smartent.Orchard.Theme.Media.Tests.UI`

## Summary

Extensions to aid in UI testing Smartent Orchard Hosting - Media Theme for Orchard Core.

## Features

**Implements**

- - Extensions to aid in UI testing Smartent Orchard Hosting - Media Theme for Orchard Core.

**Out of scope**

- - Not shipped as a runtime module.

## References

### Monorepo (development)

```xml
<ProjectReference Include="src/Themes/Smartent.Orchard.Theme.Media/Smartent.Orchard.Theme.Media.Tests.UI/Smartent.Orchard.Theme.Media.Tests.UI.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Orchard.Theme.Media.Tests.UI" Version="1.0.0" />
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
| `HtmlSanitizer` | Package | Version `9.2.1039` |

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
dotnet build "src/Themes/Smartent.Orchard.Theme.Media/Smartent.Orchard.Theme.Media.Tests.UI/Smartent.Orchard.Theme.Media.Tests.UI.csproj"
dotnet test "src/Themes/Smartent.Orchard.Theme.Media/Smartent.Orchard.Theme.Media.Tests.UI/Smartent.Orchard.Theme.Media.Tests.UI.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
