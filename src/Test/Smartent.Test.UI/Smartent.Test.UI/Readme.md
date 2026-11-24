# Smartent.Test.UI

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Test/Smartent.Test.UI/Smartent.Test.UI`

## Summary

Web UI testing toolbox mostly for Orchard Core applications. Everything you need to do UI testing with Selenium for an Orchard app is here.

## Features

**Implements**

- - Web UI testing toolbox mostly for Orchard Core applications. Everything you need to do UI testing with Selenium for an Orchard app is here.

**Out of scope**

- - Does not replace Orchard Core built-in features unless documented.

## References

### Monorepo (development)

```xml
<ProjectReference Include="../Smartent.Test.UI.AppExtensions/Smartent.Test.UI.AppExtensions.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Test.UI" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `—`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Reference from test projects; configure via `TestConfiguration.json` or `SMARTENT_UI_TESTING_TOOLBOX_SHARED_TEST_CONFIGURATION`.

## Dependencies

### .NET / Orchard

| Dependency | Type | Purpose |
|------------|------|---------|
| `AngleSharp.XPath` | Package | Version `2.0.10` |
| `Atata` | Package | Version `4.0.1` |
| `Atata.Bootstrap` | Package | Version `4.0.0` |
| `Atata.HtmlValidation` | Package | Version `4.0.0` |
| `Atata.WebDriverExtras` | Package | Version `4.0.0` |
| `Atata.Xunit.v3` | Package | Version `4.0.0` |
| `Azure.Storage.Blobs` | Package | Version `12.30.1` |
| `Ben.Demystifier` | Package | Version `0.4.1` |
| `Codeuctivity.ImageSharpCompare` | Package | Version `4.1.390` |
| `Deque.AxeCore.Selenium` | Package | Version `4.14.0` |
| `MailKit` | Package | Version `4.18.2` |
| `Microsoft.Extensions.Diagnostics.Testing` | Package | Version `10.11.0` |
| `Microsoft.SqlServer.DACFx` | Package | Version `170.5.96` |
| `Microsoft.SqlServer.SqlManagementObjects` | Package | Version `181.37.1` |
| `Mono.Posix.NETStandard` | Package | Version `1.0.0` |
| `OrchardCore.Logging.NLog` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Recipes.Core` | Package | Version `$(OrchardCoreVersion)` |
| `OrchardCore.Workflows` | Package | Version `$(OrchardCoreVersion)` |
| `Sarif.Sdk` | Package | Version `5.8.0` |
| `YamlDotNet` | Package | Version `18.1.0` |
| `Smartent.Test.Unit` | Package | Version `$(PackageVersionSmartentTests)` |
| `Smartent.Core.Cli` | Package | Version `$(PackageVersionSmartentPlatform)` |
| `Smartent.Orchard.Platform` | Package | Version `$(PackageVersionSmartentPlatform)` |
| `Smartent.Orchard.Http.Refit` | Package | Version `$(PackageVersionSmartentPlatform)` |
| `HtmlSanitizer` | Package | Version `9.2.1039` |

### Frontend (if applicable)

See [frontend-dependencies standard](../../docs/standards/frontend-dependencies.md). Run `pnpm`/`npm` scripts only when this folder has `package.json`.

| npm package | Version | Purpose | Build |
|-------------|---------|---------|-------|
| | `gremlins.js` | 2.2.0 | dependencies | see package.json scripts | | | | |

## Upgrade & extension

- **Orchard**: Aligns with repository `OrchardCoreVersion` / central package management.
- **Extension points**: UI test context extensions and recipes under `Smartent.Test.UI.*`.
- **Customization**: Prefer configuration keys under `Smartent_*` / `Smartent_Orchard_*`; this demo repo does not read legacy `Lombiq_*` sections.

## Tests

```powershell
dotnet build "src/Test/Smartent.Test.UI/Smartent.Test.UI/Smartent.Test.UI.csproj"
dotnet test "src/Test/Smartent.Test.UI/Smartent.Test.UI/Smartent.Test.UI.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
