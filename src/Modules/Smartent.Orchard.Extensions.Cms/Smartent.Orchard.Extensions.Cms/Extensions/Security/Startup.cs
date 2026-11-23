using Smartent.Orchard.Extensions.Cms.Extensions.Security.Driver;
using Smartent.Orchard.Extensions.Cms.Extensions.Security.Services;
using Smartent.Core.Primitives.DependencyInjection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.Modules;

namespace Smartent.Orchard.Extensions.Cms.Extensions.Security;

[Feature(FeatureIds.Security)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddLazyInjectionSupport();
        services.AddScoped<IAuthorizationHandler, StrictSecurityPermissionAuthorizationHandler>();
        services.AddScoped<IContentTypeDefinitionDisplayDriver, StrictSecuritySettingsDisplayDriver>();
    }
}
