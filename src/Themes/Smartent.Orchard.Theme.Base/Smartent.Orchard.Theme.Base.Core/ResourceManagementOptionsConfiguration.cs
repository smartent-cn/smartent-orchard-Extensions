using Smartent.Orchard.Theme.Base.Core.Constants;
using Smartent.Orchard.Platform.ResourceManagement;

namespace Smartent.Orchard.Theme.Base.Core;

public class ResourceManagementOptionsConfiguration : ResourceManagementOptionsConfiguratorBase
{
    protected override string Area => FeatureIds.Area;

    protected override void Configure(ResourceManagementContext context)
    {
        context.DefineStyle(ResourceNames.NativeVariables, "native-variables.css");
        context.DefineStyle(ResourceNames.Helpers, "helpers.css");
        context.DefineStyle(ResourceNames.General, "general.css", ResourceNames.NativeVariables, ResourceNames.Helpers);
    }
}
