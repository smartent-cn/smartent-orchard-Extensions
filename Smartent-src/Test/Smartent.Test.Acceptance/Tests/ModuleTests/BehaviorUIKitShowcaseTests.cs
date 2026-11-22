using Smartent.Orchard.UIKit.Tests.UI.Extensions;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.ModuleTests;

public class BehaviorUIKitShowcaseTests : UITestBase
{
    public BehaviorUIKitShowcaseTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper) =>
        AddConfiguration(configuration => configuration.HtmlValidationConfiguration
            .WithRelativeConfigPath("NoUniqueLandmark.htmlvalidate.json")
            .WithOC15222Filter());

    [Fact]
    public Task UIKitShowcasePageShouldBeCorrect() =>
        RunAsync(context => context.TestUIKitShowcaseBehaviorAsync());
}
