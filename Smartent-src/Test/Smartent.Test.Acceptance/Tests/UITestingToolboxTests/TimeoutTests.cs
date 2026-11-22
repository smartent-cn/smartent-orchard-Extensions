using Smartent.Test.UI.Tests.UI.TestCases;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.UITestingToolboxTests;

public class TimeoutTests : UITestBase
{
    public TimeoutTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task TestRunTimeoutShouldThrowAsync() =>
        TimeoutTestCases.TestRunTimeoutShouldThrowAsync(TestBuilder);
}
