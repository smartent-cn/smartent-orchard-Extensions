using OrchardCore.DisplayManagement.Manifest;
using static Smartent.Orchard.Theme.Base.Core.Constants.FeatureIds;

[assembly: Theme(
    Name = "Smartent Orchard Theme Base - Sass",
    Author = "Smartent",
    Version = "0.0.1",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules",
    Description = "The base frontend theme for shared code that is not specific to a specific project's theme." +
      "Warning: themes using this as the base remove the stock Bootstrap resource. If you switch to a different " +
      "theme, please reload the tenant from Configuration → Tenants in the admin menu.",
    Dependencies = [Core],
    BaseTheme = Core
)]
