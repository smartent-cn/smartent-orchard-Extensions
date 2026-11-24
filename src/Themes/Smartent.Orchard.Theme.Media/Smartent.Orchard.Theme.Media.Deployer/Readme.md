# Smartent.Orchard.Theme.Media.Deployer

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Themes/Smartent.Orchard.Theme.Media/Smartent.Orchard.Theme.Media.Deployer`

## Summary

A tool to easily export Media Themes. See the project website for detailed documentation.

## Features

**Implements**

- - A tool to easily export Media Themes. See the project website for detailed documentation.

**Out of scope**

- - Does not replace Orchard Core built-in features unless documented.

## References

### Monorepo (development)

```xml
<ProjectReference Include="src/Themes/Smartent.Orchard.Theme.Media/Smartent.Orchard.Theme.Media.Deployer/Smartent.Orchard.Theme.Media.Deployer.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Orchard.Theme.Media.Deployer" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `Orchard Core module`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Enable the theme feature and set it as the site or admin theme.

## Dependencies

### .NET / Orchard

| Dependency | Type | Purpose |
|------------|------|---------|
| `CommandLineParser` | Package | Version `2.9.1` |

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
dotnet build "src/Themes/Smartent.Orchard.Theme.Media/Smartent.Orchard.Theme.Media.Deployer/Smartent.Orchard.Theme.Media.Deployer.csproj"
dotnet test "src/Themes/Smartent.Orchard.Theme.Media/Smartent.Orchard.Theme.Media.Deployer/Smartent.Orchard.Theme.Media.Deployer.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
