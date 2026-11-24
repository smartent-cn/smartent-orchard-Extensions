# Smartent.Orchard.EInvoice

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Libraries/Smartent.Orchard.EInvoice/Smartent.Orchard.EInvoice`

## Summary

EN 16931 电子发票校验（UBL/CII，含 Schematron）。

## Features

**Implements**

- - EN 16931 电子发票校验（UBL/CII，含 Schematron）。

**Out of scope**

- - Does not replace Orchard Core built-in features unless documented.

## References

### Monorepo (development)

```xml
<ProjectReference Include="../../../Platform/Orchard/Smartent.Orchard.Platform/Smartent.Orchard.Platform.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Orchard.EInvoice" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `Orchard Core module`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Add the module to the host (`Program` / `Startup`), enable features in Admin → Configuration → Features, and run Recipes if provided under `Recipes/`.

## Dependencies

### .NET / Orchard

| Dependency | Type | Purpose |
|------------|------|---------|
| `Jering.Javascript.NodeJS` | Package | Version `7.0.0` |
| `MySqlConnector` | Package | Version `2.6.2` |
| `HtmlSanitizer` | Package | Version `9.2.1039` |
| `Smartent.Orchard.Platform` | Package | Version `$(PackageVersionSmartentPlatform)` |

### Frontend (if applicable)

See [frontend-dependencies standard](../../docs/standards/frontend-dependencies.md). Run `pnpm`/`npm` scripts only when this folder has `package.json`.

| npm package | Version | Purpose | Build |
|-------------|---------|---------|-------|
| | `xslt3` | 2.7.0 | dependencies | see package.json scripts |
| `saxon-js` | 2.7.0 | dependencies | see package.json scripts | | | | |

## Upgrade & extension

- **Orchard**: Aligns with repository `OrchardCoreVersion` / central package management.
- **Extension points**: Drivers, handlers, shapes, and `IDataTableDataProvider`-style interfaces (see source).
- **Customization**: Prefer configuration keys under `Smartent_*` / `Smartent_Orchard_*`; this demo repo does not read legacy `Lombiq_*` sections.

## Tests

```powershell
dotnet build "src/Libraries/Smartent.Orchard.EInvoice/Smartent.Orchard.EInvoice/Smartent.Orchard.EInvoice.csproj"
dotnet test "src/Libraries/Smartent.Orchard.EInvoice/Smartent.Orchard.EInvoice/Smartent.Orchard.EInvoice.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
