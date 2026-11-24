using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.Hosting.Tenants.Management.Constants.FeatureNames;

[assembly: Module(
    Name = "Smartent Orchard Hosting - Tenants Management",
    Author = "Smartent",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions",
    Version = "0.0.1",
    Description = "Manage restrictions on tenant creation."
)]

[assembly: Feature(
    Id = ForbiddenTenantNames,
    Name = "Smartent Orchard Hosting - Tenants Management Forbidden Tenant Names",
    Description = "Ability to configure hostnames that aren't allowed during tenant creation.",
    Category = "Hosting",
    DefaultTenantOnly = true,
    Dependencies = ["OrchardCore.Tenants"]
)]

[assembly: Feature(
    Id = HideRecipesFromSetup,
    Name = "Smartent Orchard Hosting - Tenants Management Hide Recipes From Setup",
    Description = "Adds the ability to hide recipes from the setup screen based on configurable tags.",
    Category = "Hosting",
    Dependencies = ["OrchardCore.Setup"]
)]

[assembly: Feature(
    Id = ShellSettingsEditor,
    Name = "Smartent Orchard Hosting - Tenants Management Shell Settings Editor",
    Description = "Adds a shell settings editor to the tenant editor page.",
    Category = "Hosting",
    DefaultTenantOnly = true,
    Dependencies = ["OrchardCore.Tenants"]
)]
