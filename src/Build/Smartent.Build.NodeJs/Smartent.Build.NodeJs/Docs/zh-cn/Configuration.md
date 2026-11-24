# 配置

> 索引：[README.md](README.md) · 入口：[../Readme-CN.md](../Readme-CN.md)

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| `Smartent.Build.Npm.Targets` | 包引用 | 版本 `1.5.0` |
| `Microsoft.Build.Framework` | 包引用 | 版本 `18.11.0` |
| `Microsoft.Build.Tasks.Core` | 包引用 | 版本 `18.11.0` |
| `Microsoft.Build.Utilities.Core` | 包引用 | 版本 `18.11.0` |

### 前端（如适用）

规范：[frontend-dependencies](../../docs/standards/frontend-dependencies.md)。仅当本目录存在 `package.json` 时执行前端构建命令。

| npm 包 | 版本 | 用途 | 构建 |
|--------|------|------|------|
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
