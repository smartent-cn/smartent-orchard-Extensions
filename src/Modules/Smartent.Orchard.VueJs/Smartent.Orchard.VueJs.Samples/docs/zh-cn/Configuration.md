# 配置

> 索引：[README.md](README.md) · 入口：[../Readme-CN.md](../Readme-CN.md)

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| `OrchardCore.ContentFields` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Module.Targets` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.DisplayManagement` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.ResourceManagement` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `SixLabors.ImageSharp` | 包引用 | 版本 `3.1.12` |
| `ZXing.Net.Bindings.ImageSharp.V3` | 包引用 | 版本 `0.16.20` |
| `Smartent.Build.NodeJs` | 包引用 | 版本 `3.0.0` |
| `Smartent.Core.Primitives` | 包引用 | 版本 `12.6.1-alpha.7.osoe-925` |

### 前端（如适用）

规范：[frontend-dependencies](../../docs/standards/frontend-dependencies.md)。仅当本目录存在 `package.json` 时执行前端构建命令。

| npm 包 | 版本 | 用途 | 构建 |
|--------|------|------|------|
| | `eslint` | 8.47.0 | devDependencies | see package.json scripts |
| `eslint-config-airbnb-base` | 15.0.0 | devDependencies | see package.json scripts |
| `eslint-plugin-import` | 2.28.1 | devDependencies | see package.json scripts |
| `eslint-plugin-node` | 11.1.0 | devDependencies | see package.json scripts |
| `eslint-plugin-only-warn` | 1.1.0 | devDependencies | see package.json scripts |
| `eslint-plugin-promise` | 7.2.1 | devDependencies | see package.json scripts |
| `vue-qrcode-reader` | 5.7.3 | devDependencies | see package.json scripts | | | | |
