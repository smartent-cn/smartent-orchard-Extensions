using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.ChartJs.Constants.FeatureIds;

[assembly: Module(
    Name = "Smartent Orchard Chart.js",
    Author = "Smartent",
    Version = "0.0.1",
    Description = "Module for displaying data using Chart.js.",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules"
)]

[assembly: Feature(
    Id = Default,
    Name = "Smartent Orchard Chart.js",
    Category = "Content",
    Description = "Module for displaying data using Chart.js.",
    Dependencies =
    [
        "OrchardCore.Contents",
    ]
)]
