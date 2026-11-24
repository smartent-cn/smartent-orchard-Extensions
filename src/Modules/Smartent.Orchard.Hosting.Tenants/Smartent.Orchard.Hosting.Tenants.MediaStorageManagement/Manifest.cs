using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.Hosting.Tenants.MediaStorageManagement.Constants.FeatureNames;

[assembly: Module(
    Name = "Smartent Orchard Hosting - Tenants Media Storage Management",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions",
    Version = "0.0.1",
    Description = "Ability to configure storage quota for tenants."
)]

[assembly: Feature(
    Id = MediaStorageManagement,
    Name = "Smartent Orchard Hosting - Tenants Media Storage Management Quota Management",
    Description = "Ability to configure storage quota for tenants.",
    Category = "Hosting",
    IsAlwaysEnabled = true,
    Dependencies =
    [
        "OrchardCore.Media",
        "OrchardCore.DisplayManagement",
        "OrchardCore.ResourceManagement",
    ]
)]
