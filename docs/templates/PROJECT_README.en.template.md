# {PackageId}

> **Status**: Training/demo monorepo · **中文说明**: [Readme-CN.md](Readme-CN.md)  
> **Path**: `{RepoRelativePath}`

## Summary

{SummaryEn}

## Features

**Implements**

- {FeaturesImplementEn}

**Out of scope**

- {FeaturesOutOfScopeEn}

## References

### Monorepo (development)

```xml
<ProjectReference Include="{ProjectReferenceExample}" />
```

### NuGet (when published; version is indicative)

```xml
<PackageReference Include="{PackageId}" Version="1.0.0" />
```

### Orchard features (if applicable)

- Enable in host: `{OrchardFeatures}`
- Related modules: see Dependencies

## Usage

1. Reference this project from your web app or module solution.
2. {UsageStepsEn}

## Dependencies

### .NET / Orchard

| Dependency | Type | Purpose |
|------------|------|---------|
{DependencyTableEn}

### Frontend (if applicable)

See [frontend-dependencies standard](../../docs/standards/frontend-dependencies.md). Run `pnpm`/`npm` scripts only when this folder has `package.json`.

| npm package | Version | Purpose | Build |
|-------------|---------|---------|-------|
| {NpmTableOrDash} | | | |

## Upgrade & extension

- **Orchard**: Aligns with repository `OrchardCoreVersion` / central package management.
- **Extension points**: {ExtensionPointsEn}
- **Customization**: Prefer configuration keys under `Smartent_*` / `Smartent_Orchard_*`; this demo repo does not read legacy `Lombiq_*` sections.

## Tests

```powershell
dotnet build "{CsprojRelativeFromRepoRoot}"
dotnet test "{TestCsprojOrSame}"
```

{AdditionalTestNotesEn}

## Provenance & license

- Migrated from Lombiq OSOCE lineage; Smartent package IDs and namespaces.
- License: MIT (see repository root `License.md`).