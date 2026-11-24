<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.Extensions.Cms

> **English**: [Readme.md](Readme.md)  
> **PackageId**：`Smartent.Orchard.Extensions.Cms` · **路径**：`src/Modules/Smartent.Orchard.Extensions.Cms`

## 摘要

Orchard Core module containing some handy extensions (e.g. useful content types and widgets). It's also available on all sites of DotNest, the Orchard SaaS.

## 适用场景

Smartent demo 仓库中的 Orchard Core 扩展模块。

## 快速开始

1. 在宿主（如 `Smartent.Demo.Web`）中添加：`<ProjectReference Include="src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj" />`。
2. 构建：`dotnet build src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj`。
3. 运行站点，在 **配置 → 功能** 中启用 **`CodeGeneration`** 及上表依赖。
4. 需要时从 **工具 → 配方** 执行：`Smartent.Orchard.Extensions.Cms.Tests.UI/Recipes/Smartent.Orchard.Extensions.Cms.Tests.UI.Lucide.Tests.recipe.json`。
5. Demo 宿主：`dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`。

## Orchard 功能（Feature）

| Feature Id | 名称 | 依赖 |
|------------|------|------|
| `CodeGeneration` | Smartent Orchard Extensions - Code Generation Helpful Extensions | OrchardCore.Resources |
| `ContentSets` | Smartent Orchard Extensions - Content Sets | OrchardCore.ContentManagement |
| `Flows` | Smartent Orchard Extensions - Flows Helpful Extensions | OrchardCore.Flows |
| `Widgets` | Smartent Orchard Extensions - Helpful Widgets | OrchardCore.Html, OrchardCore.Liquid, OrchardCore.Title |
| `ContentTypes` | Smartent Orchard Extensions - Helpful Content Types | OrchardCore.Autoroute, OrchardCore.Flows, OrchardCore.Title |
| `Security` | Smartent Orchard Extensions - Security Helpful Extensions | — |
| `ShapeTracing` | Smartent Orchard Extensions - Shape Tracing Helpful Extensions | — |
| `FeatureIds.Shortcodes` | Smartent Orchard Extensions - Shortcode Extensions | — |
| `Emails` | Smartent Orchard Extensions - Emails | OrchardCore.Email |
| `TargetBlank` | Smartent Orchard Extensions - Target Blank | — |
| `SiteTexts` | Smartent Orchard Extensions - Site Texts | OrchardCore.Markdown |
| `OrchardRecipeMigration` | Smartent Orchard Extensions - Orchard 1 Recipe Migration | OrchardCore.Contents |
| `ResetPasswordActivity` | Smartent Orchard Extensions - Reset password workflow activity | OrchardCore.Users.ResetPassword, OrchardCore.Workflows |
| `Trumbowyg` | Smartent Orchard Extensions - Trumbowyg code snippet | — |
| `TrumbowygBlogPosts` | Smartent Orchard Extensions - Trumbowyg code snippet - Blog Posts | — |
| `GoogleTag` | Smartent Orchard Extensions - Google Tag | — |
| `Liquid` | Smartent Orchard Extensions - Liquid Tags | — |
| `Lucide` | Smartent Orchard Extensions - Lucide | OrchardCore.ContentFields, OrchardCore.Resources |
| `SimpleIcons` | Smartent Orchard Extensions - Simple Icons | OrchardCore.DisplayManagement |

在后台 **配置 → 功能** 中启用（除明确为宿主级模块外，均按**租户**生效）。

## 配置

本包无独立 `appsettings` 节；可选通过 Orchard 设置项或无需配置。

> 配置节仅使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 使用方式（站点/运营）

启用功能后通过 Orchard 后台及模块菜单使用。

## 使用方式（开发）

通过 DI、Handler、Shape 及 Samples 中的 Recipe 扩展。

### 引用

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj" />
```

### NuGet（发布后）

```xml
<PackageReference Include="Smartent.Orchard.Extensions.Cms" Version="1.0.0" />
```

## 样例与配方（Recipe）

- `Smartent.Orchard.Extensions.Cms.Tests.UI/Recipes/Smartent.Orchard.Extensions.Cms.Tests.UI.Lucide.Tests.recipe.json`
- `Smartent.Orchard.Extensions.Cms.Tests.UI/Recipes/Smartent.Orchard.Extensions.Cms.Tests.UI.TrumbowygBlogPosts.Tests.recipe.json`
- `Smartent.Orchard.Extensions.Cms/Recipes/Smartent.Orchard.Extensions.Cms.ContentSets.Sample.recipe.json`
- `Smartent.Orchard.Extensions.Cms/Recipes/Smartent.Orchard.Extensions.Cms.Liquid.Sample.recipe.json`

## 注意事项与常见坑

- 每租户仅启用必要 Feature。
- 升级 Orchard Core 前先跑 `*.Tests` / `*.Tests.UI`。

## 测试

```powershell
dotnet build src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj
dotnet test src/Modules/Smartent.Orchard.Extensions.Cms/*.Tests*.csproj
```

## 本目录相关工程

- `Smartent.Orchard.Extensions.Cms` — 主模块
- `Smartent.Orchard.Extensions.Cms.Tests.UI` — 自动化/UI 测试

## 来源

Smartent Orchard Extensions 培训/demo 单体仓库；由 Lombiq OSOCE 谱系迁入。许可见仓库根目录 MIT。