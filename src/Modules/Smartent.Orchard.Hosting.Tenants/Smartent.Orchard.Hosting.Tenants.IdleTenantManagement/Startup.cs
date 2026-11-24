using Smartent.Orchard.Hosting.Tenants.IdleTenantManagement.Constants;
using Smartent.Orchard.Hosting.Tenants.IdleTenantManagement.Middlewares;
using Smartent.Orchard.Hosting.Tenants.IdleTenantManagement.Models;
using Smartent.Orchard.Hosting.Tenants.IdleTenantManagement.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.BackgroundTasks;
using OrchardCore.Environment.Shell.Configuration;
using OrchardCore.Modules;
using System;

namespace Smartent.Orchard.Hosting.Tenants.IdleTenantManagement;

[Feature(FeatureNames.ShutDownIdleTenants)]
public sealed class ShutDownIdleTenantsStartup : StartupBase
{
    private readonly IShellConfiguration _shellConfiguration;

    public ShutDownIdleTenantsStartup(IShellConfiguration shellConfiguration) =>
        _shellConfiguration = shellConfiguration;

    public override void Configure(
        IApplicationBuilder app,
        IEndpointRouteBuilder routes,
        IServiceProvider serviceProvider) =>
            app.UseMiddleware<IdleTimeProviderMiddleware>();

    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<ILastActiveTimeAccessor, LastActiveTimeAccessor>();
        services.AddScoped<IIdleShutdownService, IdleShutdownService>();
        services.AddSingleton<IBackgroundTask, IdleShutdownTask>();

        // Idle Minutes Settings
        services.Configure<IdleShutdownOptions>(options =>
            _shellConfiguration
                .GetSection("Smartent_Orchard_Hosting_Tenants_IdleTenantManagement:IdleShutdownOptions")
                .Bind(options));
    }
}
