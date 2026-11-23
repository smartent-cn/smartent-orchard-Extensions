using Smartent.Build.Targets.Tests.UI.Extensions;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.UtilityTests;

public class BehaviorMSBuildTests : UITestBase
{
    public BehaviorMSBuildTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task SdkUsingThemeShouldBeRecognizedByOrchardCore() => TestBuilder
        .AddConfiguration(configuration =>
            configuration.HtmlValidationConfiguration.RunHtmlValidationAssertionOnAllPageChanges = false)
        .RunAsync(context => context.TestSdkUsingThemeAsync());
}
