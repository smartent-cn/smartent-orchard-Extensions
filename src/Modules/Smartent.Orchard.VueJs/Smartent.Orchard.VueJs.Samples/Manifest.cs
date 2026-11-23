using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Smartent Orchard Vue.js - Samples",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules",
    Version = "0.0.1",
    Description = "Samples for Smartent Orchard Vue.js.",
    Category = "Vue.js",
    Dependencies =
    [
        Smartent.Orchard.VueJs.Constants.FeatureIds.Area,
        "OrchardCore.ContentFields",
    ]
)]
