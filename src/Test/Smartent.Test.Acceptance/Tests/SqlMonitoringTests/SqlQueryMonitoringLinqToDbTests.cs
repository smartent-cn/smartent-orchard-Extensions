using Smartent.Test.UI.Tests.UI.TestCases;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.SqlMonitoringTests;

public class SqlQueryMonitoringLinqToDbTests : Smartent.Test.UI.Samples.UITestBase
{
    public SqlQueryMonitoringLinqToDbTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task LinqToDbSamplesShouldBeCapturedBySqlMonitoring() =>
        SqlQueryMonitoringTestCases.LinqToDbSamplesShouldBeCapturedBySqlMonitoringAsync(TestBuilder);
}
