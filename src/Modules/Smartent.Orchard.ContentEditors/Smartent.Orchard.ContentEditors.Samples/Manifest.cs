using Smartent.Orchard.ContentEditors.Constants;
using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Smartent Orchard Content Editors - Samples",
    Author = "Smartent",
    Version = "0.0.1",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions",
    Description = "Samples for Smartent Orchard Content Editors.",
    Category = "Development",
    Dependencies = [FeatureIds.AsyncEditor]
)]
