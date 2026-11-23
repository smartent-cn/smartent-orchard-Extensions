using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.AuditTrail.Constants.FeatureIds;

[assembly: Module(
    Name = "Smartent Orchard Audit Trail Extensions",
    Author = "Smartent",
    Version = "0.0.1",
    Description = "Module with additional functionality to the stock Audit Trail.",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules"
)]

[assembly: Feature(
    Id = Default,
    Name = "Smartent Orchard Audit Trail Extensions",
    Category = "Content",
    Description = "Module with additional functionality to the stock Audit Trail.",
    Dependencies =
    [
        "OrchardCore.Contents",
        "OrchardCore.AuditTrail",
    ]
)]
