using Smartent.Test.UI.Tests.UI.TestCases;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.SqlMonitoringTests;

public class SqlQueryMonitoringAsyncRequestTests : Smartent.Test.UI.Samples.UITestBase
{
    public SqlQueryMonitoringAsyncRequestTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task SqlQueryMonitoringAsyncRequestScenariosShouldWork() =>
        SqlQueryMonitoringTestCases.SqlQueryMonitoringAsyncRequestScenariosShouldWorkAsync(TestBuilder);
}
