using Smartent.Orchard.Theme.Base.Constants;
using Smartent.Orchard.Theme.Base.Services;
using Smartent.Orchard.Platform.ResourceManagement;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.Modules;
using OrchardCore.ResourceManagement;

namespace Smartent.Orchard.Theme.Base;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IConfigureOptions<ResourceManagementOptions>, ResourceManagementOptionsConfiguration>();
        services.AddResourceFilter(
            builder => builder
                .Always()
                .RegisterBaseThemeCoreResources()
                .RegisterStylesheet(ResourceNames.Site)
                .RegisterHeadScript(ResourceNames.Helpers),
            FeatureIds.BaseTheme);
        services.Decorate<IResourceManager, ResourceManagerDecorator>();
    }
}
