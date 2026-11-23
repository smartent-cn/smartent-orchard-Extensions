using Smartent.Test.UI;
using Smartent.Test.UI.Constants;
using Smartent.Test.UI.Samples.Helpers;
using Smartent.Test.UI.Services;
using Xunit;

namespace Smartent.Test.Acceptance;

public abstract class UITestBase : OrchardCoreUITestBase<Program>
{
    protected UITestBase(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper) =>
        UseSetup(SetupHelpers.RunSetupAsync);

    protected override void Configure(OrchardCoreUITestExecutorConfiguration configuration)
    {
        base.Configure(configuration);
        ChangeConfiguration(configuration);
    }

    protected static void ChangeConfiguration(OrchardCoreUITestExecutorConfiguration configuration)
    {
        configuration.BrowserConfiguration.DefaultBrowserSize = CommonDisplayResolutions.HdPlus;

        configuration.BrowserConfiguration.Headless =
            TestConfigurationManager.GetBoolConfiguration("BrowserConfiguration:Headless", defaultValue: false);
    }
}
