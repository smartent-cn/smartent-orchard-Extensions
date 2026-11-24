using Smartent.Orchard.Hosting.Tenants.EmailQuotaManagement.Constants;
using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Smartent Orchard Hosting - Tenants Email Quota Management",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions",
    Version = "0.0.1",
    Description = "Allows setting email quotas for tenants.",
    Category = "Hosting"
)]

[assembly: Feature(
    Id = FeatureNames.EmailQuotaManagement,
    Name = "Smartent Orchard Hosting - Tenants Email Quota Management",
    Category = "Hosting",
    IsAlwaysEnabled = true,
    Dependencies =
    [
        "Smartent.Orchard.Extensions.Cms.Emails",
    ]
)]
