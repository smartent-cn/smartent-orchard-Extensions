using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.LoginAsAnybody.Constants.FeatureIds;

[assembly: Module(
    Name = "Smartent Orchard Login as Anybody",
    Author = "Smartent",
    Version = "0.0.1",
    Description = "Module that allows administrator users to log in as any user.",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules"
)]

[assembly: Feature(
    Id = LoginAsAnybody,
    Name = "Smartent Orchard Login as Anybody",
    Category = "Security",
    Description = "Module that allows administrator users to log in as any user.",
    Dependencies =
    [
        "OrchardCore.Users",
    ]
)]
