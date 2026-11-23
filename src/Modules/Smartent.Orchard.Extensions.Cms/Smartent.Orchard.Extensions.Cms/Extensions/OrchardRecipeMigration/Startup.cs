using Smartent.Orchard.Extensions.Cms.Extensions.OrchardRecipeMigration.Navigation;
using Smartent.Orchard.Extensions.Cms.Extensions.OrchardRecipeMigration.Services;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Navigation;

namespace Smartent.Orchard.Extensions.Cms.Extensions.OrchardRecipeMigration;

[Feature(FeatureIds.OrchardRecipeMigration)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IOrchardExportToRecipeConverter, OrchardExportToRecipeConverter>();
        services.AddScoped<IOrchardContentConverter, CommonOrchardContentConverter>();
        services.AddScoped<IOrchardContentConverter, GraphMetadataOrchardContentConverter>();
        services.AddScoped<IOrchardExportConverter, ListPartOrchardExportConverter>();
        services.AddScoped<IOrchardUserConverter, UserOrchardContentConverter>();

        services.AddNavigationProvider<AdminMenu>();
    }
}
