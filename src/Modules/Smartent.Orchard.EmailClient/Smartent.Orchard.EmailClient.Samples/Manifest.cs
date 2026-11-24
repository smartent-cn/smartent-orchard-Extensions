using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.EmailClient.Constants.FeatureIds;

[assembly: Module(
    Name = "Smartent Orchard Email Client - Samples",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions",
    Version = "0.0.1",
    Description = "Samples for Smartent Orchard Email Client.",
    Category = "Email",
    Dependencies = [
        Imap,
        EmailSync
    ]
)]
