using Fluid;
using Smartent.Orchard.Extensions.Cms.Extensions.Workflows.Activities;
using Smartent.Orchard.Extensions.Cms.Extensions.Workflows.Drivers;
using Smartent.Orchard.Extensions.Cms.Extensions.Workflows.Models;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Workflows.Helpers;

namespace Smartent.Orchard.Extensions.Cms.Extensions.Workflows;

[Feature(FeatureIds.ResetPasswordActivity)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddActivity<GenerateResetPasswordTokenTask, GenerateResetPasswordTokenTaskDisplayDriver>();
        services.Configure<TemplateOptions>(option =>
            option.MemberAccessStrategy.Register<GenerateResetPasswordTokenResult>());
    }
}
