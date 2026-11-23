using Smartent.Orchard.EmailClient.Samples.Services;
using Smartent.Orchard.EmailClient.Services;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace Smartent.Orchard.EmailClient.Samples;

public class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services) =>
        services.AddScoped<IEmailSyncEventHandler, SampleEmailSyncEventHandler>();
}
