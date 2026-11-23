using Smartent.Orchard.LoginAsAnybody.Drivers;
using Smartent.Orchard.LoginAsAnybody.Permissions;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.DisplayManagement.Handlers;
using OrchardCore.Modules;
using OrchardCore.Security.Permissions;
using OrchardCore.Users.Models;

namespace Smartent.Orchard.LoginAsAnybody;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddDisplayDriver<User, UserSwitcherDisplayDriver>();
        services.AddPermissionProvider<LoginAsAnybodyPermissions>();
    }
}
