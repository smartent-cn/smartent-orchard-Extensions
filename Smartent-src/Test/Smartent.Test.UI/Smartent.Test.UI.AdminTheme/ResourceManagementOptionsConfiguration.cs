using Smartent.Orchard.Platform.ResourceManagement;
using Smartent.Test.UI.AdminTheme.Constants;

namespace Smartent.Test.UI.AdminTheme;

public class ResourceManagementOptionsConfiguration : ResourceManagementOptionsConfiguratorBase
{
    protected override string Area => FeatureIds.Area;

    protected override void Configure(ResourceManagementContext context) =>
        context.DefineStyle(ResourceNames.General, "general.css");
}
