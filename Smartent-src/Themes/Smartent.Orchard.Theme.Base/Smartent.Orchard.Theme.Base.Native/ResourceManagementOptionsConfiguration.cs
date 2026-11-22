using Smartent.Orchard.Theme.Base.Native.Constants;
using Smartent.Orchard.Platform.ResourceManagement;
using CoreResourceNames = Smartent.Orchard.Theme.Base.Core.Constants.ResourceNames;

namespace Smartent.Orchard.Theme.Base.Native;

public class ResourceManagementOptionsConfiguration : ResourceManagementOptionsConfiguratorBase
{
    protected override string Area => FeatureIds.Area;

    protected override void Configure(ResourceManagementContext context)
    {
        context.DefineStyle(
            ResourceNames.NativeVariables,
            "abstract/native-variables.css",
            CoreResourceNames.NativeVariables);

        context.DefineStyle(
            ResourceNames.Flow,
            "general/flow.css",
            ResourceNames.NativeVariables);

        context.DefineStyle(
            ResourceNames.Spacing,
            "general/spacing.css",
            ResourceNames.NativeVariables);

        context.DefineStyle(
            ResourceNames.General,
            "general/general.css",
            CoreResourceNames.General,
            CoreResourceNames.Helpers,
            CoreResourceNames.NativeVariables,
            ResourceNames.NativeVariables,
            ResourceNames.Flow,
            ResourceNames.Spacing);

        context.DefineScript(ResourceNames.GridBreakpoints, "grid-breakpoints.js");
    }
}
