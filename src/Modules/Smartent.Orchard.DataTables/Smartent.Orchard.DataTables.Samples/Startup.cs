using Smartent.Orchard.DataTables.Samples.Indexes;
using Smartent.Orchard.DataTables.Samples.Migrations;
using Smartent.Orchard.DataTables.Samples.Models;
using Smartent.Orchard.DataTables.Samples.Navigation;
using Smartent.Orchard.DataTables.Samples.Services;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.Modules;
using OrchardCore.Navigation;

namespace Smartent.Orchard.DataTables.Samples;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddContentPart<EmployeePart>()
            .WithMigration<EmployeeMigrations>();

        // A JSON-based provider doesn't need anything else.
        services.AddDataTableDataProvider<SampleJsonResultDataTableDataProvider>();

        // As index-based providers rely on their own index, generator, and migration they're registered all at once to
        // ensure their types match.
        services.AddIndexBasedDataTableProvider<
            EmployeeDataTableIndex,
            EmployeeDataTableIndexGenerator,
            EmployeeDataTableMigrations,
            SampleIndexBasedDataTableDataProvider>();

        services.AddNavigationProvider<DataTablesNavigationProvider>();
    }
}

// END OF TRAINING SECTION: Index-based Data Provider
