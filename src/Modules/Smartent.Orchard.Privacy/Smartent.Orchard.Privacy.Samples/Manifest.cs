using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Smartent Orchard Privacy - Samples",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules",
    Version = "0.0.1",
    Description = "Samples for Smartent Orchard Privacy.",
    Category = "Privacy",
    Dependencies =
    [
        Smartent.Orchard.Extensions.Cms.FeatureIds.ContentTypes,
        Smartent.Orchard.Privacy.Constants.FeatureNames.ConsentBanner,
        Smartent.Orchard.Privacy.Constants.FeatureNames.FormConsent,
        Smartent.Orchard.Privacy.Constants.FeatureNames.RegistrationConsent,
        "OrchardCore.ContentFields",
        "OrchardCore.Workflows.Http",
    ]
)]
