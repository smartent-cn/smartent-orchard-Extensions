using Smartent.Test.UI.Tests.UI.TestCases;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.SqlMonitoringTests;

public class SqlQueryMonitoringDisableCollectionTests : Smartent.Test.UI.Samples.UITestBase
{
    public SqlQueryMonitoringDisableCollectionTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task SqlQueryMonitoringShouldNotCollectWhenCollectionIsDisabled() =>
        SqlQueryMonitoringTestCases.SqlQueryMonitoringShouldNotCollectWhenCollectionIsDisabledAsync(TestBuilder);
}
