using Smartent.Core.AspNet.Security;
using Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.Extensions;
using Microsoft.AspNetCore.Http;
using OrchardCore.DisplayManagement.Extensions;
using OrchardCore.Environment.Shell;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.Services;

/// <summary>启动页允许向子租户 <c>form-action</c> POST。</summary>
internal sealed class TenantAdminLoginLaunchCspProvider : IContentSecurityPolicyProvider
{
    private readonly IShellHost _shellHost;

    public TenantAdminLoginLaunchCspProvider(IShellHost shellHost) =>
        _shellHost = shellHost;

    public async ValueTask UpdateAsync(IDictionary<string, string> securityPolicies, HttpContext context)
    {
        var actionContext = await context.GetActionContextAsync();
        if (actionContext == null)
        {
            return;
        }

        if (!actionContext.IsTenantAdminLoginLaunchRoute())
        {
            return;
        }

        var tenant = actionContext.RouteData.Values["tenant"]?.ToString()
            ?? context.Request.Query["tenant"].ToString();

        if (string.IsNullOrWhiteSpace(tenant) ||
            !_shellHost.TryGetSettings(tenant, out var target) ||
            target.IsDefaultShell())
        {
            return;
        }

        CspHelper.MergeValues(securityPolicies, ContentSecurityPolicyDirectives.FormAction, target.RequestUrlHosts);
    }
}