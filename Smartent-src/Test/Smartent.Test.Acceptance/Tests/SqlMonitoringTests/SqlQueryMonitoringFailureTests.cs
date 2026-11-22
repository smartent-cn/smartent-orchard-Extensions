using Smartent.Test.UI.Tests.UI.TestCases;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.SqlMonitoringTests;

public class SqlQueryMonitoringFailureTests : Smartent.Test.UI.Samples.UITestBase
{
    public SqlQueryMonitoringFailureTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task SqlQueryMonitoringFailureScenariosShouldWork() =>
        SqlQueryMonitoringTestCases.SqlQueryMonitoringFailureScenariosShouldWorkAsync(TestBuilder);
}
