# Smartent.Orchard.Theme.Media

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Themes/Smartent.Orchard.Theme.Media/Smartent.Orchard.Theme.Media`

## Summary

With the help of this theme, you'll be able to host your theme templates and assets located in your Orchard Core Media Library.

## Features

**Implements**

- - With the help of this theme, you'll be able to host your theme templates and assets located in your Orchard Core Media Library.

**Out of scope**

- - Does not replace Orchard Core built-in features unless documented.

## References

### Monorepo (development)

```xml
<ProjectReference Include="../Smartent.Orchard.Theme.Media.Bridge/Smartent.Orchard.Theme.Media.Bridge.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Orchard.Theme.Media" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `（见 Manifest / Module.cs）`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Enable the theme feature and set it as the site or admin theme.

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
dotnet build "src/Themes/Smartent.Orchard.Theme.Media/Smartent.Orchard.Theme.Media/Smartent.Orchard.Theme.Media.csproj"
dotnet test "src/Themes/Smartent.Orchard.Theme.Media/Smartent.Orchard.Theme.Media/Smartent.Orchard.Theme.Media.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
