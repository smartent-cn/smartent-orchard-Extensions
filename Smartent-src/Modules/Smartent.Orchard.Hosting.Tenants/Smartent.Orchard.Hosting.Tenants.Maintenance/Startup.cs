using Smartent.Core.Primitives.DependencyInjection;
using Smartent.Orchard.Hosting.Tenants.Maintenance.Constants;
using Smartent.Orchard.Hosting.Tenants.Maintenance.Indexes;
using Smartent.Orchard.Hosting.Tenants.Maintenance.Services;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Data;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;
using OrchardCore.Navigation;
using OrchardCore.Security.Permissions;

namespace Smartent.Orchard.Hosting.Tenants.Maintenance;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddLazyInjectionSupport();
        services.Configure<StoreCollectionOptions>(options => options.Collections.Add(DocumentCollections.Maintenance));

        services.AddIndexProvider<MaintenanceTaskExecutionIndexProvider>();
        services.AddDataMigration<Migrations>();

        services.AddScoped<IModularTenantEvents, MaintenanceRunnerService>();
        services.AddScoped<IMaintenanceManager, MaintenanceManager>();

        services.AddNavigationProvider<AdminMenu>();
        services.AddPermissionProvider<MaintenancePermissions>();
    }
}

[RequireFeatures("OrchardCore.Elasticsearch")]
public sealed class ElasticsearchStartup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services) =>
        services.AddDataMigration<QueryElasticsearchMigration>();
}
