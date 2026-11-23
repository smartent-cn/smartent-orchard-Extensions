using OrchardCore.DisplayManagement.Manifest;
using static Smartent.Orchard.Theme.Media.Bridge.Constants.FeatureNames;

[assembly: Theme(
    Name = "Smartent Orchard Hosting - Media Theme - Test Theme",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules",
    Version = "0.0.1",
    Description = "A theme only used for testing that demonstrates the local development version of a Media Theme.",
    Dependencies = [MediaThemeBridge]
)]
