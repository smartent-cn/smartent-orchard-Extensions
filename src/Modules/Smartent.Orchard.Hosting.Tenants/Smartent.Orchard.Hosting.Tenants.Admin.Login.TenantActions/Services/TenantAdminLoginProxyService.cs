using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Environment.Extensions.Features;
using OrchardCore.Environment.Shell;
using OrchardCore.Environment.Shell.Scope;
using static Smartent.Orchard.Hosting.Tenants.Admin.Login.Constants.FeatureNames;

namespace Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.Services;

/// <summary>
/// 在 Default 请求上下文中，通过 <see cref="IShellHost"/> 代理查询子租户是否已启用 SubTenant。
/// </summary>
public sealed class TenantAdminLoginProxyService
{
    private readonly IShellHost _shellHost;

    public TenantAdminLoginProxyService(IShellHost shellHost) =>
        _shellHost = shellHost;

    /// <summary>
    /// 子租户处于运行中且描述符中启用了 <see cref="SubTenant"/> 时返回 true。
    /// </summary>
    public async Task<bool> IsSubTenantLoginEnabledAsync(string tenantName)
    {
        if (string.IsNullOrWhiteSpace(tenantName) ||
            !_shellHost.TryGetSettings(tenantName, out var settings) ||
            settings.IsDefaultShell() ||
            !settings.IsRunning())
        {
            return false;
        }

        var enabled = false;
        var shellScope = await _shellHost.GetScopeAsync(settings);

        await shellScope.UsingAsync(async scope =>
        {
            var featuresManager = scope.ServiceProvider.GetRequiredService<IShellFeaturesManager>();
            var enabledFeatures = await featuresManager.GetEnabledFeaturesAsync();
            enabled = enabledFeatures.Any(feature => feature.Id == SubTenant);
        });

        return enabled;
    }

    /// <summary>
    /// 获取用于登录的子租户设置；不存在或不可登录时返回 null。
    /// </summary>
    public async Task<ShellSettings?> TryGetLoginTargetSettingsAsync(string tenantName)
    {
        if (!await IsSubTenantLoginEnabledAsync(tenantName))
        {
            return null;
        }

        return _shellHost.TryGetSettings(tenantName, out var settings) ? settings : null;
    }
}