namespace Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.ViewModels;

/// <summary>由 Default 代理页转发到子租户 <c>TenantLogin</c> 的自动提交表单模型。</summary>
public sealed class TenantAdminLoginLaunchViewModel
{
    /// <summary>子租户 POST 地址。</summary>
    public string PostUrl { get; set; } = string.Empty;

    /// <summary>一次性登录口令。</summary>
    public string Password { get; set; } = string.Empty;
}