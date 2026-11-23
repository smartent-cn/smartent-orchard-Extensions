using Microsoft.Extensions.Configuration;
using OrchardCore.Environment.Shell.Configuration;
using Smartent.Orchard.Marketing.Constants;

namespace Smartent.Orchard.Marketing;

public static class ShellConfigurationMarketingExtensions
{
    /// <summary>
    /// 返回 <c>Smartent_Marketing:{relativePath}</c>；若不存在则回退 <c>Lombiq_Marketing:{relativePath}</c>。
    /// </summary>
    public static IConfigurationSection GetMarketingSection(this IShellConfiguration configuration, string relativePath)
    {
        var primary = configuration.GetSection($"{MarketingConfigurationKeys.Section}:{relativePath}");
        return primary.Exists() ? primary : configuration.GetSection($"{MarketingConfigurationKeys.LegacySection}:{relativePath}");
    }
}