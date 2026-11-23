using Smartent.Demo.Platform.Samples.Migrations;
using Smartent.Demo.Platform.Samples.Navigation;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;
using OrchardCore.Navigation;

namespace Smartent.Demo.Platform.Samples;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddDataMigration<BookRecordMigrations>();
        services.AddDataMigration<ExpressionSampleMigration>();
        services.AddNavigationProvider<HelpfulLibrariesNavigationProvider>();
    }
}
