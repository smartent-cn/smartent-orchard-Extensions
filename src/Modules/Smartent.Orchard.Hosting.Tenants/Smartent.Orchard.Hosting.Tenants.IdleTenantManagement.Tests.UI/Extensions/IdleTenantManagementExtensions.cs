using Smartent.Test.UI.Services;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Smartent.Orchard.Hosting.Tenants.IdleTenantManagement.Tests.UI.Extensions;

public static class IdleTenantManagementExtensions
{
    public static void ConfigureIdleTenantManagementTestSettings(this OrchardCoreUITestExecutorConfiguration configuration)
    {
        configuration.OrchardCoreConfiguration.BeforeAppStart +=
            (_, argumentsBuilder) =>
            {
                argumentsBuilder
                    .AddWithValue(
                        "OrchardCore:Lombiq_Hosting_Tenants_IdleTenantManagement:IdleShutdownOptions:MaxIdleMinutes",
                        "1")
                    .AddWithValue(
                        "Logging:LogLevel:Smartent.Orchard.Hosting.Tenants.IdleTenantManagement.Services.IdleShutdownService",
                        "Information")
                    .AddWithValue(
                        "OrchardCore:OrchardCore_BackgroundService:PollingTime",
                        "00:00:05")
                    .AddWithValue(
                        "OrchardCore:OrchardCore_BackgroundService:MinimumIdleTime",
                        "00:00:01");

                return Task.CompletedTask;
            };

        configuration.OrchardCoreConfiguration.AfterFakeLoggingConfiguration =
            (_, fakeLogCollectorOptions) => fakeLogCollectorOptions.FilteredLevels.Add(LogLevel.Information);
    }
}
