using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.Hosting.Tenants.Admin.Login.Constants.FeatureNames;

[assembly: Module(
    Name = "Smartent Orchard Hosting - Tenants Admin Login ",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions",
    Version = "0.0.1"
)]

[assembly: Feature(
    Id = Module,
    Name = "Smartent Orchard Hosting - Tenants Admin Login",
    Description = "Ability to log in as a tenant’s admin user.",
    Category = "Hosting",
    DefaultTenantOnly = true,
    Dependencies = ["OrchardCore.Tenants"]
)]

[assembly: Feature(
    Id = SubTenant,
    Name = "Smartent Orchard Hosting - Tenants Admin Login Sub-tenant",
    Description = "Adds the ability to log in to the tenant from the Default tenant.",
    Category = "Hosting",
    IsAlwaysEnabled = true
)]
