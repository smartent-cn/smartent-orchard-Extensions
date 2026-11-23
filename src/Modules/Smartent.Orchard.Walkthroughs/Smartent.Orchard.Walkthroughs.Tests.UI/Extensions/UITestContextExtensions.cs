using Smartent.Test.UI.Extensions;
using Smartent.Test.UI.Services;
using System.Threading.Tasks;

namespace Smartent.Orchard.Walkthroughs.Tests.UI.Extensions;

public static class UITestContextExtensions
{
    public static async Task RunSetupAndTestWalkthroughsBehaviorAsync(this UITestContext context)
    {
        await context.GoToSetupPageAndSetupOrchardCoreWithWalkthroughsRecipeAsync();
        await context.EnableThemeDirectlyAsync(Smartent.Test.UI.AdminTheme.Constants.FeatureIds.Area, isAdmin: true);
        await context.TestWalkthroughsBehaviorAsync();
    }

    public static Task GoToSetupPageAndSetupOrchardCoreWithWalkthroughsRecipeAsync(this UITestContext context) =>
        context.GoToSetupAndSetupOrchardCoreAsync("Smartent.Orchard.Walkthroughs.Setup");

    public static Task EnableWalkthroughsFeatureAsync(this UITestContext context) =>
        context.EnableFeatureDirectlyAsync("Smartent.Orchard.Walkthroughs");
}
