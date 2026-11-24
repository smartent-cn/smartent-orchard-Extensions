using Microsoft.Extensions.Configuration;
using OrchardCore.Environment.Shell.Configuration;
using Smartent.Orchard.TrainingDemo.Constants;

namespace Smartent.Orchard.TrainingDemo;

public static class ShellConfigurationTrainingDemoExtensions
{
    /// <summary>
    /// 返回 <c>Smartent_TrainingDemo</c> 根配置节。
    /// </summary>
    public static IConfigurationSection GetTrainingDemoSection(this IShellConfiguration configuration) =>
        configuration.GetSection(TrainingDemoConfigurationKeys.Section);
}