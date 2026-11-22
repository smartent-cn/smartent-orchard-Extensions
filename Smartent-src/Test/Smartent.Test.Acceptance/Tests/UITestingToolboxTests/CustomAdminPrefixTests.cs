using Smartent.Test.UI.Tests.UI.TestCases;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.UITestingToolboxTests;

public class CustomAdminPrefixTests : UITestBase
{
    public CustomAdminPrefixTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task NavigationWithCustomAdminPrefixShouldWork() =>
        CustomAdminPrefixTestCases.NavigationWithCustomAdminPrefixShouldWorkAsync(TestBuilder);
}
