using Microsoft.AspNetCore.Mvc;
using OrchardCore.Mvc.Core.Utilities;
using Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.Controllers;

namespace Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.Extensions;

internal static class LaunchRouteExtensions
{
    public static bool IsTenantAdminLoginLaunchRoute(this ActionContext context)
    {
        var controller = typeof(TenantAdminLoginLaunchController).ControllerName();
        const string module = "Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions";

        return context.IsMvcRoute(nameof(TenantAdminLoginLaunchController.Prepare), controller, module)
            || context.IsMvcRoute(nameof(TenantAdminLoginLaunchController.Index), controller, module);
    }
}