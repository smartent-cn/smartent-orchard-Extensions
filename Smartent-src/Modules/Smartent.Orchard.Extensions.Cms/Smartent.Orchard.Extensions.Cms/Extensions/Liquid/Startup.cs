using Smartent.Orchard.Extensions.Cms.Extensions.Liquid.Services;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Liquid;
using OrchardCore.Modules;

namespace Smartent.Orchard.Extensions.Cms.Extensions.Liquid;

[Feature(FeatureIds.Liquid)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddLiquidParserBlock<IfNotEmptyParserBlock>("ifnotempty");
        services.AddLiquidFilter<IsNotEmptyFilter>("is_not_empty");
        services.AddLiquidParserTag<AssignArrayParserBlock>("assign_array");
        services.AddLiquidFilter<ShapesBuildDisplayFilter>("shapes_build_display");
        services.AddLiquidFilter<ShapesRenderFilter>("shapes_render");
        services.AddLiquidFilter<ShuffleFilter>("shuffle");
    }
}
