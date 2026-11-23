using Fluid;
using Smartent.Orchard.Extensions.Cms.Extensions.Widgets.Drivers;
using Smartent.Orchard.Extensions.Cms.Extensions.Widgets.Liquid;
using Smartent.Orchard.Extensions.Cms.Extensions.Widgets.Models;
using Smartent.Orchard.Platform.Liquid;
using Smartent.Orchard.Platform.TagHelpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Data.Migration;
using OrchardCore.DisplayManagement.Handlers;
using OrchardCore.Liquid;
using OrchardCore.Modules;
using OrchardCore.Navigation;
using OrchardCore.Rules;
using System;

namespace Smartent.Orchard.Extensions.Cms.Extensions.Widgets;

[Feature(FeatureIds.Widgets)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddDataMigration<Migrations>();

        services
            .AddScoped<IDisplayDriver<Condition>, MvcConditionDisplayDriver>()
            .AddRuleCondition<MvcCondition, MvcConditionEvaluatorDriver, ConditionFactory<MvcCondition>>()
            .AddScoped(sp => (IContentDisplayDriver)sp.GetRequiredService<MvcConditionEvaluatorDriver>());

        services.AddTagHelpers<EditorFieldSetTagHelper>();

        services.AddContentPart<ContentItemWidget>()
            .UseDetailOnlyDriver();

        services.AddScoped<ILiquidContentDisplayService, LiquidContentDisplayService>();
        services.AddLiquidFilter<MenuWidgetLiquidFilter>("menu");
        services.Configure<TemplateOptions>(option => option.MemberAccessStrategy.Register<MenuItem>());
    }

    public override void Configure(IApplicationBuilder app, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
    {
        // No need for anything here yet.
    }
}
