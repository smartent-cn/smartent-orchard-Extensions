using Smartent.Test.UI.Extensions;
using Smartent.Orchard.VueJs.Tests.UI.Extensions;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.NuGet.Tests.UI.Tests.ModuleTests;

public class BehaviorVueTests : UITestBase
{
    public BehaviorVueTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task RecipeDataShouldBeDisplayedCorrectly() =>
        ExecuteTestAfterSetupAsync(
            async context =>
            {
                await context.SignInDirectlyAsync();
                await context.TestVueSampleBehaviorAsync();
            });
}
