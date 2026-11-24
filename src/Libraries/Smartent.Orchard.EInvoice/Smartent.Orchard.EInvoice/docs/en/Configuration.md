# Configuration

> Index: [README.md](README.md) · Gateway: [../README.md](../README.md)

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
