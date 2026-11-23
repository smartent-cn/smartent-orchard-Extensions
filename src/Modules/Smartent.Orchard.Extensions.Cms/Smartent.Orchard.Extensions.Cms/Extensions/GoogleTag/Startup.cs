using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace Smartent.Orchard.Extensions.Cms.Extensions.GoogleTag;

[Feature(FeatureIds.GoogleTag)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddTagHelpers<GoogleTagTagHelper>();
        services.AddLiquidParserTag<GoogleTagLiquidParserTag>("google_tag");
    }
}
