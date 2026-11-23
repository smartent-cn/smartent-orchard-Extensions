using Smartent.Orchard.JsonEditor.Tests.UI.Extensions;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.ModuleTests;

public class BehaviorJsonEditorTests : UITestBase
{
    public BehaviorJsonEditorTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task JsonEditorShouldWorkCorrectly() =>
        RunAsync(context => context.TestJsonEditorBehaviorAsync());
}
