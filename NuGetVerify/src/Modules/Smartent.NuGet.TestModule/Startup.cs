using Smartent.Core.Primitives.DependencyInjection;
using Smartent.Orchard.Platform.Users;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace Smartent.NuGet.TestModule;

public class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddCachingUserServer();
        services.AddLazyInjectionSupport();
    }
}
