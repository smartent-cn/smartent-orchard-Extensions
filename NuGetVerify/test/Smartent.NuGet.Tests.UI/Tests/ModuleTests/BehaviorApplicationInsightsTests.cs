using Smartent.Orchard.Hosting.ApplicationInsights.Tests.UI.TestCases;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.NuGet.Tests.UI.Tests.ModuleTests;

public class BehaviorApplicationInsightsTests : UITestBase
{
    public BehaviorApplicationInsightsTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task ApplicationInsightsTrackingInOfflineOperationShouldWork() =>
        ApplicationInsightsTestCases.ApplicationInsightsTrackingInOfflineOperationShouldWorkAsync(this);
}
