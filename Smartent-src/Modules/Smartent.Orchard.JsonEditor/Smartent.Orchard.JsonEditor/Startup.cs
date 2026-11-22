using Smartent.Orchard.Platform.DependencyInjection;
using Smartent.Orchard.JsonEditor.Constants;
using Smartent.Orchard.JsonEditor.Drivers;
using Smartent.Orchard.JsonEditor.Fields;
using Smartent.Orchard.JsonEditor.Services;
using Smartent.Orchard.JsonEditor.Settings;
using Smartent.Orchard.JsonEditor.TagHelpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.Admin;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.Modules;
using OrchardCore.ResourceManagement;

namespace Smartent.Orchard.JsonEditor;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IConfigureOptions<ResourceManagementOptions>, ResourceManagementOptionsConfiguration>();
        services.AddTagHelpers<JsonEditorTagHelper>();

        services.AddContentField<JsonField>().UseDisplayDriver<JsonFieldDisplayDriver>();
        services.AddScoped<IContentPartFieldDefinitionDisplayDriver, JsonFieldSettingsDriver>();
    }
}

[Feature(FeatureIds.ContentEditor)]
public sealed class ContentEditorStartup : StartupBase
{
    private readonly AdminOptions _adminOptions;

    public ContentEditorStartup(IOptions<AdminOptions> adminOptions) => _adminOptions = adminOptions.Value;

    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IContentDisplayDriver, EditJsonActionsMenuContentDisplayDriver>();
        services.AddOrchardServices();
        services.AddContentSecurityPolicyProvider<JsonEditorContentSecurityPolicyProvider>();
    }
}
