using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Lombiq Privacy - Samples",
    Author = "Lombiq Technologies",
    Website = "https://github.com/Lombiq/Orchard-Privacy",
    Version = "0.0.1",
    Description = "Samples for Lombiq Privacy.",
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
