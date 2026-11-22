using Smartent.Core.AspNet.Extensions;
using Smartent.Orchard.Platform.ResourceManagement;
using Smartent.Orchard.VueJs.Models;
using Smartent.Orchard.VueJs.Services;
using Smartent.Orchard.VueJs.TagHelpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.DisplayManagement.Descriptors.ShapeTemplateStrategy;
using OrchardCore.Modules;
using OrchardCore.ResourceManagement;

namespace Smartent.Orchard.VueJs;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IShapeTemplateHarvester, VueSingleFileComponentTemplateHarvester>();
        services.AddScoped<IShapeTemplateViewEngine, VueSingleFileComponentShapeTemplateViewEngine>();

        services.AddTagHelpers<VueComponentTagHelper>();
        services.AddScoped<VueComponentTagHelperState>();
        services.AddContentSecurityPolicyProvider<VueComponentContentSecurityPolicyProvider>();

        services.AddScoped<IVueSingleFileComponentShapeAmender, ContentItemDisplayVueSingleFileComponentShapeAmender>();
        services.AddScoped<IVueSingleFileComponentShapeAmender, DateTimeVueSingleFileComponentShapeAmender>();

        services.AddTransient<IConfigureOptions<ResourceManagementOptions>, ResourceManagementOptionsConfiguration>();
        services.AddAsyncResultFilter<ScriptModuleResourceFilter>();

        services.AddScoped<IVueTemplateExpressionConverter, LiquidVueTemplateExpressionConverter>();
        services.AddScoped<IVueTemplateExpressionConverter, MarkdownVueTemplateExpressionConverter>();
    }
}
