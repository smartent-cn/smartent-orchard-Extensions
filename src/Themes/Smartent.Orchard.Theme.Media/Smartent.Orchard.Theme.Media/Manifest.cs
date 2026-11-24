using OrchardCore.DisplayManagement.Manifest;
using static Smartent.Orchard.Theme.Media.Bridge.Constants.FeatureNames;

[assembly: Theme(
    Name = "Smartent Orchard Hosting - Media Theme",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions",
    Version = "0.0.1",
    Description = "Allows developers to host their themes in the Orchard Core Media Library, including templates and assets.",
    Category = "Hosting",
    Dependencies = [MediaThemeBridge]
)]
