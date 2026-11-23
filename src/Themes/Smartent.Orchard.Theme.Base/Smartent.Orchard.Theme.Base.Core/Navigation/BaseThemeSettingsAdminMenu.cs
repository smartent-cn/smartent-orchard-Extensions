using Smartent.Orchard.Theme.Base.Core.Controllers;
using Smartent.Orchard.Theme.Base.Core.Permissions;
using Smartent.Orchard.Platform.Navigation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using OrchardCore.Navigation;

namespace Smartent.Orchard.Theme.Base.Core.Navigation;

public class BaseThemeSettingsAdminMenu : AdminMenuNavigationProviderBase
{
    public BaseThemeSettingsAdminMenu(
        IHttpContextAccessor hca,
        IStringLocalizer<BaseThemeSettingsAdminMenu> stringLocalizer)
        : base(hca, stringLocalizer)
    {
    }

    protected override void Build(NavigationBuilder builder) =>
        builder.Add(T["Settings"], settings => settings
            .Add(T["Base Theme"], T["Base Theme"], baseTheme => baseTheme
                .ActionTask<AdminController>(_hca.HttpContext, controller => controller.Index())
                .Permission(BaseThemeSettingsPermissions.ManageBaseThemeSettings)
                .LocalNav()
            ));
}
