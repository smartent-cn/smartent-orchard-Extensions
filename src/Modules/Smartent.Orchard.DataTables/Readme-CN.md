<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.DataTables

> **English**: [Readme.md](Readme.md)  
> **PackageId**：`Smartent.Orchard.DataTables` · **路径**：`src/Modules/Smartent.Orchard.DataTables`

## 摘要

An Orchard Core wrapper around the DataTables (https://datatables.net/) library for displaying tabular data from custom data sources. It lets you replace HTML tables with a tag helper or create asynchronous, sortable, searchable server-side generated tables. It also includes a pure Vue.js module that works similarly to DataTables.

## 适用场景

需要可排序/可搜索表格、后台数据网格或 DOM/标签助手表格时使用。

## 快速开始

1. 在宿主（如 `Smartent.Demo.Web`）中添加：`<ProjectReference Include="src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.csproj" />`。
2. 构建：`dotnet build src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.csproj`。
3. 运行站点，在 **配置 → 功能** 中启用 **`Smartent.Orchard.DataTables`** 及上表依赖。
4. 需要时从 **工具 → 配方** 执行：`Smartent.Orchard.DataTables.Samples/Recipes/Smartent.Orchard.DataTables.Samples.Content.recipe.json`。
5. Demo 宿主：`dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`。

## Orchard 功能（Feature）

| Feature Id | 名称 | 依赖 |
|------------|------|------|
| `Smartent.Orchard.DataTables` | Smartent Orchard Data Tables | OrchardCore.Contents, OrchardCore.ResourceManagement, OrchardCore.Queries |

在后台 **配置 → 功能** 中启用（除明确为宿主级模块外，均按**租户**生效）。

## 配置

本包无独立 `appsettings` 节；可选通过 Orchard 设置项或无需配置。

> 配置节仅使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 使用方式（站点/运营）

单表后台页访问 `/Admin/DataTable/{providerName}/{queryId?}`；可启用 Samples 查看演示。

## 使用方式（开发）

实现 `IDataTableDataProvider` 并用 `AddDataTableDataProvider<T>()` 注册；前端 `smartent_DataTables`，事件命名空间 `.smartentdt`。

### 引用

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.csproj" />
```

### NuGet（发布后）

```xml
<PackageReference Include="Smartent.Orchard.DataTables" Version="1.0.0" />
```

## 样例与配方（Recipe）

- `Smartent.Orchard.DataTables.Samples/Recipes/Smartent.Orchard.DataTables.Samples.Content.recipe.json`

## 注意事项与常见坑

- 索引型 Provider 需配方/迁移重建索引。
- 重查询优先用 `IndexBasedDataTableDataProvider`，避免按需全表扫描。

## 测试

```powershell
dotnet build src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.csproj
dotnet test src/Modules/Smartent.Orchard.DataTables/*.Tests*.csproj
```

## 本目录相关工程

- `Smartent.Orchard.DataTables` — 主模块
- `Smartent.Orchard.DataTables.Samples` — 样例与配方
- `Smartent.Orchard.DataTables.Tests` — 自动化/UI 测试
- `Smartent.Orchard.DataTables.Tests.UI` — 自动化/UI 测试

## 来源

Smartent Orchard Extensions 培训/demo 单体仓库；由 Lombiq OSOCE 谱系迁入。许可见仓库根目录 MIT。