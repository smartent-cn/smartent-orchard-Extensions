using Smartent.Orchard.DataTables.Liquid;
using Smartent.Orchard.DataTables.Migrations;
using Smartent.Orchard.DataTables.Services;
using Smartent.Orchard.DataTables.TagHelpers;
using Smartent.Core.AspNet.Middlewares;
using Smartent.Orchard.Platform.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.Data.Migration;
using OrchardCore.Liquid;
using OrchardCore.Modules;
using OrchardCore.ResourceManagement;
using System;

namespace Smartent.Orchard.DataTables;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddDataTableExportService<ExcelDataTableExportService>();

        services.AddTagHelpers<DataTableTagHelper>();

        services.AddTransient<IConfigureOptions<ResourceManagementOptions>, ResourceManagementOptionsConfiguration>();
        services.AddDataMigration<ColumnsDefinitionMigrations>();

        services.AddLiquidFilter<ActionsLiquidFilter>("actions");

        services.AddScoped<IDataTableDataProviderServices, DataTableDataProviderServices>();
        services.AddOrchardServices();

        services.AddScoped<IDeferredTask, IndexGeneratorDeferredTask>();

        services.AddDataTableDataProvider<DeletedContentItemDataTableDataProvider>();
    }

    public override void Configure(IApplicationBuilder app, IEndpointRouteBuilder routes, IServiceProvider serviceProvider) =>
        app.UseDeferredTasks();
}
