using Smartent.Orchard.UIKit.Handlers;
using Smartent.Orchard.UIKit.Migrations;
using Smartent.Orchard.UIKit.Models;
using Smartent.Orchard.UIKit.Showcase.Services;
using Smartent.Orchard.UIKit.TagHelpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.ContentManagement;
using OrchardCore.Modules;
using OrchardCore.Navigation;
using OrchardCore.ResourceManagement;

namespace Smartent.Orchard.UIKit;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IConfigureOptions<ResourceManagementOptions>, ResourceManagementOptionsConfiguration>();
        services.AddTagHelpers<BootstrapSplitButtonTagHelper>();

        services.AddContentPart<HtmlTitlePart>()
            .WithMigration<HtmlTitlePartMigrations>()
            .AddHandler<HtmlTitlePartHandler>();
    }
}

[Feature(FeatureIds.Showcase)]
public sealed class ShowcaseStartup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services) =>
        services.AddNavigationProvider<Navigation>();
}
