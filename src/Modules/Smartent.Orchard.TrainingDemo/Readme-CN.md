<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.TrainingDemo

> **English**: [Readme.md](Readme.md)  
> **PackageId**：`Smartent.Orchard.TrainingDemo` · **路径**：`src/Modules/Smartent.Orchard.TrainingDemo`

## 摘要

Smartent.Orchard.TrainingDemo

## 适用场景

Orchard Core 培训练习与示例控制器（仅演示）。

## 快速开始

1. 在宿主（如 `Smartent.Demo.Web`）中添加：`<ProjectReference Include="src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj" />`。
2. 构建：`dotnet build src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj`。
3. 运行站点，在 **配置 → 功能** 中启用 **`Smartent.Orchard.TrainingDemo`** 及上表依赖。
4. 需要时从 **工具 → 配方** 执行：`Smartent.Orchard.TrainingDemo/Recipes/TrainingDemo.Content.Sample.Person.recipe.json`。
5. Demo 宿主：`dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`。

## Orchard 功能（Feature）

| Feature Id | 名称 | 依赖 |
|------------|------|------|
| `Smartent.Orchard.TrainingDemo` | Smartent Orchard Training Demo | OrchardCore.Admin, OrchardCore.Apis.GraphQL, OrchardCore.BackgroundTasks, OrchardCore.ContentFields, OrchardCore.Contents, OrchardCore.ContentTypes, OrchardCore.DynamicCache, OrchardCore.HomeRoute, OrchardCore.Layers, OrchardCore.Localization, OrchardCore.Media, OrchardCore.Navigation, OrchardCore.Resources, OrchardCore.Roles, OrchardCore.Themes, OrchardCore.Users, OrchardCore.Workflows |
| `Smartent.Orchard.TrainingDemo.Middlewares` | Smartent Orchard Training Demo - Middlewares | Smartent.Orchard.TrainingDemo |

在后台 **配置 → 功能** 中启用（除明确为宿主级模块外，均按**租户**生效）。

## 配置

配置键（位于 `OrchardCore` 节点下）：

- `OrchardCore:Smartent_TrainingDemo`

环境变量使用双下划线，例如 `OrchardCore__Smartent_TrainingDemo__...`。

> 配置节仅使用 `Smartent_*` / `Smartent_Orchard_*`。

## 使用方式（站点/运营）

启用功能后通过 Orchard 后台及模块菜单使用。

## 使用方式（开发）

配置节：`OrchardCore:Smartent_TrainingDemo`（无遗留节）。

### 引用

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj" />
```

### NuGet（发布后）

```xml
<PackageReference Include="Smartent.Orchard.TrainingDemo" Version="1.0.0" />
```

## 样例与配方（Recipe）

- `Smartent.Orchard.TrainingDemo/Recipes/TrainingDemo.Content.Sample.Person.recipe.json`
- `Smartent.Orchard.TrainingDemo/Recipes/TrainingDemo.Workflows.Sample.recipe.json`
- `Smartent.Orchard.TrainingDemo/Recipes/TrainingDemo.recipe.json`

## 注意事项与常见坑

- 不可用于生产；正式环境请禁用。

## 测试

```powershell
dotnet build src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj
dotnet test src/Modules/Smartent.Orchard.TrainingDemo/*.Tests*.csproj
```

## 本目录相关工程

- `Smartent.Orchard.TrainingDemo` — 主模块
- `Smartent.Orchard.TrainingDemo.Tests` — 自动化/UI 测试
- `Smartent.Orchard.TrainingDemo.Web` — 主模块

## 来源

Smartent Orchard Extensions 培训/demo 单体仓库。许可见仓库根目录 MIT。