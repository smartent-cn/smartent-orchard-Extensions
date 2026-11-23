using Smartent.Orchard.Marketing.Constants;
using Smartent.Orchard.Marketing.Filters;
using Smartent.Orchard.Marketing.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace Smartent.Orchard.Marketing;

[Feature(FeatureIds.Base)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IClientSideTrackingMarkupService, ClientSideTrackingMarkupService>();
        services.Configure<MvcOptions>(options => options.Filters.Add<ClientSideTrackingInjectingFilter>());
    }
}
