namespace Smartent.Orchard.Marketing.Constants;

/// <summary>
/// Orchard 租户配置节名称（appsettings 中位于 OrchardCore 下）。
/// </summary>
public static class MarketingConfigurationKeys
{
    /// <summary>当前推荐节名。</summary>
    public const string Section = "Smartent_Marketing";

    /// <summary>Legacy 节名（仍支持读取）。</summary>
    public const string LegacySection = "Lombiq_Marketing";
}