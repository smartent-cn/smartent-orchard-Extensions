using Smartent.Orchard.Platform.ResourceManagement;
using Smartent.Orchard.VueJs.Resources.Constants;

namespace Smartent.Orchard.VueJs.Resources;

public class ResourceFilterProvider : IResourceFilterProvider
{
    public void AddResourceFilter(ResourceFilterBuilder builder) =>
        builder.Always().RegisterHeadScript(ResourceNames.SetupEnvironment);
}
