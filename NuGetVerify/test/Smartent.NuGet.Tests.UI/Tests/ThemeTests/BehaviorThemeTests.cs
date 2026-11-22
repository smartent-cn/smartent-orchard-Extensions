using Lombiq.BaseTheme.Tests.UI.Extensions;
using Smartent.Test.UI.Extensions;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.NuGet.Tests.UI.Tests.ThemeTests;

public class BehaviorThemeTests : UITestBase
{
    public BehaviorThemeTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task BaseThemeShouldWork() =>
        RunAsync(
            async context =>
            {
                await context.SignInDirectlyAsync();
                await context.ExecuteRecipeDirectlyAsync("Smartent.NuGet.BaseTheme");

                await context.GoToHomePageAsync(onlyIfNotAlreadyThere: false);
                await context.TestBaseThemeFeaturesAsync();
            });
}
