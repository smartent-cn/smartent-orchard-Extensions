using Lombiq.Tests.UI.Services;
using System.Threading.Tasks;

namespace Smartent.Orchard.Hosting.Tenants.EmailQuotaManagement.Tests.UI.Extensions;

public static class EmailQuotaManagementExtensions
{
    public static void SetEmailQuotaManagementOptionsForUITest(
        this OrchardCoreUITestExecutorConfiguration configuration,
        long maximumEmails)
    {
        configuration.OrchardCoreConfiguration.BeforeAppStart +=
            (_, argumentsBuilder) =>
            {
                argumentsBuilder
                    .AddWithValue(
                        "OrchardCore:Lombiq_Hosting_Tenants_EmailQuotaManagement:EmailQuotaPerMonth",
                        maximumEmails);

                return Task.CompletedTask;
            };

        configuration.UseSmtpService = true;
    }
}
