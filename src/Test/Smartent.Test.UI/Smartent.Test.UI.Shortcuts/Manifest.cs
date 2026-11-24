using OrchardCore.Modules.Manifest;
using OrchardCore.Users;
using static Smartent.Test.UI.Shortcuts.ShortcutsFeatureIds;

[assembly: Module(
    Name = "Shortcuts - Smartent UI Testing",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions",
    Version = "0.0.1"
)]

[assembly: Feature(
    Id = Default,
    Name = "Smartent UI Testing - Shortcuts",
    Category = "Development",
    Description = DescriptionUiTestWarning + "Provides shortcuts for common operations that UI tests might want to do or check.",
    Dependencies =
    [
        "OrchardCore.ContentManagement",
        "OrchardCore.ContentTypes",
        "OrchardCore.DisplayManagement",
        "OrchardCore.Roles",
        UserConstants.Features.Users,
    ]
)]

[assembly: Feature(
    Id = FeatureToggleTestBench,
    Name = "Feature Toggle Test Bench - Shortcuts - Smartent UI Testing",
    Category = "Development",
    Description = "WARNING: Don't enable this feature by hand. Can be turned on and off to test if feature state changes work."
)]

[assembly: Feature(
    Id = MediaCachePurge,
    Name = "Media Cache Purge - Shortcuts - Smartent UI Testing",
    Category = "Development",
    Description = DescriptionUiTestWarning + "Provides shortcut for Media Cache Purge.",
    Dependencies =
    [
        "OrchardCore.Media.Cache",
    ]
)]

[assembly: Feature(
    Id = Workflows,
    Name = "Workflows - Shortcuts - Smartent UI Testing",
    Category = "Development",
    Description = DescriptionUiTestWarning + "Provides shortcut for Workflows.",
    Dependencies =
    [
        "OrchardCore.Workflows.Http",
    ]
)]

[assembly: Feature(
    Id = OpenApi,
    Name = "OpenAPI - Shortcuts - Smartent UI Testing",
    Category = "Development",
    Description = DescriptionUiTestWarning + "Provides an endpoint to generate a JSON OpenAPI definition for " +
                  "the web APIs available in the app. Used in security scanning."
)]

[assembly: Feature(
    Id = ShiftTime,
    Name = "Shift Time - Shortcuts - Smartent UI Testing",
    Category = "Development",
    Description = DescriptionUiTestWarning + "Adds a custom IClock implementation where the clock can be shifted by " +
                  "a specified value."
)]
