using Smartent.Orchard.Hosting.Tenants.Admin.Login.Constants;
using Smartent.Orchard.Hosting.Tenants.Admin.Login.Filters;
using Smartent.Orchard.Hosting.Tenants.Admin.Login.Permissions;
using Smartent.Orchard.Hosting.Tenants.Admin.Login.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Security.Permissions;

namespace Smartent.Orchard.Hosting.Tenants.Admin.Login;

[Feature(FeatureNames.Module)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.Configure<MvcOptions>(options => options.Filters.Add<TenantsIndexFilter>());
        services.AddPermissionProvider<TenantAdminPermissions>();
        services.AddSingleton<ITenantLoginPasswordValidator, TenantLoginKeyValidator>();
        services.AddContentSecurityPolicyProvider<TenantLoginSecurityPolicyProvider>();
    }
}
