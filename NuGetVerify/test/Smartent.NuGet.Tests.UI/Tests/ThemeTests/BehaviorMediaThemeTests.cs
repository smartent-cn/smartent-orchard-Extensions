using Lombiq.Hosting.MediaTheme.Bridge.Tests.UI.Extensions;
using Lombiq.Hosting.MediaTheme.Tests.UI.Extensions;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.NuGet.Tests.UI.Tests.ThemeTests;

public class BehaviorMediaThemeTests : UITestBase
{
    public BehaviorMediaThemeTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task MediaThemeShouldRenderTemplatesFromMediaLibrary() =>
        RunAsync(context => context.TestMediaThemeDeployedBehaviorAsync());

    [Fact]
    public Task MediaThemeTemplateAccessShouldBeBlocked() =>
        RunAsync(async context => await context.TestMediaThemeTemplatePageAsync());
}
