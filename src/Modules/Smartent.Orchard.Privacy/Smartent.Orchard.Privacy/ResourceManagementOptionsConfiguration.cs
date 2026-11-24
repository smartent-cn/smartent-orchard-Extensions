using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;
using static Smartent.Orchard.Privacy.Constants.ResourceNames;

namespace Smartent.Orchard.Privacy;

public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
{
    private static readonly ResourceManifest _manifest = new();

    static ResourceManagementOptionsConfiguration() =>
        _manifest
            .DefineStyle(ConsentBanner)
            .SetUrl("~/Smartent.Orchard.Privacy/css/smartent-privacy-consent-banner.css");

    public void Configure(ResourceManagementOptions options) => options.ResourceManifests.Add(_manifest);
}
