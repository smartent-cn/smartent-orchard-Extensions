using Smartent.Orchard.JsonEditor.Tests.UI.Extensions;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.NuGet.Tests.UI.Tests.ModuleTests;

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
