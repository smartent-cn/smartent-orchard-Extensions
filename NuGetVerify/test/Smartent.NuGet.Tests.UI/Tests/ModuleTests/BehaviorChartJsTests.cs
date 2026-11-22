using Smartent.Orchard.ChartJs.Tests.UI.Extensions;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.NuGet.Tests.UI.Tests.ModuleTests;

public class BehaviorChartJsTests : UITestBase
{
    public BehaviorChartJsTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task RecipeDataShouldBeDisplayedCorrectly() =>
        RunAsync(context => context.TestChartJsSampleBehaviorAsync());
}
