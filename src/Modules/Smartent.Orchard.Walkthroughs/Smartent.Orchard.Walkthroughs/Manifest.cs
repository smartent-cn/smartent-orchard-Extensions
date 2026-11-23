using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.Walkthroughs.Constants.FeatureIds;

[assembly: Module(
    Name = "Smartent Orchard Walkthroughs",
    Author = "Smartent",
    Version = "0.0.1",
    Description = "Module for enabling the walkthroughs.",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules"
)]

[assembly: Feature(
    Id = Default,
    Name = "Smartent Orchard Walkthroughs",
    Category = "Content",
    Description = "Module for enabling the walkthroughs.",
    Dependencies =
    [
        "OrchardCore.Contents",
        "OrchardCore.ResourceManagement",
    ]
)]
