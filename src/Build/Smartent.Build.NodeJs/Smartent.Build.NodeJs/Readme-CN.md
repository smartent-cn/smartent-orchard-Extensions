# Smartent.Build.NodeJs

> **状态**：培训/demo 单体仓库 · **English**: [Readme.md](Readme.md)  
> **路径**：`src/Build/Smartent.Build.NodeJs/Smartent.Build.NodeJs`

## 摘要

Smartent.Build.NodeJs：Smartent Orchard Extensions 组件。Smartent Node.js MSBuild Extensions

## 功能说明

**实现**

- - Smartent Node.js MSBuild Extensions：Smartent Node.js MSBuild Extensions

**不实现（边界）**

- - 除非文档说明，不替代 Orchard Core 内置能力。

## 引用方式

### Monorepo（开发）

```xml
<ProjectReference Include="../../Smartent.Build.Npm.Targets/Smartent.Build.Npm.Targets.csproj" />
```

### NuGet（发布后，版本号以实际发布为准）

```xml
<PackageReference Include="Smartent.Build.NodeJs" Version="1.0.0" />
```

### Orchard 功能（如适用）

- 宿主中启用：`—`
- 相关模块：见「依赖说明」

## 使用方式

1. 在 Web 应用或模块解决方案中引用本项目。
2. 在 `.csproj` 或 `Directory.Build.props` 中按 `src/Build/Docs/UsingMSBuildSdks.md` 引用 Sdk/targets。

## 依赖说明

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

## 升级与扩展

- **Orchard**：与仓库 `OrchardCoreVersion` / 中央包管理对齐。
- **扩展点**：Sdk 与 `build/*.targets` 中的 MSBuild 扩展点。
- **定制**：配置节使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 测试

```powershell
dotnet build "src/Build/Smartent.Build.NodeJs/Smartent.Build.NodeJs/Smartent.Build.NodeJs.csproj"
dotnet test "src/Build/Smartent.Build.NodeJs/Smartent.Build.NodeJs/Smartent.Build.NodeJs.csproj"
```

UI 测试：在解决方案中筛选 `*.Tests.UI.csproj` 运行。

## 来源与许可

- 自 Lombiq OSOCE 谱系迁入；已 Smartent 化包 ID 与命名空间。
- 许可：MIT（见仓库根 `License.md`）。
