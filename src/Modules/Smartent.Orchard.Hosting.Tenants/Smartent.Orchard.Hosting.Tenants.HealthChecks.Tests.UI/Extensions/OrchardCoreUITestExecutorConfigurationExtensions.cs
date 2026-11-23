using Smartent.Orchard.Hosting.Tenants.HealthChecks.Constants;
using Smartent.Test.UI.Services;
using System.Threading.Tasks;

namespace Smartent.Orchard.Hosting.Tenants.HealthChecks.Tests.UI.Extensions;

public static class OrchardCoreUITestExecutorConfigurationExtensions
{
    /// <summary>
    /// Configures UI tests for the "Smartent Orchard Hosting - Tenants Health Checks" feature.
    /// </summary>
    public static void ConfigureTenantHealthCheckTests(this OrchardCoreUITestExecutorConfiguration configuration)
    {
        configuration.ResponseLogFilters["Ignore expected non-ok responses from ~/health/live"] = args =>
            !args.Response.Url.Contains("/health/live");

        configuration.OrchardCoreConfiguration.BeforeAppStart += (_, argumentsBuilder) =>
        {
            argumentsBuilder.AddWithValue(ConfigurationKeys.IsEnabled, value: true);
            return Task.CompletedTask;
        };
    }
}
