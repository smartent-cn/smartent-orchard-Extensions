# Smartent.Orchard.UIKit

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Modules/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit`

## Summary

This module contains reusable shapes like text editors, custom-style checkboxes, dropdown editors, and in the future potentially more complex editors.

## Features

**Implements**

- - This module contains reusable shapes like text editors, custom-style checkboxes, dropdown editors, and in the future potentially more complex editors.

**Out of scope**

- - Does not replace Orchard Core built-in features unless documented.

## References

### Monorepo (development)

```xml
<ProjectReference Include="../../../Test/Smartent.Test.UI/Smartent.Test.UI.AppExtensions/Smartent.Test.UI.AppExtensions.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Orchard.UIKit" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `（见 Manifest / Module.cs）`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Add the module to the host (`Program` / `Startup`), enable features in Admin → Configuration → Features, and run Recipes if provided under `Recipes/`.

## Dependencies

### .NET / Orchard

| Dependency | Type | Purpose |
|------------|------|---------|
| `Smartent.Test.UI.AppExtensions` | Package | Version `$(PackageVersionSmartentTestsUI) ` |
| `MySqlConnector` | Package | Version `2.6.2` |

### Frontend (if applicable)

See [frontend-dependencies standard](../../docs/standards/frontend-dependencies.md). Run `pnpm`/`npm` scripts only when this folder has `package.json`.

| npm package | Version | Purpose | Build |
|-------------|---------|---------|-------|
| | `slick-carousel` | github:kenwheeler/slick#0bce01e901628d038b3a5f6d0947e14fb0ae6016 | dependencies | see package.json scripts | | | | |

## Upgrade & extension

- **Orchard**: Aligns with repository `OrchardCoreVersion` / central package management.
- **Extension points**: Drivers, handlers, shapes, and `IDataTableDataProvider`-style interfaces (see source).
- **Customization**: Prefer configuration keys under `Smartent_*` / `Smartent_Orchard_*`; this demo repo does not read legacy `Lombiq_*` sections.

## Tests

```powershell
dotnet build "src/Modules/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit.csproj"
dotnet test "src/Modules/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
