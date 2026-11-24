using Smartent.Orchard.Marketing.UrlShortener.Constants;
using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Smartent Orchard Marketing - URL Shortener",
    Author = "Smartent",
    Version = "0.0.1",
    Description = "Create short URLs that redirect to long URLs.",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions"
)]

[assembly: Feature(
    Id = FeatureIds.Base,
    Name = "Smartent Orchard Marketing - URL Shortener",
    Category = "Marketing",
    Description = "Adds a Short URL content type for managing short redirects.",
    Dependencies = [
        Smartent.Orchard.Marketing.Constants.FeatureIds.Base,
        "OrchardCore.ContentFields"
    ]
)]
