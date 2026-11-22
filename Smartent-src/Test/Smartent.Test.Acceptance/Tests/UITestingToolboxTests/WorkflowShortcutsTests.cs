using Smartent.Test.UI.Tests.UI.TestCases;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.UITestingToolboxTests;

public class WorkflowShortcutsTests : UITestBase
{
    public WorkflowShortcutsTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task GenerateHttpEventUrlShouldWork() =>
        WorkflowShortcutsTestCases.GenerateHttpEventUrlShouldWorkAsync(TestBuilder);
}
