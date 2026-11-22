using Smartent.Orchard.Privacy.Samples.Navigation;
using Smartent.Orchard.Privacy.Samples.Scripting;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Navigation;
using OrchardCore.Scripting;

namespace Smartent.Orchard.Privacy.Samples;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IGlobalMethodProvider, WorkflowHelperMethodProvider>();

        services.AddNavigationProvider<PrivacySamplesNavigationProvider>();
    }
}
