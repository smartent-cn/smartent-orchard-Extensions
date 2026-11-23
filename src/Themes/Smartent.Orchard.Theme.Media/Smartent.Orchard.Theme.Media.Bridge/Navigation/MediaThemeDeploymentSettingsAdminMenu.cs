using Smartent.Orchard.Theme.Media.Bridge.Constants;
using Microsoft.Extensions.Localization;
using OrchardCore.Navigation;
using System;
using System.Threading.Tasks;
using static Smartent.Orchard.Theme.Media.Bridge.Permissions.MediaThemeDeploymentPermissions;

namespace Smartent.Orchard.Theme.Media.Bridge.Navigation;

public sealed class MediaThemeDeploymentSettingsAdminMenu : INavigationProvider
{
    private readonly IStringLocalizer T;

    public MediaThemeDeploymentSettingsAdminMenu(IStringLocalizer<MediaThemeDeploymentSettingsAdminMenu> stringLocalizer) => T = stringLocalizer;

    public ValueTask BuildNavigationAsync(string name, NavigationBuilder builder)
    {
        if (!string.Equals(name, "admin", StringComparison.OrdinalIgnoreCase)) return ValueTask.CompletedTask;

        builder
            .Add(T["Settings"], settings => settings
                .Add(T["Media Theme"], T["Media Theme"].PrefixPosition(), entry => entry
                    .AddClass("mediatheme").Id("mediatheme")
                    .Action("Index", "Admin", new { area = FeatureNames.MediaThemeBridge })
                    .Permission(ManageMediaTheme)
                    .LocalNav()));

        return ValueTask.CompletedTask;
    }
}
