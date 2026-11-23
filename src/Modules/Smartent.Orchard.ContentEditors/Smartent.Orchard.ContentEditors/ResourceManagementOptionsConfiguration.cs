using Smartent.Orchard.ContentEditors.Constants;
using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;
using static Smartent.Orchard.ContentEditors.Constants.FeatureIds;

namespace Smartent.Orchard.ContentEditors;

public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
{
    private static readonly ResourceManifest _manifest = new();

    static ResourceManagementOptionsConfiguration() =>
        _manifest
            .DefineScriptModule(ResourceNames.AsyncEditor)
            .SetUrl($"~/{Area}/js/async-editor.mjs")
            .SetDependencies("vue-router")
            .SetVersion("2.0.0");

    public void Configure(ResourceManagementOptions options) => options.ResourceManifests.Add(_manifest);
}
