using Fluid;
using Fluid.Values;
using Smartent.Orchard.Theme.Base.Core.Liquid;
using Smartent.Orchard.Theme.Base.Core.Migrations;
using Smartent.Orchard.Theme.Base.Core.Navigation;
using Smartent.Orchard.Theme.Base.Core.Permissions;
using Smartent.Orchard.Theme.Base.Core.Services;
using Smartent.Core.AspNet.Extensions;
using Smartent.Orchard.Platform.Liquid;
using Smartent.Orchard.Platform.ResourceManagement;
using Smartent.Orchard.Platform.Shapes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Data.Migration;
using OrchardCore.Liquid;
using OrchardCore.Modules;
using OrchardCore.Navigation;
using OrchardCore.Security.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartent.Orchard.Theme.Base.Core;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<ICssClassHolder, CssClassHolder>();
        services.AddAsyncResultFilter<MainMenuWidgetFilter>();

        services.AddDataMigration<LayoutInjectionMigrations>();
        services.AddDataMigration<RecipeMigrations>();

        services.AddResourceFilter<IconResourceFilter>();

        PerTenantShapeTableManager.ReplaceDefaultShapeTableManager(services);
        services.AddNavigationProvider<MainMenuNavigationProvider>();

        services.AddPermissionProvider<BaseThemeSettingsPermissions>();
        services.AddNavigationProvider<BaseThemeSettingsAdminMenu>();

        services.AddResourceManagementConfiguration<ResourceManagementOptionsConfiguration>();

        services.AddDisplayChildrenLiquidFilter();
        services.AddLiquidFilter<ZoneClassesLiquidFilter>("zone-classes");
        services.AddLiquidFilter<DisplayZonesLiquidParserTag>("display-zones");
        services.AddLiquidParserTag<DisplayZonesLiquidParserTag>("display-zones");

        services.Configure<TemplateOptions>(options =>
        {
            options.MemberAccessStrategy.Register<CssClassHolder>();
            options.Scope.SetValue("Theme", new ObjectValue(new LiquidBaseThemeAccessor()));

            options.RegisterLiquidPropertyAccessor<LiquidBaseThemeAccessor, IEnumerable<string>>("ZoneCss", (zone, context) =>
            {
                var classHolder = context.Services.GetRequiredService<ICssClassHolder>();
                return Task.FromResult(classHolder.GetZoneClasses(zone).AsEnumerable());
            });

            options.RegisterLiquidPropertyAccessor<LiquidBaseThemeAccessor, string>("BodyClasses", async (_, context) =>
            {
                var providers = context.Services.GetServices<IBodyClassProvider>();
                var classes = (await providers.AwaitEachAsync(provider => provider.GetClassesAsync(context)))
                    .SelectMany(results => results)
                    .Distinct();

                return string.Join(' ', classes);
            });
        });
    }

    public override void Configure(IApplicationBuilder app, IEndpointRouteBuilder routes, IServiceProvider serviceProvider) =>
        app.UseResourceFilters();
}
