using Microsoft.Extensions.Configuration;
using OrchardCore.Environment.Shell.Configuration;
using Smartent.Orchard.Marketing.Constants;

namespace Smartent.Orchard.Marketing;

public static class ShellConfigurationMarketingExtensions
{
    /// <summary>
    /// 返回 <c>Smartent_Marketing:{relativePath}</c> 配置节。
    /// </summary>
    public static IConfigurationSection GetMarketingSection(this IShellConfiguration configuration, string relativePath) =>
        configuration.GetSection($"{MarketingConfigurationKeys.Section}:{relativePath}");
}