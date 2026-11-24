<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.Privacy

> **English**: [Readme.md](Readme.md)  
> **PackageId**：`Smartent.Orchard.Privacy` · **路径**：`src/Modules/Smartent.Orchard.Privacy`

## 摘要

Orchard module containing features related to data protection/privacy and the EU law on it, the General Data Protection Regulation (GDPR).

## 适用场景

需要同意横幅、注册勾选框等隐私合规 UI 时使用。

## 快速开始

1. 在宿主（如 `Smartent.Demo.Web`）中添加：`<ProjectReference Include="src/Modules/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy.csproj" />`。
2. 构建：`dotnet build src/Modules/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy.csproj`。
3. 运行站点，在 **配置 → 功能** 中启用 **`Module`** 及上表依赖。
4. 需要时从 **工具 → 配方** 执行：`Smartent.Orchard.Privacy.Samples/Recipes/Smartent.Orchard.Privacy.Samples.Content.recipe.json`。
5. Demo 宿主：`dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`。

## Orchard 功能（Feature）

| Feature Id | 名称 | 依赖 |
|------------|------|------|
| `Module` | Smartent Orchard Privacy | — |
| `ConsentBanner` | Smartent Orchard Privacy - Consent banner | OrchardCore.CustomSettings |
| `RegistrationConsent` | Smartent Orchard Privacy - Registration consent | OrchardCore.CustomSettings, OrchardCore.Users.Registration |
| `ExternalRegistrationConsent` | Smartent Orchard Privacy - External Registration consent | OrchardCore.Users.ExternalAuthentication |
| `FormConsent` | Smartent Orchard Privacy - Form consent | OrchardCore.CustomSettings, OrchardCore.Forms |

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
<ProjectReference Include="src/Modules/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy.csproj" />
```

### NuGet（发布后）

```xml
<PackageReference Include="Smartent.Orchard.Privacy" Version="1.0.0" />
```

## 样例与配方（Recipe）

- `Smartent.Orchard.Privacy.Samples/Recipes/Smartent.Orchard.Privacy.Samples.Content.recipe.json`
- `Smartent.Orchard.Privacy.Samples/Recipes/Smartent.Orchard.Privacy.Samples.ContentDefinition.recipe.json`
- `Smartent.Orchard.Privacy.Samples/Recipes/Smartent.Orchard.Privacy.Samples.FeaturesAndSettings.recipe.json`
- `Smartent.Orchard.Privacy.Samples/Recipes/Smartent.Orchard.Privacy.Samples.WorkflowType.recipe.json`
- `Smartent.Orchard.Privacy.Samples/Recipes/Smartent.Orchard.Privacy.Samples.recipe.json`
- `Smartent.Orchard.Privacy/Migrations/Recipes/PrivacyConsentBannerSettings.recipe.json`
- `Smartent.Orchard.Privacy/Migrations/Recipes/PrivacyConsentCheckboxSettings.recipe.json`
- `Smartent.Orchard.Privacy/Migrations/Recipes/PrivacyRegistrationConsentSettings.recipe.json`

## 注意事项与常见坑

- 法律文案由站点自行负责；模块仅提供机制。
- Shape 使用 `Smartent_Orchard_Privacy_*`；主题覆盖需同步更新。

## 测试

```powershell
dotnet build src/Modules/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy.csproj
dotnet test src/Modules/Smartent.Orchard.Privacy/*.Tests*.csproj
```

## 本目录相关工程

- `Smartent.Orchard.Privacy` — 主模块
- `Smartent.Orchard.Privacy.Samples` — 样例与配方
- `Smartent.Orchard.Privacy.Tests.UI` — 自动化/UI 测试

## 来源

Smartent Orchard Extensions 培训/demo 单体仓库；由 Lombiq OSOCE 谱系迁入。许可见仓库根目录 MIT。