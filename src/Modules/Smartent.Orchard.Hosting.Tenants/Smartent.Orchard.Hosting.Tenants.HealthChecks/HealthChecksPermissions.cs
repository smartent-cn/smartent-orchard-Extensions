using Smartent.Orchard.Platform.Users;
using OrchardCore.Security.Permissions;
using System.Collections.Generic;

namespace Smartent.Orchard.Hosting.Tenants.HealthChecks;

public class HealthChecksPermissions : AdminPermissionBase
{
    public static readonly Permission ViewHealthChecks =
        new(nameof(ViewHealthChecks), "View tenant Health Checks from the Default tenant admin menu.");

    protected override IEnumerable<Permission> AdminPermissions =>
    [
        ViewHealthChecks,
    ];
}
