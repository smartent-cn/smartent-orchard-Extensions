using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.Hosting.Tenants.IdleTenantManagement.Constants.FeatureNames;

[assembly: Module(
    Name = "Smartent Orchard Hosting - Tenants Idle Tenant Management",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules",
    Version = "0.0.1",
    Description = "Managing idle tenants."
)]

[assembly: Feature(
    Id = ShutDownIdleTenants,
    Name = "Smartent Orchard Hosting - Tenants Idle Tenant Management Shut Down Idle Tenants",
    Description = "Shut down tenants not receiving requests after a configured amount of time to conserve computing resources.",
    Category = "Hosting",
    Priority = "9999",
    IsAlwaysEnabled = true
)]
