<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.AuditTrail

> **English**: [Readme.md](Readme.md)  
> **PackageId**：`Smartent.Orchard.AuditTrail` · **路径**：`src/Modules/Smartent.Orchard.AuditTrail`

## 摘要

A module with additional features for the Audit Trail module in Orchard Core.

## 适用场景

需要在 Audit Trail 事件基础上按“版本”思路读取内容历史、而不仅依赖内置 Versionable 时使用。

## 快速开始

1. 在宿主（如 `Smartent.Demo.Web`）中添加：`<ProjectReference Include="src/Modules/Smartent.Orchard.AuditTrail/Smartent.Orchard.AuditTrail.csproj" />`。
2. 构建：`dotnet build src/Modules/Smartent.Orchard.AuditTrail/Smartent.Orchard.AuditTrail.csproj`。
3. 运行站点，在 **配置 → 功能** 中启用 **`Default`** 及上表依赖。
4. 需要时从 **工具 → 配方** 执行：`见 Samples 目录`。
5. Demo 宿主：`dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`。

## Orchard 功能（Feature）

| Feature Id | 名称 | 依赖 |
|------------|------|------|
| `Default` | Smartent Orchard Audit Trail Extensions | OrchardCore.Contents, OrchardCore.AuditTrail |

在后台 **配置 → 功能** 中启用（除明确为宿主级模块外，均按**租户**生效）。

## 配置

本包无独立 `appsettings` 节；可选通过 Orchard 设置项或无需配置。

> 配置节仅使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 使用方式（站点/运营）

无独立后台菜单；能力以服务形式供代码或其它模块调用。

## 使用方式（开发）

在 Handler/Service 中注入 `IAuditTrailContentVersionNumberService`；须先启用 **OrchardCore.AuditTrail**。

### 引用

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.AuditTrail/Smartent.Orchard.AuditTrail.csproj" />
```

### NuGet（发布后）

```xml
<PackageReference Include="Smartent.Orchard.AuditTrail" Version="1.0.0" />
```

## 样例与配方（Recipe）

- 可选：启用 `Smartent.Orchard.AuditTrail.Samples` 并导入其配方。

## 注意事项与常见坑

- 依赖 Audit Trail 保留策略；清理审计日志会影响历史查询。
- 不能自动替代 **Versionable** 内容定义，需自行建模。

## 测试

```powershell
dotnet build src/Modules/Smartent.Orchard.AuditTrail/Smartent.Orchard.AuditTrail.csproj
dotnet test src/Modules/Smartent.Orchard.AuditTrail/*.Tests*.csproj
```

## 本目录相关工程

- `.` — `Smartent.Orchard.AuditTrail`

## 来源

Smartent Orchard Extensions 培训/demo 单体仓库；由 Lombiq OSOCE 谱系迁入。许可见仓库根目录 MIT。