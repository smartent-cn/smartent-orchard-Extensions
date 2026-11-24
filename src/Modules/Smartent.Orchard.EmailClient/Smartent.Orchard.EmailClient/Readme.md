# Smartent.Orchard.EmailClient

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Modules/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient`

## Summary

With the help of this module, you can do advanced email operations such as downloading them using IMAP.

## Features

**Implements**

- - With the help of this module, you can do advanced email operations such as downloading them using IMAP.

**Out of scope**

- - Does not replace Orchard Core built-in features unless documented.

## References

### Monorepo (development)

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Orchard.EmailClient" Version="1.0.0" />
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
| `MailKit` | Package | Version `4.18.2` |

### Frontend (if applicable)

See [frontend-dependencies standard](../../docs/standards/frontend-dependencies.md). Run `pnpm`/`npm` scripts only when this folder has `package.json`.

| npm package | Version | Purpose | Build |
|-------------|---------|---------|-------|
| | — | — | — | — | | | | |

## Upgrade & extension

- **Orchard**: Aligns with repository `OrchardCoreVersion` / central package management.
- **Extension points**: Drivers, handlers, shapes, and `IDataTableDataProvider`-style interfaces (see source).
- **Customization**: Prefer configuration keys under `Smartent_*` / `Smartent_Orchard_*`; this demo repo does not read legacy `Lombiq_*` sections.

## Tests

```powershell
dotnet build "src/Modules/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient.csproj"
dotnet test "src/Modules/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
