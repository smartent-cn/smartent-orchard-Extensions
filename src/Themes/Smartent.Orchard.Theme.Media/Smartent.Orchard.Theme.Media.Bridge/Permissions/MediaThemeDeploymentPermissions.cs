using Smartent.Orchard.Platform.Users;
using OrchardCore.Security.Permissions;
using System.Collections.Generic;

namespace Smartent.Orchard.Theme.Media.Bridge.Permissions;

public sealed class MediaThemeDeploymentPermissions : AdminPermissionBase
{
    public static readonly Permission ManageMediaTheme = new(nameof(ManageMediaTheme), "Manage Media Theme.");

    protected override IEnumerable<Permission> AdminPermissions => [ManageMediaTheme];
}
