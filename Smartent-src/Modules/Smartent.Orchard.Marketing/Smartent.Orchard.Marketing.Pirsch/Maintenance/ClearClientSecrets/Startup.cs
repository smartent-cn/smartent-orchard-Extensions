using Smartent.Orchard.Hosting.Tenants.Maintenance.Services;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Environment.Shell.Configuration;
using OrchardCore.Modules;
using PirschFeatureIds = Smartent.Orchard.Marketing.Pirsch.Constants.FeatureIds;

namespace Smartent.Orchard.Marketing.Pirsch.Maintenance.ClearClientSecrets;

[Feature(PirschFeatureIds.Base)]
public sealed class Startup : StartupBase
{
    private readonly IShellConfiguration _shellConfiguration;

    public Startup(IShellConfiguration shellConfiguration) =>
        _shellConfiguration = shellConfiguration;

    public override void ConfigureServices(IServiceCollection services)
    {
        services.Configure<ClearPirschClientSecretsMaintenanceOptions>(
            _shellConfiguration.GetSection("Lombiq_Marketing:Pirsch:ClearClientSecretsMaintenance"));

        services.AddScoped<IMaintenanceProvider, ClearPirschClientSecretsMaintenanceProvider>();
    }
}
