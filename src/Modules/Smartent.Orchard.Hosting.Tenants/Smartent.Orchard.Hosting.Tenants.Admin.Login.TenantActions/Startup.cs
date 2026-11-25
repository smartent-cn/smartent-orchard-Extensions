using Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.Constants;
using Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.Services;
using Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.ShapeTables;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.DisplayManagement.Descriptors;
using OrchardCore.Modules;

namespace Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions;

[Feature(FeatureNames.Module)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<TenantAdminLoginProxyService>();
        services.AddSingleton<IShapeTableProvider, TenantAdminLoginShapeTableProvider>();
        services.AddContentSecurityPolicyProvider<TenantAdminLoginLaunchCspProvider>();
    }
}