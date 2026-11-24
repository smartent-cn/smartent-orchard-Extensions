# Smartent.Test.UI.TestingModule

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Test/Smartent.Test.UI/Smartent.Test.UI.TestingModule`

## Summary

Smartent.Test.UI.TestingModule

## Features

**Implements**

- - Smartent.Test.UI.TestingModule

**Out of scope**

- - Does not replace Orchard Core built-in features unless documented.

## References

### Monorepo (development)

```xml
<ProjectReference Include="src/Test/Smartent.Test.UI/Smartent.Test.UI.TestingModule/Smartent.Test.UI.TestingModule.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Test.UI.TestingModule" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `Smartent.Test.UI.TestingModule`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Reference from test projects; configure via `TestConfiguration.json` or `SMARTENT_UI_TESTING_TOOLBOX_SHARED_TEST_CONFIGURATION`.

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
- **Extension points**: UI test context extensions and recipes under `Smartent.Test.UI.*`.
- **Customization**: Prefer configuration keys under `Smartent_*` / `Smartent_Orchard_*`; this demo repo does not read legacy `Lombiq_*` sections.

## Tests

```powershell
dotnet build "src/Test/Smartent.Test.UI/Smartent.Test.UI.TestingModule/Smartent.Test.UI.TestingModule.csproj"
dotnet test "src/Test/Smartent.Test.UI/Smartent.Test.UI.TestingModule/Smartent.Test.UI.TestingModule.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
