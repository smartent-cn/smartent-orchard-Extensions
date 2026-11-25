# Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions

> **中文说明**: [Readme-CN.md](Readme-CN.md)

## Summary

Adds **Login as admin** to the **tenant list** (`TenantActionButtons`), using a **Default-shell launch proxy** (like Orchard’s tenant Features proxy). Child login still uses `Smartent.Orchard.Hosting.Tenants.Admin.Login` **SubTenant** on each child.

## Features

| Feature Id | Where |
|------------|--------|
| `Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions` | Default tenant only |

**Also enable on Default:** `Smartent.Orchard.Hosting.Tenants.Admin.Login` (Module).  
**On each child:** `...Admin.Login.SubTenant` (recipe, Features proxy, or child admin).

## Flow

1. Tenant list shows **Login as admin** when the child is **Running**, **SubTenant** is enabled, and the user has `LoginAsAdmin`.
2. The button is a **GET** link to `TenantAdminLoginLaunch/Prepare` on **Default** (no nested form inside the tenant list POST form).
3. Default validates and renders auto-POST to the child `TenantLogin/Index`.
4. Child signs in and redirects to its admin.

## References

```xml
<ProjectReference Include="path/Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions/Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.csproj" />
```

## Tests

`dotnet build src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions/Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.csproj`