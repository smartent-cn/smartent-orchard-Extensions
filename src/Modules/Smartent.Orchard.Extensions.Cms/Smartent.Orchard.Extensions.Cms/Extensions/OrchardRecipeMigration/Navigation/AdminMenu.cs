using Smartent.Orchard.Extensions.Cms.Extensions.OrchardRecipeMigration.Controllers;
using Smartent.Orchard.Platform.Navigation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using OrchardCore.Modules;
using OrchardCore.Navigation;
using System.Threading.Tasks;

namespace Smartent.Orchard.Extensions.Cms.Extensions.OrchardRecipeMigration.Navigation;

public sealed class AdminMenu : INavigationProvider
{
    private readonly IHttpContextAccessor _hca;
    private readonly IStringLocalizer T;

    public AdminMenu(IHttpContextAccessor hca, IStringLocalizer<AdminMenu> stringLocalizer)
    {
        _hca = hca;
        T = stringLocalizer;
    }

    public ValueTask BuildNavigationAsync(string name, NavigationBuilder builder)
    {
        if (!name.EqualsOrdinalIgnoreCase("admin")) return ValueTask.CompletedTask;

        builder.Add(T["Tools"], tools => tools
            .Add(T["Deployments"], deployments => deployments
                .Add(T["Orchard 1 Recipe Migration"], T["Orchard 1 Recipe Migration"], migration => migration
                    .Action<OrchardRecipeMigrationAdminController>(_hca.HttpContext, controller => controller.Index())
                    .LocalNav()
                )));

        return ValueTask.CompletedTask;
    }
}
