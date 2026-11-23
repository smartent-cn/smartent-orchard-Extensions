using Smartent.Test.UI.Tests.UI.TestCases;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.SqlMonitoringTests;

public class SqlQueryMonitoringTenantTests : Smartent.Test.UI.Samples.UITestBase
{
    public SqlQueryMonitoringTenantTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task SqlQueryMonitoringShouldWorkOnAnotherTenant() =>
        SqlQueryMonitoringTestCases.SqlQueryMonitoringShouldWorkOnAnotherTenantAsync(TestBuilder);
}
