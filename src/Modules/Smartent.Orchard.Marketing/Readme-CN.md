<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.Marketing

> **English**: [Readme.md](Readme.md)  
> **PackageId**：`Smartent.Orchard.Marketing` · **路径**：`src/Modules/Smartent.Orchard.Marketing`

## 摘要

Shared marketing abstractions, short URL hit handling, and client-side tracking composition.

## 适用场景

集成 Pirsch 统计、短链接与营销追踪时使用。

## 快速开始

1. 在宿主（如 `Smartent.Demo.Web`）中添加：`<ProjectReference Include="src/Modules/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing.csproj" />`。
2. 构建：`dotnet build src/Modules/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing.csproj`。
3. 运行站点，在 **配置 → 功能** 中启用 **`FeatureIds.Base`** 及上表依赖。
4. 需要时从 **工具 → 配方** 执行：`见 Samples 目录`。
5. Demo 宿主：`dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`。

## Orchard 功能（Feature）

| Feature Id | 名称 | 依赖 |
|------------|------|------|
| `FeatureIds.Base` | Smartent Orchard Marketing | — |

在后台 **配置 → 功能** 中启用（除明确为宿主级模块外，均按**租户**生效）。

## 配置

配置键（位于 `OrchardCore` 节点下）：

- `OrchardCore:Smartent_Marketing`

环境变量使用双下划线，例如 `OrchardCore__Smartent_Marketing__...`。

> 配置节仅使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 使用方式（站点/运营）

启用功能后通过 Orchard 后台及模块菜单使用。

## 使用方式（开发）

在 `appsettings.json` 配置 `OrchardCore:Smartent_Marketing`；子包：`Smartent.Orchard.Marketing.Pirsch`、`.UrlShortener`。

### 引用

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing.csproj" />
```

### NuGet（发布后）

```xml
<PackageReference Include="Smartent.Orchard.Marketing" Version="1.0.0" />
```

## 样例与配方（Recipe）

- 可选：启用 `Smartent.Orchard.Marketing.Samples` 并导入其配方。

## 注意事项与常见坑

- 勿将 Pirsch 令牌提交 git；使用 User Secrets。
- 短链迁移仅含示例活动数据。

## 测试

```powershell
dotnet build src/Modules/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing.csproj
dotnet test src/Modules/Smartent.Orchard.Marketing/*.Tests*.csproj
```

## 本目录相关工程

- `Smartent.Orchard.Marketing` — 主模块
- `Smartent.Orchard.Marketing.Pirsch` — 主模块
- `Smartent.Orchard.Marketing.Tests.UI` — 自动化/UI 测试
- `Smartent.Orchard.Marketing.UrlShortener` — 主模块

## 来源

Smartent Orchard Extensions 培训/demo 单体仓库；由 Lombiq OSOCE 谱系迁入。许可见仓库根目录 MIT。