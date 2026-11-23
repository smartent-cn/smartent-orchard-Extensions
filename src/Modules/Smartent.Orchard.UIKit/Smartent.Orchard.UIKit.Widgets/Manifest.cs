using Smartent.Orchard.UIKit;
using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Smartent Orchard UI Kit - Widgets",
    Author = "Smartent",
    Version = "0.0.1",
    Description = "Module for reusable widgets based on Smartent Orchard UI Kit.",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules",
    Category = "Development",
    Dependencies = [
        FeatureIds.Base,
        "Smartent.Orchard.Extensions.Cms.ContentTypes",
        "OrchardCore.ContentFields",
        "OrchardCore.Media",
        "OrchardCore.Queries"
        ]
)]
