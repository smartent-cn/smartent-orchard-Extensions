# Smartent.Test.UI.AdminTheme

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Test/Smartent.Test.UI/Smartent.Test.UI.AdminTheme`

## Summary

Adjustments for the stock Orchard Core admin theme to make it more automation-friendly.

## Features

**Implements**

- - Adjustments for the stock Orchard Core admin theme to make it more automation-friendly.

**Out of scope**

- - Does not replace Orchard Core built-in features unless documented.

## References

### Monorepo (development)

```xml
<ProjectReference Include="src/Test/Smartent.Test.UI/Smartent.Test.UI.AdminTheme/Smartent.Test.UI.AdminTheme.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Test.UI.AdminTheme" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `（见 Manifest / Module.cs）`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Reference from test projects; configure via `TestConfiguration.json` or `SMARTENT_UI_TESTING_TOOLBOX_SHARED_TEST_CONFIGURATION`.

## Dependencies

### .NET / Orchard

| Dependency | Type | Purpose |
|------------|------|---------|
| `MySqlConnector` | Package | Version `2.6.2` |
| `HtmlSanitizer` | Package | Version `9.2.1039` |

### Frontend (if applicable)

See [frontend-dependencies standard](../../docs/standards/frontend-dependencies.md). Run `pnpm`/`npm` scripts only when this folder has `package.json`.

| npm package | Version | Purpose | Build |
|-------------|---------|---------|-------|
| | — | — | — | — | | | | |

## Upgrade & extension

- **Orchard**: Aligns with repository `OrchardCoreVersion` / central package management.
- **Extension points**: UI test context extensions and recipes under `Smartent.Test.UI.*`.
- **Customization**: Prefer configuration keys under `Smartent_*` / `Smartent_Orchard_*`; this demo repo does not read legacy `Lombiq_*` sections.

## Tests

```powershell
dotnet build "src/Test/Smartent.Test.UI/Smartent.Test.UI.AdminTheme/Smartent.Test.UI.AdminTheme.csproj"
dotnet test "src/Test/Smartent.Test.UI/Smartent.Test.UI.AdminTheme/Smartent.Test.UI.AdminTheme.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
