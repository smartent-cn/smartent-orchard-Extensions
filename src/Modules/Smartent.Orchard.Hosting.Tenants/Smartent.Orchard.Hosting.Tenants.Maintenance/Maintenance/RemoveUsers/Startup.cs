using Smartent.Orchard.Platform.Mvc;
using Smartent.Orchard.Hosting.Tenants.Maintenance.Constants;
using Smartent.Orchard.Hosting.Tenants.Maintenance.Services;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Environment.Shell.Configuration;
using OrchardCore.Modules;

namespace Smartent.Orchard.Hosting.Tenants.Maintenance.Maintenance.RemoveUsers;

[Feature(FeatureNames.RemoveUsers)]
public sealed class Startup : StartupBase
{
    private readonly IShellConfiguration _shellConfiguration;

    public Startup(IShellConfiguration shellConfiguration) =>
        _shellConfiguration = shellConfiguration;

    public override void ConfigureServices(IServiceCollection services)
    {
        services.BindAndConfigureSection<RemoveUsersMaintenanceOptions>(
            _shellConfiguration,
            "Smartent_Orchard_Hosting_Tenants_Maintenance:RemoveUsers");

        services.AddScoped<IMaintenanceProvider, RemoveUsersMaintenanceProvider>();
    }
}
