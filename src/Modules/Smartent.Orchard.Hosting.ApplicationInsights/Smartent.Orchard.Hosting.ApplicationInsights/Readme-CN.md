<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.Hosting.ApplicationInsights

> **English**: [Readme.md](Readme.md)  
> **PackageId**：`Smartent.Orchard.Hosting.ApplicationInsights` · **路径**：`src/Modules/Smartent.Orchard.Hosting.ApplicationInsights`

## 摘要

This Orchard Core module enables easy integration of Azure Application Insights telemetry into Orchard. Just install the module, configure the instrumentation key from a configuration source, and collected data will start appearing in the Azure Portal.

## 适用场景

Smartent demo 仓库中的 Orchard Core 扩展模块。

## 快速开始

1. 在宿主（如 `Smartent.Demo.Web`）中添加：`<ProjectReference Include="src/Modules/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights.csproj" />`。
2. 构建：`dotnet build src/Modules/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights.csproj`。
3. 运行站点，在 **配置 → 功能** 中启用 **`Smartent.Orchard.Hosting.ApplicationInsights`** 及上表依赖。
4. 需要时从 **工具 → 配方** 执行：`见 Samples 目录`。
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

通过 DI、Handler、Shape 及 Samples 中的 Recipe 扩展。

### 引用

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights.csproj" />
```

### NuGet（发布后）

```xml
<PackageReference Include="Smartent.Orchard.Hosting.ApplicationInsights" Version="1.0.0" />
```

## 样例与配方（Recipe）

- 可选：启用 `Smartent.Orchard.Hosting.ApplicationInsights.Samples` 并导入其配方。

## 注意事项与常见坑

- 每租户仅启用必要 Feature。
- 升级 Orchard Core 前先跑 `*.Tests` / `*.Tests.UI`。

## 测试

```powershell
dotnet build src/Modules/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights.csproj
dotnet test src/Modules/Smartent.Orchard.Hosting.ApplicationInsights/*.Tests*.csproj
```

## 本目录相关工程

- `Smartent.Orchard.Hosting.ApplicationInsights` — 主模块
- `Smartent.Orchard.Hosting.ApplicationInsights.Tests.UI` — 自动化/UI 测试

## 来源

Smartent Orchard Extensions 培训/demo 单体仓库；由 Lombiq OSOCE 谱系迁入。许可见仓库根目录 MIT。