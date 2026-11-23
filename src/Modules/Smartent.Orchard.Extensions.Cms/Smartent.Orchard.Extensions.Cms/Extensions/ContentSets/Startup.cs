using Smartent.Orchard.Extensions.Cms.Extensions.ContentSets.Drivers;
using Smartent.Orchard.Extensions.Cms.Extensions.ContentSets.Indexes;
using Smartent.Orchard.Extensions.Cms.Extensions.ContentSets.Models;
using Smartent.Orchard.Extensions.Cms.Extensions.ContentSets.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Modules;
using System;

namespace Smartent.Orchard.Extensions.Cms.Extensions.ContentSets;

[Feature(FeatureIds.ContentSets)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services
            .AddContentPart<ContentSetPart>()
            .UseDisplayDriver<ContentSetPartDisplayDriver>()
            .WithIndex<ContentSetIndexProvider>()
            .WithMigration<Migrations>();

        services.AddScoped<IContentSetManager, ContentSetManager>();

        services.AddContentField<ContentSetContentPickerField>()
            .UseDisplayDriver<ContentSetContentPickerFieldDisplayDriver>();
    }

    public override void Configure(IApplicationBuilder app, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
    {
        // No need for anything here yet.
    }
}
