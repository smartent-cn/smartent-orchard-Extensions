using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace Smartent.Orchard.Extensions.Cms.Extensions.SimpleIcons;

[Feature(FeatureIds.SimpleIcons)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services) =>
        services.AddTagHelpers<SimpleIconTagHelper>();
}
