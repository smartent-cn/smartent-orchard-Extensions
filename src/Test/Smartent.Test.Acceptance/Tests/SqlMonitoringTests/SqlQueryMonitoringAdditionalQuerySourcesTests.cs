using Smartent.Test.UI.Tests.UI.TestCases;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.SqlMonitoringTests;

public class SqlQueryMonitoringAdditionalQuerySourcesTests : Smartent.Test.UI.Samples.UITestBase
{
    public SqlQueryMonitoringAdditionalQuerySourcesTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task SqlQueryMonitoringAdditionalQuerySourcesShouldWork() =>
        SqlQueryMonitoringTestCases.SqlQueryMonitoringAdditionalQuerySourcesShouldWorkAsync(TestBuilder);
}
