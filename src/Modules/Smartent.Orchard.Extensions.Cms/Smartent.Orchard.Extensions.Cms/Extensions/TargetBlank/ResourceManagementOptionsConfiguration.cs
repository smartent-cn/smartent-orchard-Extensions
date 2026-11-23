using Smartent.Orchard.Extensions.Cms.Constants;
using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace Smartent.Orchard.Extensions.Cms.Extensions.TargetBlank;

public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
{
    private const string WwwRoot = "~/" + FeatureIds.Base + "/";
    private const string ScriptRoot = WwwRoot + "js/";
    private static readonly ResourceManifest _manifest = new();

    static ResourceManagementOptionsConfiguration() =>
        _manifest
            .DefineScript(ResourceNames.TargetBlank)
            .SetUrl(ScriptRoot + "target-blank.js")
            .SetVersion("1.0.0");

    public void Configure(ResourceManagementOptions options) => options.ResourceManifests.Add(_manifest);
}
