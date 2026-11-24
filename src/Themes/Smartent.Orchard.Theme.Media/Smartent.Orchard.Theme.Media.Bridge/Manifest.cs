using Smartent.Orchard.Extensions.Cms;
using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Smartent Orchard Hosting - Media Theme Bridge",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions",
    Version = "0.0.1",
    Description = "Provides the processing logic for the Media Theme.",
    Category = "Hosting",
    Dependencies = ["OrchardCore.Deployment", "OrchardCore.Media", FeatureIds.GoogleTag]
)]
