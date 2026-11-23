using Smartent.Test.UI.Extensions;
using Smartent.Test.UI.Helpers;
using Smartent.Test.UI.Shortcuts;
using Shouldly;

namespace Smartent.Test.UI.Tests.UI.TestCases;

public static class WorkflowShortcutsTestCases
{
    public static Task GenerateHttpEventUrlShouldWorkAsync(UITestBase fixture) => fixture
        .AddTest(async context =>
        {
            await context.EnableFeatureDirectlyAsync(ShortcutsFeatureIds.Workflows);
            await context.ExecuteRecipeDirectlyAsync("Smartent.Test.UI.Tests.UI.WorkflowShortcutsTests");
            (await context.GenerateHttpEventUrlAsync("testworkflow000000", "testhttpevent00000"))
                .ShouldStartWith("/workflows/Invoke?token=");
        })
        .AddAsyncConfiguration(ConfigurationHelper.DisableHtmlValidation)
        .RunAsync();
}
