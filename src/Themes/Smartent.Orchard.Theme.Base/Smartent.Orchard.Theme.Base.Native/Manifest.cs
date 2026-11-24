using OrchardCore.DisplayManagement.Manifest;
using static Smartent.Orchard.Theme.Base.Core.Constants.FeatureIds;

[assembly: Theme(
    Name = "Smartent Orchard Theme Base - Native CSS",
    Author = "Smartent",
    Version = "0.0.1",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions",
    Description = "The base frontend theme for shared code that is not specific to any particular project's theme.",
    Dependencies = [Core],
    BaseTheme = Core
)]
