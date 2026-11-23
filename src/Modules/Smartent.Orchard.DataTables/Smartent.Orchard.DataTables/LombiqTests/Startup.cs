using Smartent.Orchard.DataTables.LombiqTests.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace Smartent.Orchard.DataTables.LombiqTests;

[RequireFeatures("Smartent.Test.UI.Shortcuts")]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services) =>
        services.Configure<MvcOptions>(options => options.Filters.Add<TestingFilter>());
}
