using Smartent.Orchard.Marketing.Constants;
using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Smartent Orchard Marketing",
    Author = "Smartent",
    Version = "0.0.1",
    Description = "Contains the common abstractions and services used by the other marketing modules",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions"
)]

[assembly: Feature(
    Id = FeatureIds.Base,
    Name = "Smartent Orchard Marketing",
    Category = "Marketing",
    Description = "Contains the common abstractions and services used by the other marketing modules"
)]
