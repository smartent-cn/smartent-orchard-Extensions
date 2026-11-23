using Smartent.Orchard.Platform.ResourceManagement;
using Smartent.Test.UI.AdminTheme.Constants;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using System;

namespace Smartent.Test.UI.AdminTheme;

public class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddResourceManagementConfiguration<ResourceManagementOptionsConfiguration>();
        services.AddResourceFilter(
            builder => builder
                .Always()
                .RegisterStylesheet(ResourceNames.General),
            FeatureIds.AdminTheme);
    }

    public override void Configure(IApplicationBuilder app, IEndpointRouteBuilder routes, IServiceProvider serviceProvider) =>
        app.UseResourceFilters();
}
