using Smartent.Test.UI.Tests.UI.TestCases;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.SqlMonitoringTests;

public class SqlQueryMonitoringRequestMatchingTests : Smartent.Test.UI.Samples.UITestBase
{
    public SqlQueryMonitoringRequestMatchingTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task SqlQueryMonitoringRequestMatchingScenariosShouldWork() =>
        SqlQueryMonitoringTestCases.SqlQueryMonitoringRequestMatchingScenariosShouldWorkAsync(TestBuilder);
}
