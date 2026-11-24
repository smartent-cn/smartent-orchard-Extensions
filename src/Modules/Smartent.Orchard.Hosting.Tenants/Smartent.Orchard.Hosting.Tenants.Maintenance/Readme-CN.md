# Smartent.Orchard.Hosting.Tenants.Maintenance

> **English**: [Readme.md](Readme.md)  
> **PackageId**：`Smartent.Orchard.Hosting.Tenants.Maintenance` · **路径**：`src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Maintenance`

## 摘要

With the help of this module you can execute maintenance tasks on tenants.

## 适用场景

租户/托管自动化子模块；仅在需要该能力的环境启用。

## 快速开始

在宿主租户启用功能 `Maintenance`；在 `OrchardCore` 下配置相应节。

## Orchard 功能（Feature）

| Feature Id | 名称 | 依赖 |
|------------|------|------|
| `Maintenance` | Smartent Orchard Hosting - Tenants Maintenance | — |
| `UpdateSiteUrl` | Smartent Orchard Hosting - Tenants Maintenance Update Site URL | — |
| `UpdateShellRequestUrls` | Smartent Orchard Hosting - Tenants Maintenance Update Shell Request URLs | — |
| `AddAdministratorRoleToUsersWithRole` | Smartent Orchard Hosting - Tenants Maintenance Add Administrator Role to Users With Role | — |
| `RemoveUsers` | Smartent Orchard Hosting - Tenants Maintenance Remove Users | — |
| `ChangeUserSensitiveContent` | Smartent Orchard Hosting - Tenants Maintenance Change User Sensitive Content | — |
| `DeleteOrRebuildElasticsearchIndices` | Smartent Orchard Hosting - Tenants Maintenance Delete or Rebuild Elasticsearch Indexes | OrchardCore.Elasticsearch |
| `DeleteElasticsearchIndicesBeforeSetup` | Smartent Orchard Hosting - Tenants Maintenance Delete Elasticsearch Indexes Before Setup | — |
| `PurgeMediaCache` | Smartent Orchard Hosting - Tenants Maintenance Purge Media Cache | OrchardCore.Media |
| `UpdateEnabledFeatures` | Smartent Orchard Hosting - Tenants Maintenance Update Enabled Features | — |
| `StaggeredTenantWakeUp` | Smartent Orchard Hosting - Tenants Maintenance Staggered Tenant Wake-up | OrchardCore.Tenants, OrchardCore.ContentFields, OrchardCore.Contents |

在后台 **配置 → 功能** 中启用（除明确为宿主级模块外，均按**租户**生效）。

## 配置

本包无独立 `appsettings` 节；可选通过 Orchard 设置项或无需配置。

> 配置节仅使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 使用方式（站点/运营）

后台入口因包而异（见源码 `Startup.cs` 及解决方案根 Readme）。

## 使用方式（开发）

从 SaaS/宿主 Web 引用本 csproj；多数包注册租户管理或健康检查端点。

### 引用

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Maintenance/Smartent.Orchard.Hosting.Tenants.Maintenance.csproj" />
```

### NuGet（发布后）

```xml
<PackageReference Include="Smartent.Orchard.Hosting.Tenants.Maintenance" Version="1.0.0" />
```

## 样例与配方（Recipe）

- 见 `Smartent.Orchard.Hosting.Tenants` 解决方案根 Readme。

## 注意事项与常见坑

- 配置错误可能导致租户锁定或无法登录后台；请先在预发验证。
- 存储/密钥等敏感信息勿提交 git。

## 测试

`dotnet test src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Maintenance/*.Tests*.csproj`

## 本目录相关工程

- 上级：`src/Modules/Smartent.Orchard.Hosting.Tenants/Readme-CN.md`

## 来源

Smartent Orchard Extensions 培训/demo 单体仓库；由 Lombiq OSOCE 谱系迁入。许可见仓库根目录 MIT。