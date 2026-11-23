using Smartent.Orchard.EmailClient.Constants;
using Smartent.Orchard.EmailClient.Drivers;
using Smartent.Orchard.EmailClient.Models;
using Smartent.Orchard.EmailClient.Navigation;
using Smartent.Orchard.EmailClient.Permissions;
using Smartent.Orchard.EmailClient.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.BackgroundTasks;
using OrchardCore.DisplayManagement.Handlers;
using OrchardCore.Environment.Shell.Configuration;
using OrchardCore.Modules;
using OrchardCore.Navigation;
using OrchardCore.Security.Permissions;

namespace Smartent.Orchard.EmailClient;

[Feature(FeatureIds.Imap)]
public class ImapStartup : StartupBase
{
    private readonly IShellConfiguration _shellConfiguration;

    public ImapStartup(IShellConfiguration shellConfiguration) => _shellConfiguration = shellConfiguration;

    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IPermissionProvider, ImapPermissions>();
        services.AddScoped<INavigationProvider, ImapAdminMenu>();
        services.AddSiteDisplayDriver<ImapSettingsDisplayDriver>();

        services.Configure<ImapSettings>(_shellConfiguration.GetSection("Lombiq_EmailClient_Imap"));
        services.AddTransient<IConfigureOptions<ImapSettings>, ImapSettingsConfiguration>();

        services.AddScoped<IEmailClient, ImapEmailClient>();
    }
}

[Feature(FeatureIds.EmailSync)]
public class EmailSyncStartup : StartupBase
{
    private readonly IShellConfiguration _shellConfiguration;

    public EmailSyncStartup(IShellConfiguration shellConfiguration) => _shellConfiguration = shellConfiguration;

    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IPermissionProvider, EmailSyncPermissions>();
        services.AddScoped<INavigationProvider, EmailSyncAdminMenu>();
        services.AddSiteDisplayDriver<EmailSyncSettingsDisplayDriver>();

        services.Configure<EmailSyncSettings>(_shellConfiguration.GetSection("Lombiq_EmailClient_EmailSync"));
        services.AddTransient<IConfigureOptions<EmailSyncSettings>, EmailSyncSettingsConfiguration>();

        services.AddScoped<IEmailSyncService, EmailSyncService>();
        services.AddSingleton<IBackgroundTask, EmailSyncBackgroundTask>();
    }
}
