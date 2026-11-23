using Smartent.Orchard.Platform.DependencyInjection;
using Smartent.Orchard.Platform.ResourceManagement;
using Smartent.Orchard.Theme.Media.Bridge.Deployment;
using Smartent.Orchard.Theme.Media.Bridge.Middlewares;
using Smartent.Orchard.Theme.Media.Bridge.Navigation;
using Smartent.Orchard.Theme.Media.Bridge.Permissions;
using Smartent.Orchard.Theme.Media.Bridge.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Deployment;
using OrchardCore.DisplayManagement;
using OrchardCore.Environment.Extensions;
using OrchardCore.Modules;
using OrchardCore.Navigation;
using OrchardCore.Recipes;
using OrchardCore.Security.Permissions;
using System;

namespace Smartent.Orchard.Theme.Media.Bridge;

public sealed class Startup : StartupBase
{
    // Make sure the middlewares run first, so we can block Media Theme template requests in time.
    public override int ConfigureOrder => int.MinValue;

    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddPermissionProvider<MediaThemeDeploymentPermissions>();
        services.AddNavigationProvider<MediaThemeDeploymentSettingsAdminMenu>();
        services.AddSingleton<IMediaThemeStateStore, MediaThemeStateStore>();
        services.Decorate<IExtensionManager, ExtensionManagerDecorator>();
        services.AddScoped<IShapeBindingResolver, MediaTemplatesShapeBindingResolver>();
        services.AddScoped<IMediaThemeManager, MediaThemeManager>();
        services.AddRecipeExecutionStep<MediaThemeStep>();
        services.AddDeployment<MediaThemeDeploymentSource, MediaThemeDeploymentStep, MediaThemeDeploymentStepDriver>();
        services.AddScoped<IAuthorizationHandler, ManageMediaThemeFolderAuthorizationHandler>();
        services.AddScoped<IMediaThemeCachingService, MediaThemeCachingService>();
        services.AddOrchardServices();
        services.Decorate<IFileVersionProvider, FileVersionProviderDecorator>();
        services.AddScoped<IResourceFilterThemeResolver, MediaThemeResourceFilterThemeResolver>();
        services.AddLiquidParserBlock<MediaThemeResourceLiquidParserBlock>("mediathemeresources");
    }

    public override void Configure(IApplicationBuilder app, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
    {
        app.UseMiddleware<MediaThemeAssetUrlRewritingMiddleware>();
        app.UseMiddleware<BlockMediaThemeTemplateDirectAccessMiddleware>();
    }
}
