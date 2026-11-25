# Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions

> **English**: [Readme.md](Readme.md)

## 摘要

在 **租户列表**（`TenantActionButtons` 扩展点，与官方 **Features** 按钮同列）增加 **Login as admin**。点击后在 **Default** 上经启动代理校验，再 POST 到子租户；子租户仍须启用 **Admin.Login.SubTenant**。

## Feature

| Feature Id | 启用位置 |
|------------|----------|
| `Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions` | 仅 Default |

Default 还须启用 `Smartent.Orchard.Hosting.Tenants.Admin.Login`（Module）；子租户须启用 `...Admin.Login.SubTenant`（配方 / Default→Features 代理 / 子租户后台）。

## 流程

1. 列表显示按钮：子租户 **运行中**、已开 **SubTenant**、当前用户有 `LoginAsAdmin`。
2. 按钮为 **GET** 链接到 Default 的 `TenantAdminLoginLaunch/Prepare`（避免嵌套在租户列表大表单内再起 `<form>`）。
3. Default 校验后输出自动提交页，POST 子租户 `TenantLogin/Index`。
4. 子租户登录并进入其后台。

## 引用

```xml
<ProjectReference Include="path/Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions/Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.csproj" />
```