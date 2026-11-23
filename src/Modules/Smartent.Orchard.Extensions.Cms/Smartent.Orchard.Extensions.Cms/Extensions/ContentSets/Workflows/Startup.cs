using Smartent.Orchard.Extensions.Cms.Extensions.ContentSets.Events;
using Smartent.Orchard.Extensions.Cms.Extensions.ContentSets.Workflows.Activities;
using Smartent.Orchard.Extensions.Cms.Extensions.ContentSets.Workflows.Drivers;
using Smartent.Orchard.Extensions.Cms.Extensions.ContentSets.Workflows.Handlers;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Workflows.Helpers;

namespace Smartent.Orchard.Extensions.Cms.Extensions.ContentSets.Workflows;

[Feature(FeatureIds.ContentSets)]
[RequireFeatures("OrchardCore.Workflows")]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddActivity<ContentSetGetSupportedOptionsEvent, ContentSetGetSupportedOptionsEventDisplayDriver>();
        services.AddActivity<ContentSetCreatingEvent, ContentSetCreatingEventDisplayDriver>();
        services.AddScoped<IContentSetEventHandler, WorkflowContentSetEventHandler>();
    }
}
