# Smartent.Build.NodeJs

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `src/Build/Smartent.Build.NodeJs/Smartent.Build.NodeJs`

## Summary

Smartent Node.js MSBuild Extensions

## Features

**Implements**

- - Smartent Node.js MSBuild Extensions

**Out of scope**

- - Does not replace Orchard Core built-in features unless documented.

## References

### Monorepo (development)

```xml
<ProjectReference Include="../../Smartent.Build.Npm.Targets/Smartent.Build.Npm.Targets.csproj" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="Smartent.Build.NodeJs" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `—`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. Import the Sdk or targets from your `.csproj` / `Directory.Build.props` per `src/Build/Docs/UsingMSBuildSdks.md`.

## Dependencies

### .NET / Orchard

| Dependency | Type | Purpose |
|------------|------|---------|
| `Smartent.Build.Npm.Targets` | Package | Version `1.5.0` |
| `Microsoft.Build.Framework` | Package | Version `18.11.0` |
| `Microsoft.Build.Tasks.Core` | Package | Version `18.11.0` |
| `Microsoft.Build.Utilities.Core` | Package | Version `18.11.0` |

### Frontend (if applicable)

See [frontend-dependencies standard](../../docs/standards/frontend-dependencies.md). Run `pnpm`/`npm` scripts only when this folder has `package.json`.

| npm package | Version | Purpose | Build |
|-------------|---------|---------|-------|
| | `@babel/cli` | 7.22.10 | dependencies | see package.json scripts |
| `@babel/core` | 7.22.11 | dependencies | see package.json scripts |
| `@babel/preset-env` | 7.22.10 | dependencies | see package.json scripts |
| `@textlint-rule/textlint-rule-no-invalid-control-character` | 2.0.0 | dependencies | see package.json scripts |
| `autoprefixer` | 10.4.15 | dependencies | see package.json scripts |
| `chalk` | 4.1.2 | dependencies | see package.json scripts |
| `clean-css-cli` | 5.6.2 | dependencies | see package.json scripts |
| `copyfiles` | 2.4.1 | dependencies | see package.json scripts |
| `eslint` | 8.47.0 | dependencies | see package.json scripts |
| `glob` | 10.3.10 | dependencies | see package.json scripts |
| `if-env` | 1.0.4 | dependencies | see package.json scripts |
| `markdownlint` | 0.34.0 | dependencies | see package.json scripts |
| `eslint` | 8.47.0 | devDependencies | see package.json scripts |
| `eslint-config-airbnb-base` | 15.0.0 | devDependencies | see package.json scripts |
| `eslint-plugin-import` | 2.28.1 | devDependencies | see package.json scripts |
| `eslint-plugin-node` | 11.1.0 | devDependencies | see package.json scripts |
| `eslint-plugin-only-warn` | 1.1.0 | devDependencies | see package.json scripts |
| `eslint-plugin-promise` | 6.1.1 | devDependencies | see package.json scripts |
| `jest` | 29.6.4 | devDependencies | see package.json scripts | | | | |

## Upgrade & extension

- **Orchard**: Aligns with repository `OrchardCoreVersion` / central package management.
- **Extension points**: MSBuild targets and Sdk hooks in `build/*.targets`.
- **Customization**: Prefer configuration keys under `Smartent_*` / `Smartent_Orchard_*`; this demo repo does not read legacy `Lombiq_*` sections.

## Tests

```powershell
dotnet build "src/Build/Smartent.Build.NodeJs/Smartent.Build.NodeJs/Smartent.Build.NodeJs.csproj"
dotnet test "src/Build/Smartent.Build.NodeJs/Smartent.Build.NodeJs/Smartent.Build.NodeJs.csproj"
```

UI tests: filter `*.Tests.UI.csproj` in the solution.

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).
