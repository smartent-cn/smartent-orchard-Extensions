using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using OrchardCore.Environment.Shell;

namespace Smartent.Orchard.Hosting.Tenants.Admin.Login.TenantActions.Services;

/// <summary>构建子租户 <c>TenantLogin/Index</c> POST 地址。</summary>
internal static class TenantAdminLoginUriBuilder
{
    private const string ActionPath = "/Smartent.Orchard.Hosting.Tenants.Admin.Login/TenantLogin/Index";

    /// <summary>
    /// 根据子租户 <see cref="ShellSettings"/> 与当前请求协议/主机生成登录 POST URL。
    /// </summary>
    public static string BuildTenantLoginPostUrl(ShellSettings tenantSettings, HttpRequest request)
    {
        var host = tenantSettings.RequestUrlHost
            ?.Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(value => value.Trim())
            .FirstOrDefault();

        var hostString = host != null ? new HostString(host) : request.Host;

        var actionPathWithPrefix = string.IsNullOrEmpty(tenantSettings.RequestUrlPrefix)
            ? ActionPath
            : '/' + tenantSettings.RequestUrlPrefix + ActionPath;

        var builder = new UriBuilder
        {
            Scheme = request.Scheme,
            Host = hostString.Host,
            Path = actionPathWithPrefix,
        };

        if (hostString.Port != null)
        {
            builder.Port = hostString.Port.Value;
        }

        return builder.Uri.ToString();
    }
}