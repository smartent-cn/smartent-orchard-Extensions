using Smartent.Orchard.Marketing.Pirsch.Constants;
using OrchardCore.Modules.Manifest;
using MarketingFeatureIds = Smartent.Orchard.Marketing.Constants.FeatureIds;

[assembly: Module(
    Name = "Smartent Orchard Marketing - Pirsch analytics",
    Author = "Smartent",
    Version = "0.0.1",
    Description = "Integrate the basics of Pirsch analytics into Orchard Core.",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions"
)]

[assembly: Feature(
    Id = FeatureIds.Base,
    Name = "Smartent Orchard Marketing - Pirsch analytics",
    Category = "Marketing",
    Description = "Integrate the basics of Pirsch analytics into Orchard Core.",
    Dependencies =
    [
        MarketingFeatureIds.Base,
    ]
)]
