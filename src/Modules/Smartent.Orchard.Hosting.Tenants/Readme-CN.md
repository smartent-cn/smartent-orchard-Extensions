<!-- MODULE-DOC-GENERATED -->
# Smartent.Orchard.Hosting.Tenants.Admin.Login

> **English**: [Readme.md](Readme.md)  
> **PackageId**：`Smartent.Orchard.Hosting.Tenants.Admin.Login` · **路径**：`src/Modules/Smartent.Orchard.Hosting.Tenants`

## 摘要

With the help of this module, you can log in from the Default tenant's admin dashboard to any other tenants as an administrator user. This is useful if you manage a lot of customer tenants and don't want to create individual logins of yours for each of them.

## 适用场景

多租户 SaaS：租户后台登录、配额、robots、健康检查、维护、媒体存储等。

## 快速开始

1. 在宿主（如 `Smartent.Demo.Web`）中添加：`<ProjectReference Include="src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Admin.Login/Smartent.Orchard.Hosting.Tenants.Admin.Login.csproj" />`。
2. 构建：`dotnet build src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Admin.Login/Smartent.Orchard.Hosting.Tenants.Admin.Login.csproj`。
3. 运行站点，在 **配置 → 功能** 中启用 **`Module`** 及上表依赖。
4. 需要时从 **工具 → 配方** 执行：`见 Samples 目录`。
5. Demo 宿主：`dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`。

## Orchard 功能（Feature）

| Feature Id | 名称 | 依赖 |
|------------|------|------|
| `Module` | Smartent Orchard Hosting - Tenants Admin Login | OrchardCore.Tenants |
| `SubTenant` | Smartent Orchard Hosting - Tenants Admin Login Sub-tenant | — |

在后台 **配置 → 功能** 中启用（除明确为宿主级模块外，均按**租户**生效）。

## 配置

配置键（位于 `OrchardCore` 节点下）：

- `OrchardCore:OrchardCore:Smartent_Orchard_Hosting_Tenants_HealthChecks`

环境变量使用双下划线，例如 `OrchardCore__OrchardCore:Smartent_Orchard_Hosting_Tenants_HealthChecks__...`。

> 配置节仅使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 使用方式（站点/运营）

启用功能后通过 Orchard 后台及模块菜单使用。

## 使用方式（开发）

通过 DI、Handler、Shape 及 Samples 中的 Recipe 扩展。

### 引用

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Admin.Login/Smartent.Orchard.Hosting.Tenants.Admin.Login.csproj" />
```

### NuGet（发布后）

```xml
<PackageReference Include="Smartent.Orchard.Hosting.Tenants.Admin.Login" Version="1.0.0" />
```

## 样例与配方（Recipe）

- 可选：启用 `Smartent.Orchard.Hosting.Tenants.Admin.Login.Samples` 并导入其配方。

## 注意事项与常见坑

- 各子包独立 Feature；只启用环境所需能力。
- 配置键前缀为 `Smartent_Orchard_Hosting_*`。

## 测试

```powershell
dotnet build src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Admin.Login/Smartent.Orchard.Hosting.Tenants.Admin.Login.csproj
dotnet test src/Modules/Smartent.Orchard.Hosting.Tenants/*.Tests*.csproj
```

## 本目录相关工程

- `Smartent.Orchard.Hosting.Tenants.Admin.Login` — 主模块
- `Smartent.Orchard.Hosting.Tenants.Admin.Login.Tests.UI` — 自动化/UI 测试
- `Smartent.Orchard.Hosting.Tenants.EmailQuotaManagement` — 主模块
- `Smartent.Orchard.Hosting.Tenants.EmailQuotaManagement.Tests.UI` — 自动化/UI 测试
- `Smartent.Orchard.Hosting.Tenants.EnvironmentRobots` — 主模块
- `Smartent.Orchard.Hosting.Tenants.EnvironmentRobots.Tests.UI` — 自动化/UI 测试
- `Smartent.Orchard.Hosting.Tenants.FeaturesGuard` — 主模块
- `Smartent.Orchard.Hosting.Tenants.FeaturesGuard.Tests.UI` — 自动化/UI 测试
- `Smartent.Orchard.Hosting.Tenants.HealthChecks` — 主模块
- `Smartent.Orchard.Hosting.Tenants.HealthChecks.Tests.UI` — 自动化/UI 测试
- `Smartent.Orchard.Hosting.Tenants.IdleTenantManagement` — 主模块
- `Smartent.Orchard.Hosting.Tenants.IdleTenantManagement.Tests.UI` — 自动化/UI 测试
- `Smartent.Orchard.Hosting.Tenants.Maintenance` — 主模块
- `Smartent.Orchard.Hosting.Tenants.Maintenance.Tests` — 自动化/UI 测试
- `Smartent.Orchard.Hosting.Tenants.Maintenance.Tests.UI` — 自动化/UI 测试
- `Smartent.Orchard.Hosting.Tenants.Management` — 主模块
- `Smartent.Orchard.Hosting.Tenants.Management.Tests.UI` — 自动化/UI 测试
- `Smartent.Orchard.Hosting.Tenants.MediaStorageManagement` — 主模块
- `Smartent.Orchard.Hosting.Tenants.MediaStorageManagement.Tests.UI` — 自动化/UI 测试

## 来源

Smartent Orchard Extensions 培训/demo 单体仓库；由 Lombiq OSOCE 谱系迁入。许可见仓库根目录 MIT。