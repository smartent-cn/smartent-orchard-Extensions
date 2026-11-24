using Smartent.Orchard.Hosting.Tenants.EmailQuotaManagement.Constants;
using Smartent.Orchard.Hosting.Tenants.EmailQuotaManagement.Filters;
using Smartent.Orchard.Hosting.Tenants.EmailQuotaManagement.Migrations;
using Smartent.Orchard.Hosting.Tenants.EmailQuotaManagement.Models;
using Smartent.Orchard.Hosting.Tenants.EmailQuotaManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.BackgroundTasks;
using OrchardCore.Data.Migration;
using OrchardCore.Email;
using OrchardCore.Environment.Shell.Configuration;
using OrchardCore.Modules;
using static Smartent.Orchard.Hosting.Tenants.EmailQuotaManagement.Constants.EmailQuotaOptionsConstants;

namespace Smartent.Orchard.Hosting.Tenants.EmailQuotaManagement;

[Feature(FeatureNames.EmailQuotaManagement)]
public sealed class Startup : StartupBase
{
    private readonly IShellConfiguration _shellConfiguration;

    public Startup(IShellConfiguration shellConfiguration) =>
        _shellConfiguration = shellConfiguration;

    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddDataMigration<EmailQuotaMigrations>();
        services.AddSingleton<IBackgroundTask, EmailQuotaResetBackgroundTask>();

        services.Configure<EmailQuotaOptions>(options =>
            options.EmailQuotaPerMonth = _shellConfiguration.GetValue<int?>("Smartent_Orchard_Hosting_Tenants_EmailQuotaManagement:EmailQuotaPerMonth")
                ?? DefaultEmailQuota);

        services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add<DashboardQuotaFilter>();
                options.Filters.Add<EmailSettingsQuotaFilter>();
            }
        );

        services.AddScoped<IEmailQuotaService, EmailQuotaService>();
        services.AddScoped<IEmailQuotaSubjectService, EmailQuotaSubjectService>();

        services.Decorate<IEmailService, QuotaEnforcingEmailServiceDecorator>();
    }
}
