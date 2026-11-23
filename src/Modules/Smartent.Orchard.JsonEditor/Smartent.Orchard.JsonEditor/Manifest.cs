using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.JsonEditor.Constants.FeatureIds;

[assembly: Module(
    Name = "Smartent Orchard JSON Editor",
    Author = "Smartent",
    Version = "0.0.1",
    Description = "Module for displaying a JSON Editor like on jsoneditoronline.org.",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules"
)]

[assembly: Feature(
    Id = Default,
    Name = "Smartent Orchard JSON Editor",
    Category = "Content",
    Description = "Module for displaying a JSON Editor like on jsoneditoronline.org.",
    Dependencies =
    [
        "OrchardCore.Contents",
        "OrchardCore.ResourceManagement",
    ]
)]

[assembly: Feature(
    Id = ContentEditor,
    Name = "Smartent JSON Content Editor",
    Category = "Content",
    Description = "Adds an actions menu item to the content item list for editing them as JSON.",
    Dependencies =
    [
        Default,
    ]
)]
