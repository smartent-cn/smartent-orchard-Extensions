using Smartent.Test.UI.Tests.UI.TestCases;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.UITestingToolboxTests;

public class SecurityShortcutsTests : UITestBase
{
    public SecurityShortcutsTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task AddUserToRoleShouldWork() =>
        SecurityShortcutsTestCases.AddUserToRoleShouldWorkAsync(TestBuilder);

    [Fact]
    public Task AddUserToFakeRoleShouldThrow() =>
        SecurityShortcutsTestCases.AddUserToFakeRoleShouldThrowAsync(TestBuilder);

    [Fact]
    public Task AllowFakePermissionToRoleShouldThrow() =>
        SecurityShortcutsTestCases.AllowFakePermissionToRoleShouldThrowAsync(TestBuilder);
}
