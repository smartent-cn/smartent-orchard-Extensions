using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.Constants.FeatureNames;

[assembly: Module(
    Name = "Smartent Orchard Hosting - Tenants Admin Login Tenant Actions",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions",
    Version = "0.0.1"
)]

[assembly: Feature(
    Id = Module,
    Name = "Smartent Orchard Hosting - Tenants Admin Login Tenant Actions",
    Description = "Adds a Login as admin action on the tenant list using Orchard tenant action buttons and a Default-shell launch proxy.",
    Category = "Hosting",
    DefaultTenantOnly = true,
    Dependencies =
    [
        "Smartent.Orchard.Hosting.Tenants.Admin.Login",
        "OrchardCore.Tenants",
    ]
)]