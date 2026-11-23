using Smartent.Orchard.Theme.Base.Core.Services;
using Smartent.Orchard.Theme.Base.Native.Constants;
using Smartent.Orchard.Theme.Base.Native.Services;
using Smartent.Orchard.Platform.ResourceManagement;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace Smartent.Orchard.Theme.Base.Native;

public class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddResourceFilter(
            builder => builder
                .Always()
                .RegisterBaseThemeCoreResources()
                .RegisterStylesheet(ResourceNames.General)
                .RegisterHeadScript(ResourceNames.GridBreakpoints),
            FeatureIds.Native);

        services.AddResourceManagementConfiguration<ResourceManagementOptionsConfiguration>();

        services.AddScoped<IBodyClassProvider, BreakpointBodyClassProvider>();
    }
}
