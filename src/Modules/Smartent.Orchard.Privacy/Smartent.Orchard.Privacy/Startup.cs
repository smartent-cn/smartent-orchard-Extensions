using Smartent.Core.AspNet.Extensions;
using Smartent.Orchard.Privacy.Activities;
using Smartent.Orchard.Privacy.Constants;
using Smartent.Orchard.Privacy.Drivers;
using Smartent.Orchard.Privacy.Filters;
using Smartent.Orchard.Privacy.Handlers;
using Smartent.Orchard.Privacy.Migrations;
using Smartent.Orchard.Privacy.Models;
using Smartent.Orchard.Privacy.Navigation;
using Smartent.Orchard.Privacy.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Data.Migration;
using OrchardCore.DisplayManagement.Handlers;
using OrchardCore.Modules;
using OrchardCore.Navigation;
using OrchardCore.ResourceManagement;
using OrchardCore.Users.Events;
using OrchardCore.Users.Models;
using OrchardCore.Workflows.Helpers;
using System;
using System.Threading.Tasks;

namespace Smartent.Orchard.Privacy;

public sealed class Startup : StartupBase
{
    public override void Configure(
        IApplicationBuilder app,
        IEndpointRouteBuilder routes,
        IServiceProvider serviceProvider) =>
            app.UseCookiePolicy();

    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IPrivacyConsentService, PrivacyConsentService>();
        services.Configure<CookiePolicyOptions>(options =>
        {
            options.CheckConsentNeeded = context => IsConsentNeededAsync(context).GetAwaiter().GetResult();
            options.ConsentCookie.Expiration = new TimeSpan(365, 0, 0, 0);
        });
    }

    // This is necessary because IConsentService is not yet available with Dependency Injection at this point.
    private static Task<bool> IsConsentNeededAsync(HttpContext httpContext)
    {
        var consentService = httpContext.RequestServices.GetService<IPrivacyConsentService>();

        if (consentService == null)
        {
            return Task.FromResult(true);
        }

        return consentService.IsConsentNeededAsync(httpContext);
    }
}

[Feature(FeatureNames.ConsentBanner)]
public sealed class ConsentBannerStartup : StartupBase
{
    // This is important because the custom settings menu item override only runs correctly this way.
    public override int Order => -1;

    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IConfigureOptions<ResourceManagementOptions>, ResourceManagementOptionsConfiguration>();
        services.AddAsyncResultFilter<PrivacyConsentBannerInjectionFilter>();
        services.AddDataMigration<PrivacyConsentBannerSettingsMigrations>();
        services.AddNavigationProvider<PrivacyConsentBannerSettingsMenu>();
    }
}

[Feature(FeatureNames.RegistrationConsent)]
public sealed class RegistrationConsentStartup : StartupBase
{
    // This is important because the custom settings menu item override only runs correctly this way.
    public override int Order => -1;

    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddDisplayDriver<RegisterUserForm, RegistrationCheckboxDriver>();
        services.AddScoped<IRegistrationFormEvents, RegistrationFormEventHandler>();
        services.AddDataMigration<PrivacyRegistrationConsentSettingsMigrations>();
        services.AddNavigationProvider<PrivacyRegistrationConsentSettingsMenu>();
    }
}

[Feature(FeatureNames.ExternalRegistrationConsent)]
public sealed class ExternalRegistrationConsentStartup : StartupBase
{
    // This is important because the custom settings menu item override only runs correctly this way.
    public override int Order => -1;

    public override void ConfigureServices(IServiceCollection services)
    {
        services.Configure<MvcOptions>((options) =>
            options.Filters.Add<ExternalRegistrationCheckboxInjectionFilter>());
        services.AddScoped<IRegistrationFormEvents, ExternalRegistrationFormEventHandler>();
    }
}

[Feature(FeatureNames.FormConsent)]
public sealed class FormConsentStartup : StartupBase
{
    // This is important because the custom settings menu item override only runs correctly this way.
    public override int Order => -1;

    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddContentPart<PrivacyConsentCheckboxPart>()
            .UseDisplayDriver<PrivacyConsentCheckboxPartDisplayDriver>();
        services.AddDataMigration<PrivacyConsentCheckboxMigrations>();
        services.AddDataMigration<PrivacyConsentCheckboxSettingsMigrations>();
        services.AddActivity<ValidatePrivacyConsentCheckboxTask, ValidatePrivacyConsentCheckboxTaskDisplayDriver>();
        services.AddNavigationProvider<PrivacyConsentCheckboxSettingsMenu>();
    }
}
