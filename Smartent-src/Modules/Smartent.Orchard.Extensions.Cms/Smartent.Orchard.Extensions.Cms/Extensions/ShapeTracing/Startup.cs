using Microsoft.Extensions.DependencyInjection;
using OrchardCore.DisplayManagement.Implementation;
using OrchardCore.Modules;

namespace Smartent.Orchard.Extensions.Cms.Extensions.ShapeTracing;

[Feature(FeatureIds.ShapeTracing)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services) =>
        services.AddScoped<IShapeDisplayEvents, ShapeTracingShapeEvents>();
}
