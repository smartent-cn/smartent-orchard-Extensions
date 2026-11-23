using Smartent.Orchard.ContentEditors.Constants;
using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Smartent Orchard Content Editors",
    Author = "Smartent",
    Version = "0.0.1",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules"
)]

[assembly: Feature(
    Id = FeatureIds.AsyncEditor,
    Name = "Smartent Async Editor",
    Description = "Managing advanced content editing processes based on editor groups and asynchronous operations.",
    Category = "Content",
    Dependencies =
    [
        Smartent.Orchard.VueJs.Resources.Constants.FeatureIds.Area,
        "OrchardCore.ContentFields",
    ]
)]
