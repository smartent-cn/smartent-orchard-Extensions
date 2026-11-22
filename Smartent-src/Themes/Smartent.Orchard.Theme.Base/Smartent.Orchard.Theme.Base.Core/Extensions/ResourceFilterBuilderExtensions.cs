using Smartent.Orchard.Theme.Base.Core.Constants;

namespace Smartent.Orchard.Platform.ResourceManagement;

public static class ResourceFilterBuilderExtensions
{
    /// <summary>
    /// Registers common resources between different Smartent.Orchard.Theme.Base implementations.
    /// </summary>
    public static ResourceFilter RegisterBaseThemeCoreResources(this ResourceFilter builder) =>
        builder
            .RegisterStylesheet(ResourceNames.Bootstrap)
            .RegisterHeadScript(ResourceNames.Bootstrap)
            .RegisterStylesheet(ResourceNames.General)
            .RegisterStylesheet(ResourceNames.Helpers)
            .RegisterStylesheet(ResourceNames.NativeVariables);
}
