using Smartent.Orchard.Theme.Media.Bridge.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Security;
using System;
using System.Threading.Tasks;
using static Smartent.Orchard.Theme.Media.Bridge.Permissions.MediaThemeDeploymentPermissions;
using MediaPermissions = OrchardCore.Media.Permissions;

namespace Smartent.Orchard.Theme.Media.Bridge.Services;

public class ManageMediaThemeFolderAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
{
    private readonly IServiceProvider _serviceProvider;

    public ManageMediaThemeFolderAuthorizationHandler(IServiceProvider serviceProvider) =>
        _serviceProvider = serviceProvider;

    protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
    {
        if (requirement.Permission.Name != MediaPermissions.ManageMediaFolder.Name) return;

        var path = context.Resource as string;
        if (string.IsNullOrEmpty(path) || !path.StartsWith(Paths.MediaThemeRootFolder, StringComparison.Ordinal))
        {
            return;
        }

        var authorizationService = _serviceProvider.GetService<IAuthorizationService>();

        if (!await authorizationService.AuthorizeAsync(context.User, ManageMediaTheme))
        {
            context.Fail();
        }
    }
}
