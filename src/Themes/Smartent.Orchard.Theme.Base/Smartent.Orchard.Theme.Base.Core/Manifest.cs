using OrchardCore.DisplayManagement.Manifest;
using static Smartent.Orchard.Extensions.Cms.FeatureIds;

[assembly: Theme(
    Name = "Smartent Orchard Theme Base - Core Features",
    Author = "Smartent",
    Version = "0.0.1",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules",
    Description = "All the shared content between the Sass and native CSS versions of the base theme.",
    Dependencies =
    [
        ContentTypes,
        Widgets,
    ]
)]
