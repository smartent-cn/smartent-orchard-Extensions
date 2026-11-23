using OrchardCore.DisplayManagement.Manifest;
using OrchardCore.Modules.Manifest;

[assembly: Theme(
    Name = "Smartent UI Testing - Admin Theme",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules",
    Version = "0.0.1",
    Description = "Adjustments for the stock Orchard Core admin theme to make it more automation-friendly.",
    BaseTheme = "TheAdmin",
    Dependencies = ["OrchardCore.Themes", "TheAdmin"],
    Tags = [ManifestConstants.AdminTag])]
