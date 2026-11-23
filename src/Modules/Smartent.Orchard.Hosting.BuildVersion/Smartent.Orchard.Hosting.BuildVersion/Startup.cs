using Smartent.Orchard.Hosting.BuildVersion.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace Smartent.Orchard.Hosting.BuildVersion;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services) =>
        services.Configure<MvcOptions>((options) => options.Filters.Add<BuildVersionDisplayInjectingFilter>());
}
