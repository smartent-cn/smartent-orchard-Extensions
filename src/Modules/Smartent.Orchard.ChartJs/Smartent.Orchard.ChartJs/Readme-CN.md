<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.ChartJs

> **English**: [Readme.md](Readme.md)  
> **PackageId**：`Smartent.Orchard.ChartJs` · **路径**：`src/Modules/Smartent.Orchard.ChartJs`

## 摘要

An Orchard Core wrapper around the Chart.js library for displaying datasets as various charts.

## 适用场景

在 Orchard Core 中展示 Chart.js 图表、后台统计或样例仪表盘时使用。

## 快速开始

1. 在宿主（如 `Smartent.Demo.Web`）中添加：`<ProjectReference Include="src/Modules/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs.csproj" />`。
2. 构建：`dotnet build src/Modules/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs.csproj`。
3. 运行站点，在 **配置 → 功能** 中启用 **`Default`** 及上表依赖。
4. 需要时从 **工具 → 配方** 执行：`Smartent.Orchard.ChartJs.Samples/Recipes/Smartent.Orchard.ChartJs.Samples.Content.recipe.json`。
5. Demo 宿主：`dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`。

## Orchard 功能（Feature）

| Feature Id | 名称 | 依赖 |
|------------|------|------|
| `Default` | Smartent Orchard Chart.js | OrchardCore.Contents |

在后台 **配置 → 功能** 中启用（除明确为宿主级模块外，均按**租户**生效）。

## 配置

本包无独立 `appsettings` 节；可选通过 Orchard 设置项或无需配置。

> 配置节仅使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 使用方式（站点/运营）

启用功能后使用 Chart 组件或运行 Samples 配方；参见 `Smartent.Orchard.ChartJs.Samples`。

## 使用方式（开发）

引用模块后通过 Shape/Widget 使用 Chart.js 资源；样例容器 class：`smartentChartJsSamplesChartContainer`。

### 引用

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs.csproj" />
```

### NuGet（发布后）

```xml
<PackageReference Include="Smartent.Orchard.ChartJs" Version="1.0.0" />
```

## 样例与配方（Recipe）

- `Smartent.Orchard.ChartJs.Samples/Recipes/Smartent.Orchard.ChartJs.Samples.Content.recipe.json`

## 注意事项与常见坑

- 仅在需要图表的页面注册资源，避免全站加载 Chart.js。
- 升级时注意 `wwwroot` 内脚本版本与模块一致。

## 测试

```powershell
dotnet build src/Modules/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs.csproj
dotnet test src/Modules/Smartent.Orchard.ChartJs/*.Tests*.csproj
```

## 本目录相关工程

- `Smartent.Orchard.ChartJs` — 主模块
- `Smartent.Orchard.ChartJs.Samples` — 样例与配方
- `Smartent.Orchard.ChartJs.Tests.UI` — 自动化/UI 测试

## 来源

Smartent Orchard Extensions 培训/demo 单体仓库；由 Lombiq OSOCE 谱系迁入。许可见仓库根目录 MIT。