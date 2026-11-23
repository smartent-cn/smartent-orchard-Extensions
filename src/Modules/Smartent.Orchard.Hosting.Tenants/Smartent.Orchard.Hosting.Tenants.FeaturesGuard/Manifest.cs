using Smartent.Orchard.Hosting.Tenants.FeaturesGuard.Constants;
using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Smartent Orchard Hosting - Tenants Features Guard",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules",
    Version = "0.0.1",
    Description = "Prevents disabling a configurable set of features on tenants.",
    Category = "Hosting"
)]

[assembly: Feature(
    Id = FeatureNames.FeaturesGuard,
    Name = "Smartent Orchard Hosting - Tenants Features Guard",
    Category = "Hosting",
    IsAlwaysEnabled = true
)]
