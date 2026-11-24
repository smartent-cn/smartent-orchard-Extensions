<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.VueJs

> **English**: [Readme.md](Readme.md)  
> **PackageId**：`Smartent.Orchard.VueJs` · **路径**：`src/Modules/Smartent.Orchard.VueJs`

## 摘要

Smartent.Orchard.VueJs

## 适用场景

在 Orchard 页面/Shape 中托管 Vue 3 单文件组件并走统一前端构建时使用。

## 快速开始

1. 在宿主（如 `Smartent.Demo.Web`）中添加：`<ProjectReference Include="src/Modules/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.csproj" />`。
2. 构建：`dotnet build src/Modules/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.csproj`。
3. 运行站点，在 **配置 → 功能** 中启用 **`Smartent.Orchard.VueJs`** 及上表依赖。
4. 需要时从 **工具 → 配方** 执行：`Smartent.Orchard.VueJs.Samples/Recipes/Smartent.Orchard.VueJs.Samples.Content.recipe.json`。
5. Demo 宿主：`dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`。

## Orchard 功能（Feature）

| Feature Id | 名称 | 依赖 |
|------------|------|------|
| — | — | — |

在后台 **配置 → 功能** 中启用（除明确为宿主级模块外，均按**租户**生效）。

## 配置

本包无独立 `appsettings` 节；可选通过 Orchard 设置项或无需配置。

> 配置节仅使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 使用方式（站点/运营）

启用功能后通过 Orchard 后台及模块菜单使用。

## 使用方式（开发）

使用 `vue-component-app` 标签助手或 `.smartent-vue` 根节点；经 `Smartent.Build.NodeJs` 执行 `pnpm`；npm 包名 `smartent-vuejs`。

### 引用

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.csproj" />
```

### NuGet（发布后）

```xml
<PackageReference Include="Smartent.Orchard.VueJs" Version="1.0.0" />
```

## 样例与配方（Recipe）

- `Smartent.Orchard.VueJs.Samples/Recipes/Smartent.Orchard.VueJs.Samples.Content.recipe.json`

## 注意事项与常见坑

- 修改脚本后需先跑 Node/pnpm 再 `dotnet build`。
- CSP 可能阻止 Vue 内联初始化；与平台 CSP 模块对齐。

## 测试

```powershell
dotnet build src/Modules/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.csproj
dotnet test src/Modules/Smartent.Orchard.VueJs/*.Tests*.csproj
```

## 本目录相关工程

- `Smartent.Orchard.VueJs` — 主模块
- `Smartent.Orchard.VueJs.Resources` — 主模块
- `Smartent.Orchard.VueJs.Samples` — 样例与配方
- `Smartent.Orchard.VueJs.Tests.UI` — 自动化/UI 测试

## 来源

Smartent Orchard Extensions 培训/demo 单体仓库；由 Lombiq OSOCE 谱系迁入。许可见仓库根目录 MIT。