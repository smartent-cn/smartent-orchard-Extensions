using OrchardCore.ResourceManagement;
using static Smartent.Orchard.VueJs.Constants.ResourceTypes;

namespace Smartent.Orchard.VueJs.Extensions;

public static class ResourceManifestExtensions
{
    public static ResourceDefinition DefineSingleFileComponent(this ResourceManifest manifest, string name) =>
        manifest.DefineResource(SingleFileComponent, name);
}
