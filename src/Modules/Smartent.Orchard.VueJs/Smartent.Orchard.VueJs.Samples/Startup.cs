using Smartent.Core.Primitives.DependencyInjection;
using Smartent.Orchard.VueJs.Samples.Migrations;
using Smartent.Orchard.VueJs.Samples.Navigation;
using Smartent.Orchard.VueJs.Samples.TagHelpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;
using OrchardCore.Navigation;
using OrchardCore.ResourceManagement;

namespace Smartent.Orchard.VueJs.Samples;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services) =>
        services.AddTransient<IConfigureOptions<ResourceManagementOptions>, ResourceManagementOptionsConfiguration>()
            .AddScoped<IDataMigration, BusinessCardMigrations>()
            .AddTagHelpers<QrCodeTagHelper>()
            .AddNavigationProvider<VueJsNavigationProvider>()
            .AddLazyInjectionSupport();
}
