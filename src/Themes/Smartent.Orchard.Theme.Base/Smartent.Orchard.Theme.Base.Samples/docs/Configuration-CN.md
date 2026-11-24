# 配置

> 上级：[docs/Readme-CN.md](Readme-CN.md)

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| `OrchardCore.Admin` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Theme.Targets` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `Smartent.Build.NodeJs` | 包引用 | 版本 `3.0.0` |

### 前端（如适用）

规范：[frontend-dependencies](../../docs/standards/frontend-dependencies.md)。仅当本目录存在 `package.json` 时执行前端构建命令。

| npm 包 | 版本 | 用途 | 构建 |
|--------|------|------|------|
| | `bootstrap` | 5.3.9 | dependencies | see package.json scripts |
| `eslint` | 8.47.0 | devDependencies | see package.json scripts |
| `eslint-config-airbnb-base` | 15.0.0 | devDependencies | see package.json scripts |
| `eslint-plugin-import` | 2.28.1 | devDependencies | see package.json scripts |
| `eslint-plugin-node` | 11.1.0 | devDependencies | see package.json scripts |
| `eslint-plugin-only-warn` | 1.1.0 | devDependencies | see package.json scripts |
| `eslint-plugin-promise` | 6.1.1 | devDependencies | see package.json scripts | | | | |
