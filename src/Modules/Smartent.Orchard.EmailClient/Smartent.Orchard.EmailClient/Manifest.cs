using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.EmailClient.Constants.FeatureIds;

[assembly: Module(
    Name = "Smartent Orchard Email Client",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-training-demo-modules",
    Version = "0.0.1"
)]

[assembly: Feature(
    Id = Default,
    Name = "Smartent Orchard Email Client - Base",
    Category = "Email",
    Description = "Base functionality for the email client such as content types. Should be used along with a " +
        "specific email provider feature (e.g., IMAP).",
    EnabledByDependencyOnly = true
)]

[assembly: Feature(
    Id = Imap,
    Name = "Smartent Orchard Email Client - IMAP",
    Category = "Email",
    Description = "IMAP email provider for the email client.",
    Dependencies =
    [
        Default,
    ]
)]

[assembly: Feature(
    Id = EmailSync,
    Name = "Smartent Orchard Email Client - Email Sync",
    Category = "Email",
    Description = "Syncs emails from an email provider periodically.",
    Dependencies =
    [
        Default,
    ]
)]
