using Smartent.Orchard.Hosting.Tenants.Admin.Login.Permissions;
using Smartent.Orchard.Hosting.Tenants.Admin.Login.Services;
using Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.Constants;
using Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.Services;
using Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.ViewModels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrchardCore.Admin;
using OrchardCore.Environment.Shell;
using OrchardCore.Modules;

namespace Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.Controllers;

/// <summary>
/// Default 租户上的启动代理：校验权限与子租户 SubTenant，再转发 POST 到子租户登录端点。
/// </summary>
[Admin]
[Feature(FeatureNames.Module)]
public sealed class TenantAdminLoginLaunchController : Controller
{
    private readonly IAuthorizationService _authorizationService;
    private readonly ShellSettings _shellSettings;
    private readonly TenantAdminLoginProxyService _proxyService;
    private readonly ITenantLoginPasswordValidator _passwordValidator;

    public TenantAdminLoginLaunchController(
        IAuthorizationService authorizationService,
        ShellSettings shellSettings,
        TenantAdminLoginProxyService proxyService,
        ITenantLoginPasswordValidator passwordValidator)
    {
        _authorizationService = authorizationService;
        _shellSettings = shellSettings;
        _proxyService = proxyService;
        _passwordValidator = passwordValidator;
    }

    /// <summary>从租户列表发起（GET）：在 Default 内校验后打开自动提交页。</summary>
    [HttpGet]
    public Task<IActionResult> Prepare(string tenant) => LaunchAsync(tenant);

    /// <summary>兼容旧表单 POST 入口。</summary>
    [HttpPost]
    [IgnoreAntiforgeryToken]
    public Task<IActionResult> Index(string tenant) => LaunchAsync(tenant);

    private async Task<IActionResult> LaunchAsync(string tenant)
    {
        if (!_shellSettings.IsDefaultShell())
        {
            return NotFound();
        }

        if (!await _authorizationService.AuthorizeAsync(User, TenantAdminPermissions.LoginAsAdmin))
        {
            return Forbid();
        }

        var targetSettings = await _proxyService.TryGetLoginTargetSettingsAsync(tenant);
        if (targetSettings == null)
        {
            return NotFound();
        }

        return View("Submit", new TenantAdminLoginLaunchViewModel
        {
            PostUrl = TenantAdminLoginUriBuilder.BuildTenantLoginPostUrl(targetSettings, Request),
            Password = _passwordValidator.Password,
        });
    }
}