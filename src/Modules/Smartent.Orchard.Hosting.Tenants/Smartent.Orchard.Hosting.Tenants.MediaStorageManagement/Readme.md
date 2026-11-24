# Smartent Orchard Hosting - Tenants Media Storage Management for Orchard Core
> **中文说明**: [Readme-CN.md](Readme-CN.md)


[![Smartent.Orchard.Hosting.Tenants.MediaStorageManagement NuGet](https://img.shields.io/nuget/v/Smartent.Orchard.Hosting.Tenants.MediaStorageManagement?label=Smartent.Orchard.Hosting.Tenants.MediaStorageManagement)](https://www.nuget.org/packages/Smartent.Orchard.Hosting.Tenants.MediaStorageManagement/)

## About

With the help of this module, you can set restrictions regarding maximum media space per tenant.

Do you want to quickly try out this project and see it in action? Check it out in our [Open-Source Orchard Core Extensions](https://github.com/smartent-cn/smartent-orchard-Extensions) full Orchard Core solution and also see our other useful Orchard Core-related open-source projects!

## Documentation

This module currently contains one feature:

- `Smartent.Orchard.Hosting.Tenants.MediaStorageManagement`

### `Smartent.Orchard.Hosting.Tenants.MediaStorageManagement`

With this module, you can specify how much space would you like to limit each tenant's storage space. The default is 1GB. If you want to set it to 2GB e.g. you can do it in bytes as an environment variable or in _appsettings.json_ as follows:

```json
"OrchardCore": {
  "Smartent_Orchard_Hosting_Tenants_MediaStorageManagement": {
    "MaximumStorageQuotaBytes": 2147483648
  }  
}
```

Tenant based configuration can be defined as the following, for more details read the [Orchard Core documentation](https://docs.orchardcore.net/en/main/docs/reference/core/Configuration/#tenant-postconfiguration).

```json
"OrchardCore": {
  "TenantName": {
    "Smartent_Orchard_Hosting_Tenants_MediaStorageManagement": {
      "MaximumStorageQuotaBytes": 2147483648
    }
  }
}
```