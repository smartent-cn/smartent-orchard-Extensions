using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.Privacy.Constants.FeatureNames;

[assembly: Module(
    Name = "Smartent Orchard Privacy",
    Author = "Smartent",
    Website = "https://gitee.com/smartent",
    Version = "0.0.1"
)]

[assembly: Feature(
    Id = Module,
    Name = "Smartent Orchard Privacy",
    Description = "Various data protection/privacy-related, GDPR-ready features.",
    Category = "Privacy"
)]

[assembly: Feature(
    Id = ConsentBanner,
    Name = "Smartent Orchard Privacy - Consent banner",
    Description = "Adds the ability to show a privacy consent banner.",
    Category = "Privacy",
    Dependencies = [Module, "OrchardCore.CustomSettings"]
)]

[assembly: Feature(
    Id = RegistrationConsent,
    Name = "Smartent Orchard Privacy - Registration consent",
    Description = "Adds a privacy consent checkbox to the registration form.",
    Category = "Privacy",
    Dependencies = [Module, "OrchardCore.CustomSettings", "OrchardCore.Users.Registration"]
)]

[assembly: Feature(
    Id = ExternalRegistrationConsent,
    Name = "Smartent Orchard Privacy - External Registration consent",
    Description = "Adds a privacy consent checkbox to the external registration form.",
    Category = "Privacy",
    Dependencies = [
        Module,
        RegistrationConsent,
        "OrchardCore.Users.ExternalAuthentication"
        ]
)]

[assembly: Feature(
    Id = FormConsent,
    Name = "Smartent Orchard Privacy - Form consent",
    Description = "Provides the Privacy Consent Checkbox widget that can be used on any form.",
    Category = "Privacy",
    Dependencies = [Module, "OrchardCore.CustomSettings", "OrchardCore.Forms"]
)]
