using Smartent.Orchard.Marketing.UrlShortener.Constants;
using Smartent.Orchard.Marketing.UrlShortener.Drivers;
using Smartent.Orchard.Marketing.UrlShortener.Events;
using Smartent.Orchard.Marketing.UrlShortener.Handlers;
using Smartent.Orchard.Marketing.UrlShortener.Indexes;
using Smartent.Orchard.Marketing.UrlShortener.Migrations;
using Smartent.Orchard.Marketing.UrlShortener.Models;
using Smartent.Orchard.Marketing.UrlShortener.Navigation;
using Smartent.Orchard.Marketing.UrlShortener.Services;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Data;
using OrchardCore.Modules;
using OrchardCore.Navigation;

namespace Smartent.Orchard.Marketing.UrlShortener;

[Feature(FeatureIds.Base)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddContentPart<UtmPart>();
        services.AddContentPart<ShortUrlPart>()
            .AddHandler<ShortUrlPartHandler>()
            .UseDisplayDriver<ShortUrlPartDisplayDriver>()
            .WithMigration<ShortUrlMigration>();

        services.AddIndexProvider<ShortUrlPartIndexProvider>();
        services.AddScoped<IShortUrlRedirectEventHandler, MarketingShortUrlRedirectEventHandler>();
        services.AddScoped<IUrlShorteningService, UrlShorteningService>();
        services.AddScoped<INavigationProvider, UrlShortenerAdminMenu>();
    }
}
