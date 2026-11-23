using Smartent.Orchard.Hosting.Tenants.Maintenance.Services;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.BackgroundJobs;
using System.Threading.Tasks;

namespace Smartent.Orchard.Hosting.Tenants.Maintenance.Helpers;

public static class StaggeredTenantWakeUpHelper
{
    public static Task ExecuteStaggeredTenantWakeUpAsync(string jobName, bool newVersion = false) =>
        HttpBackgroundJob.ExecuteAfterEndOfRequestAsync(jobName, async scope =>
        {
            var staggeredTenantWakeUpService = scope.ServiceProvider.GetRequiredService<IStaggeredTenantWakeUpService>();
            await staggeredTenantWakeUpService.RunStaggeredTenantWakeUpAsync(newVersion);
        });
}
