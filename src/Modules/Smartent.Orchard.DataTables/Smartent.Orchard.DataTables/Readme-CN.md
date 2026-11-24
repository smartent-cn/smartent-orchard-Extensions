# Smartent.Orchard.DataTables

> **状态**：培训/demo 单体仓库 · **English**: [Readme.md](Readme.md)  
> **路径**：`src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables`

## 摘要

Smartent.Orchard.DataTables：Smartent Orchard Extensions 组件。An Orchard Core wrapper around the DataTables (https://datatables.net/) library for displaying tabular data from custom data sources. It lets you replace HTML tables with a tag helper or create asynchronous, sortable, searchable server-side generated tables. It also includes a pure Vue.js module tha

## 功能说明

**实现**

- - Smartent Orchard Data Tables for Orchard Core：An Orchard Core wrapper around the DataTables (https://datatables.net/) library for displaying tabular data from custom data sources. It lets you replace HTML tables with a tag helper or create asynchronous, sortable, searchable server-side generated tables. It also includes a pure Vue.js module that works similarly to DataTables.

**不实现（边界）**

- - 除非文档说明，不替代 Orchard Core 内置能力。

## 引用方式

### Monorepo（开发）

```xml
<ProjectReference Include="../../../Platform/Orchard/Smartent.Orchard.Platform.Data.LinqToYesSql/Smartent.Orchard.Platform.Data.LinqToYesSql.csproj" />
```

### NuGet（发布后，版本号以实际发布为准）

```xml
<PackageReference Include="Smartent.Orchard.DataTables" Version="1.0.0" />
```

### Orchard 功能（如适用）

- 宿主中启用：`（见 Manifest / Module.cs）`
- 相关模块：见「依赖说明」

## 使用方式

1. 在 Web 应用或模块解决方案中引用本项目。
2. 将模块加入宿主，在后台「配置 → 功能」启用，并按需执行 `Recipes/` 下的配方。

## 依赖说明

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| `ClosedXML` | 包引用 | 版本 `0.105.1` |
| `Nito.AsyncEx.Tasks` | 包引用 | 版本 `5.1.2` |
| `OrchardCore.Data.YesSql` | 包引用 | 版本 `3.0.1` |
| `Smartent.Orchard.Platform.Data.LinqToYesSql` | 包引用 | 版本 `$(PackageVersionSmartentPlatform)` |
| `MySqlConnector` | 包引用 | 版本 `2.6.2` |

### 前端（如适用）

规范：[frontend-dependencies](../../docs/standards/frontend-dependencies.md)。仅当本目录存在 `package.json` 时执行前端构建命令。

| npm 包 | 版本 | 用途 | 构建 |
|--------|------|------|------|
| | `datatables.net` | 2.3.2 | dependencies | see package.json scripts |
| `datatables.net-bs5` | 2.3.2 | dependencies | see package.json scripts |
| `datatables.net-buttons` | 3.2.4 | dependencies | see package.json scripts |
| `datatables.net-buttons-bs5` | 3.2.4 | dependencies | see package.json scripts |
| `urijs` | 1.19.11 | dependencies | see package.json scripts | | | | |

## 升级与扩展

- **Orchard**：与仓库 `OrchardCoreVersion` / 中央包管理对齐。
- **扩展点**：Driver/Handler/Shape 及模块内接口（见源码）。
- **定制**：配置节使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 测试

```powershell
dotnet build "src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.csproj"
dotnet test "src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.csproj"
```

UI 测试：在解决方案中筛选 `*.Tests.UI.csproj` 运行。

## 来源与许可

- 自 Lombiq OSOCE 谱系迁入；已 Smartent 化包 ID 与命名空间。
- 许可：MIT（见仓库根 `License.md`）。
