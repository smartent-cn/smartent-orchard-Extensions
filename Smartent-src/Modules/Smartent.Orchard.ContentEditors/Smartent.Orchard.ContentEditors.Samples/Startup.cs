using Smartent.Orchard.ContentEditors.Extensions;
using Smartent.Orchard.ContentEditors.Samples.Constants;
using Smartent.Orchard.ContentEditors.Samples.Drivers;
using Smartent.Orchard.ContentEditors.Samples.Migrations;
using Smartent.Orchard.ContentEditors.Samples.Models;
using Smartent.Orchard.ContentEditors.Samples.Navigation;
using Smartent.Orchard.ContentEditors.Samples.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Modules;
using OrchardCore.Navigation;
using OrchardCore.ResourceManagement;

namespace Smartent.Orchard.ContentEditors.Samples;

[Feature(FeatureIds.Samples)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services
            .AddContentPart<AsyncEditorEmployeePart>()
            .WithMigration<EmployeeMigrations>()
            .WithAsyncEditor<EmployeeAsyncEditorProvider>();

        services
            .AddContentPart<SupportTicketPart>()
            .UseDisplayDriver<SupportTicketPartDisplayDriver>()
            .WithMigration<SupportTicketMigrations>()
            .WithAsyncEditor<SupportTicketAsyncEditorProvider>();

        services.AddTransient<IConfigureOptions<ResourceManagementOptions>, ResourceManagementOptionsConfiguration>();

        services.AddNavigationProvider<ContentEditorsSamplesNavigationProvider>();
    }
}
