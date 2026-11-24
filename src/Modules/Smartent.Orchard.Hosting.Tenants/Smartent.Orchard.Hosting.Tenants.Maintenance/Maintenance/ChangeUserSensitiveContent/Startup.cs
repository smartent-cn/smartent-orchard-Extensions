using Smartent.Orchard.Platform.Mvc;
using Smartent.Orchard.Hosting.Tenants.Maintenance.Constants;
using Smartent.Orchard.Hosting.Tenants.Maintenance.Services;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.BackgroundTasks;
using OrchardCore.Environment.Shell.Configuration;
using OrchardCore.Modules;

namespace Smartent.Orchard.Hosting.Tenants.Maintenance.Maintenance.ChangeUserSensitiveContent;

[Feature(FeatureNames.ChangeUserSensitiveContent)]
public sealed class Startup : StartupBase
{
    private readonly IShellConfiguration _shellConfiguration;

    public Startup(IShellConfiguration shellConfiguration) =>
        _shellConfiguration = shellConfiguration;

    public override void ConfigureServices(IServiceCollection services)
    {
        services.BindAndConfigureSection<ChangeUserSensitiveContentMaintenanceOptions>(
            _shellConfiguration,
            "Smartent_Orchard_Hosting_Tenants_Maintenance:ChangeUserSensitiveContent");

        services.AddScoped<IMaintenanceProvider, ChangeUserSensitiveContentMaintenanceProvider>();
        services.AddSingleton<IChangeUserSensitiveContentQueue, ChangeUserSensitiveContentQueue>();
        services.AddSingleton<IBackgroundTask, ChangeUserSensitiveContentBackgroundTask>();
    }
}
