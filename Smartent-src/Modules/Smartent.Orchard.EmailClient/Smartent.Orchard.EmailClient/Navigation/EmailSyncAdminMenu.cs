using Smartent.Orchard.EmailClient.Drivers;
using Smartent.Orchard.EmailClient.Permissions;
using Smartent.Orchard.Platform.Navigation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using OrchardCore.Navigation;

namespace Smartent.Orchard.EmailClient.Navigation;

public sealed class EmailSyncAdminMenu : AdminMenuNavigationProviderBase
{
    public EmailSyncAdminMenu(IHttpContextAccessor hca, IStringLocalizer<EmailSyncAdminMenu> stringLocalizer)
        : base(hca, stringLocalizer)
    {
    }

    protected override void Build(NavigationBuilder builder) =>
        builder
            .Add(T["Settings"], settings => settings
                .Add(T["Email Sync"], T["Email Sync"], demo => demo
                    .Action("Index", "Admin", new { area = "OrchardCore.Settings", groupId = EmailSyncSettingsDisplayDriver.GroupId })
                    .Permission(EmailSyncPermissions.ManageEmailSyncSettings)
                    .LocalNav()
                ));
}
