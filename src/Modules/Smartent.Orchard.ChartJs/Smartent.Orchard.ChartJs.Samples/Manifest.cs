using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Smartent Orchard Chart.js - Samples",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules",
    Version = "0.0.1",
    Description = "Samples for Smartent Orchard Chart.js.",
    Category = "Chart.js",
    Dependencies =
    [
        "OrchardCore.Alias",
        "OrchardCore.Autoroute",
        "OrchardCore.ContentFields",
        "OrchardCore.ContentFields.Indexing.SQL",
        "OrchardCore.Taxonomies",
        "OrchardCore.Title",
        Smartent.Orchard.ChartJs.Constants.FeatureIds.Area,
    ]
)]
