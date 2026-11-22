using Smartent.Orchard.Platform.ResourceManagement;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using System;

namespace Smartent.Orchard.Extensions.Cms.Extensions.TrumbowygBlogPosts;

[Feature(FeatureIds.TrumbowygBlogPosts)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services) =>
        services.AddResourceFilter<ResourceFilters>();

    public override void Configure(IApplicationBuilder app, IEndpointRouteBuilder routes, IServiceProvider serviceProvider) =>
        app.UseResourceFilters();
}
