# Smartent.Orchard.Hosting.ApplicationInsights

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Modules/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights`

## Summary

This Orchard Core module enables easy integration of Azure Application Insights telemetry into Orchard. Just install the module, configure the instrumentation key from a configuration source, and collected data will start appearing in the Azure Portal.

## Features

**Implements**

- - This Orchard Core module enables easy integration of Azure Application Insights telemetry into Orchard. Just install the module, configure the instrumentation key from a configuration source, and collected data will start appearing in the Azure Portal.

**Out of scope**

- - Does not replace Orchard Core built-in features unless documented.

## References

### Monorepo (development)

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Orchard.Hosting.ApplicationInsights" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `（见 Manifest / Module.cs）`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Enable tenant/hosting features and set `OrchardCore:Smartent_Orchard_Hosting_*` sections in `appsettings.json`.

## Dependencies

### .NET / Orchard

| Dependency | Type | Purpose |
|------------|------|---------|
| `Azure.Identity` | Package | Version `1.21.0` |
| `Microsoft.ApplicationInsights.AspNetCore` | Package | Version `2.23.0` |
| `Microsoft.ApplicationInsights.Profiler.AspNetCore` | Package | Version `3.0.2` |
| `Microsoft.AspNetCore.WebUtilities` | Package | Version `2.3.14` |
| `MySqlConnector` | Package | Version `2.6.2` |
| `OrchardCore.Media.Azure` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.ContentManagement` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.ContentTypes.Abstractions` | Package | Version `$(OrchardCoreVersion)` |

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
dotnet build "src/Modules/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights.csproj"
dotnet test "src/Modules/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
