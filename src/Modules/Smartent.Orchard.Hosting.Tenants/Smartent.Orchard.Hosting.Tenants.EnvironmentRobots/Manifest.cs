using Smartent.Orchard.Hosting.Tenants.EnvironmentRobots.Constants;
using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Smartent Orchard Hosting - Tenants Environment Robots",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules",
    Version = "0.0.1",
    Description = "Prevents search bots from indexing non-production environments by adding a meta tag and a response"
        + " header with noindex, nofollow values.",
    Category = "Hosting"
)]

[assembly: Feature(
    Id = FeatureNames.EnvironmentRobots,
    Name = "Smartent Orchard Hosting - Tenants Environment Robots",
    Category = "Hosting",
    IsAlwaysEnabled = true
)]
