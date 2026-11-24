namespace Smartent.Orchard.Hosting.Tenants.HealthChecks.Constants;

public static class ConfigurationKeys
{
    public const string ConfigurationKey = "OrchardCore:Smartent_Orchard_Hosting_Tenants_HealthChecks";
    public const string IsEnabled = $"{ConfigurationKey}:{nameof(IsEnabled)}";
}
