using Smartent.Orchard.Hosting.Tenants.Admin.Login.Permissions;
using Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using OrchardCore.DisplayManagement;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.DisplayManagement.Descriptors;
using OrchardCore.Modules;
using OrchardCore.DisplayManagement.Views;
using OrchardCore.Environment.Shell;
using OrchardCore.Tenants.ViewModels;
using Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.Constants;

namespace Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.ShapeTables;

/// <summary>在租户列表 <c>TenantActionButtons</c> 上挂接「Login as admin」按钮（与 Orchard Features 按钮同一扩展点）。</summary>
[RequireFeatures(FeatureNames.Module)]
public sealed class TenantAdminLoginShapeTableProvider : ShapeTableProvider
{
    public override ValueTask DiscoverAsync(ShapeTableBuilder builder)
    {
        builder.Describe("TenantActionButtons")
            .OnDisplaying(async displaying =>
            {
                if (!displaying.Shape.TryGetProperty("ShellSettingsEntry", out ShellSettingsEntry entry))
                {
                    return;
                }

                var services = displaying.ServiceProvider;
                var shellSettings = services.GetRequiredService<ShellSettings>();

                if (!shellSettings.IsDefaultShell())
                {
                    return;
                }

                if (entry.ShellSettings.IsDefaultShell() || !entry.ShellSettings.IsRunning())
                {
                    return;
                }

                var httpContextAccessor = services.GetRequiredService<IHttpContextAccessor>();
                var authorizationService = services.GetRequiredService<IAuthorizationService>();

                if (!await authorizationService.AuthorizeAsync(
                        httpContextAccessor.HttpContext?.User,
                        TenantAdminPermissions.LoginAsAdmin))
                {
                    return;
                }

                var proxyService = services.GetRequiredService<TenantAdminLoginProxyService>();
                if (!await proxyService.IsSubTenantLoginEnabledAsync(entry.Name))
                {
                    return;
                }

                await displaying.Shape.AddAsync(
                    new ShapeViewModel<ShellSettingsEntry>("ManageTenantLoginActionButton", entry),
                    "15");
            });

        return ValueTask.CompletedTask;
    }
}