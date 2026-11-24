using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.UIKit.FeatureIds;

[assembly: Module(
    Name = "Smartent Orchard UI Kit",
    Author = "Smartent",
    Version = "0.0.1",
    Description = "Module for reusable shapes containing text editors, dropdown editors, and potentially more complex editors.",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions"
)]

[assembly: Feature(
    Id = Base,
    Name = "Smartent Orchard UI Kit",
    Category = "Development",
    Description = "Module for reusable shapes containing text editors, dropdown editors, and potentially more complex editors."
)]

[assembly: Feature(
    Id = Showcase,
    Name = "Smartent Orchard UI Kit - Showcase page",
    Category = "Development",
    Description = "You can reach the showcase page under /UIKitShowcase",
    Dependencies = ["Smartent.Orchard.UIKit"]
)]
