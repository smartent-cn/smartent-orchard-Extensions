<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.JsonEditor

> **English**: [Readme.md](Readme.md)  
> **PackageId**：`Smartent.Orchard.JsonEditor` · **路径**：`src/Modules/Smartent.Orchard.JsonEditor`

## 摘要

Orchard Core module for displaying a JSON Editor like on (https://jsoneditoronline.org/.

## 适用场景

后台编辑 JSON 字段时需要结构化编辑器而非纯文本框。

## 快速开始

1. 在宿主（如 `Smartent.Demo.Web`）中添加：`<ProjectReference Include="src/Modules/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor.csproj" />`。
2. 构建：`dotnet build src/Modules/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor.csproj`。
3. 运行站点，在 **配置 → 功能** 中启用 **`Smartent.Orchard.JsonEditor`** 及上表依赖。
4. 需要时从 **工具 → 配方** 执行：`Smartent.Orchard.JsonEditor/Recipes/JsonEditor.Sample.recipe.json`。
5. Demo 宿主：`dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`。

## Orchard 功能（Feature）

| Feature Id | 名称 | 依赖 |
|------------|------|------|
| `Smartent.Orchard.JsonEditor` | Smartent Orchard JSON Editor | OrchardCore.Contents, OrchardCore.ResourceManagement |
| `ContentEditor` | Smartent JSON Content Editor | — |

在后台 **配置 → 功能** 中启用（除明确为宿主级模块外，均按**租户**生效）。

## 配置

本包无独立 `appsettings` 节；可选通过 Orchard 设置项或无需配置。

> 配置节仅使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 使用方式（站点/运营）

通过迁移或 Samples 配方为字段挂载 JSON 编辑器。

## 使用方式（开发）

通过 DI、Handler、Shape 及 Samples 中的 Recipe 扩展。

### 引用

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor.csproj" />
```

### NuGet（发布后）

```xml
<PackageReference Include="Smartent.Orchard.JsonEditor" Version="1.0.0" />
```

## 样例与配方（Recipe）

- `Smartent.Orchard.JsonEditor/Recipes/JsonEditor.Sample.recipe.json`

## 注意事项与常见坑

- 大 JSON 可能拖慢后台；服务端须做校验。

## 测试

```powershell
dotnet build src/Modules/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor.csproj
dotnet test src/Modules/Smartent.Orchard.JsonEditor/*.Tests*.csproj
```

## 本目录相关工程

- `Smartent.Orchard.JsonEditor` — 主模块
- `Smartent.Orchard.JsonEditor.Tests.UI` — 自动化/UI 测试

## 来源

Smartent Orchard Extensions 培训/demo 单体仓库；由 Lombiq OSOCE 谱系迁入。许可见仓库根目录 MIT。