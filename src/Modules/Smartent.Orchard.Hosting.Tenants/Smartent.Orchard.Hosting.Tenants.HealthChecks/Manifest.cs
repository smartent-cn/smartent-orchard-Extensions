using Smartent.Orchard.Hosting.Tenants.HealthChecks.Constants;
using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Smartent Orchard Hosting - Tenants Health Checks",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions",
    Version = "0.0.1",
    Description = "Multi-tenancy related health check improvements.",
    Category = "Hosting"
)]

[assembly: Feature(
    Id = HealthChecksFeatureIds.AllTenants,
    Name = "Smartent Orchard Hosting - Tenants Health Checks - All Tenants",
    Category = "Hosting",
    Dependencies = ["OrchardCore.HealthChecks"]
)]

[assembly: Feature(
    Id = HealthChecksFeatureIds.DefaultTenant,
    Name = "Smartent Orchard Hosting - Tenants Health Checks - Default Tenant",
    Category = "Hosting",
    Dependencies = ["OrchardCore.HealthChecks"],
    DefaultTenantOnly = true
)]

[assembly: Feature(
    Id = HealthChecksFeatureIds.Admin,
    Name = "Smartent Orchard Hosting - Tenants Health Checks - Admin Features",
    Category = "Hosting",
    Dependencies = [HealthChecksFeatureIds.DefaultTenant],
    DefaultTenantOnly = true
)]
