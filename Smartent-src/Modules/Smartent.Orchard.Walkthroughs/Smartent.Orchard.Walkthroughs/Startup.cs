using Smartent.Orchard.Platform.ResourceManagement;
using Smartent.Orchard.Walkthroughs.Constants;
using Smartent.Orchard.Walkthroughs.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.Modules;
using OrchardCore.ResourceManagement;
using System;
using static Smartent.Orchard.Walkthroughs.Constants.ResourceNames;

namespace Smartent.Orchard.Walkthroughs;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IConfigureOptions<ResourceManagementOptions>, ResourceManagementOptionsConfiguration>();
        services.AddResourceFilter(builder => builder.Always()
            .RegisterStylesheet(Shepherd)
            .RegisterFootScript(Shepherd)
            .RegisterFootScript(ResourceNames.Walkthroughs));
        services.Configure<MvcOptions>(options => options.Filters.Add<WalkthroughsButtonFilter>());
    }

    public override void Configure(IApplicationBuilder app, IEndpointRouteBuilder routes, IServiceProvider serviceProvider) =>
        app.UseResourceFilters();
}
