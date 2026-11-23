using Smartent.Orchard.ContentEditors.Constants;
using Smartent.Orchard.ContentEditors.Indexing;
using Smartent.Orchard.ContentEditors.Migrations;
using Smartent.Orchard.ContentEditors.Models;
using Smartent.Orchard.ContentEditors.Services;
using Smartent.Core.Primitives.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.ContentManagement;
using OrchardCore.Data;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;
using OrchardCore.ResourceManagement;

namespace Smartent.Orchard.ContentEditors;

[Feature(FeatureIds.AsyncEditor)]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddLazyInjectionSupport();
        services.AddTransient<IConfigureOptions<ResourceManagementOptions>, ResourceManagementOptionsConfiguration>();
        services.AddScoped(typeof(IContentItemAsyncEditorProviderServices<>), typeof(ContentItemAsyncEditorProviderServices<>));
        services.AddContentPart<AsyncEditorPart>();
        services.AddScoped<IDataMigration, AsyncEditorMigrations>();
        services.AddIndexProvider<AsyncEditorPartIndexProvider>();
        services.AddScoped<IAsyncEditorProvider<ContentItem>, DefaultContentItemAsyncEditorProvider>();
    }
}
