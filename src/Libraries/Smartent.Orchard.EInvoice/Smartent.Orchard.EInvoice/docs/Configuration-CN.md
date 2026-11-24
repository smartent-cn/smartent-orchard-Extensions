# 配置

> 上级：[docs/Readme-CN.md](Readme-CN.md)

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| `Jering.Javascript.NodeJS` | 包引用 | 版本 `7.0.0` |
| `MySqlConnector` | 包引用 | 版本 `2.6.2` |
| `HtmlSanitizer` | 包引用 | 版本 `9.2.1039` |
| `Smartent.Orchard.Platform` | 包引用 | 版本 `$(PackageVersionSmartentPlatform)` |

### 前端（如适用）

规范：[frontend-dependencies](../../docs/standards/frontend-dependencies.md)。仅当本目录存在 `package.json` 时执行前端构建命令。

| npm 包 | 版本 | 用途 | 构建 |
|--------|------|------|------|
| | `xslt3` | 2.7.0 | dependencies | see package.json scripts |
| `saxon-js` | 2.7.0 | dependencies | see package.json scripts | | | | |
