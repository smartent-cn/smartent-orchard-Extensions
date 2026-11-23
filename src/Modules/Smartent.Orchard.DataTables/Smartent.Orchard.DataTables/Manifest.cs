using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.DataTables.Constants.FeatureIds;

[assembly: Module(
    Name = "Smartent Orchard Data Tables",
    Author = "Smartent",
    Version = "0.0.1",
    Description = "Module for displaying data using jQuery Data Tables.",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules"
)]

[assembly: Feature(
    Id = DataTables,
    Name = "Smartent Orchard Data Tables",
    Category = "Content",
    Description = "Displays data using jQuery Data Tables.",
    Dependencies =
    [
        "OrchardCore.Contents",
        "OrchardCore.ResourceManagement",
        "OrchardCore.Queries",
    ]
)]
