using Smartent.Orchard.Theme.Base.Tests.UI.Extensions;
using Smartent.Test.UI.Extensions;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.ThemeTests;

public class BehaviorBaseThemeTests : UITestBase
{
    public BehaviorBaseThemeTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task ThemeFeaturesShouldWork() => TestBuilder
        .AddConfiguration(configuration => configuration.SetupConfiguration.SetupWithHttpClient = false)
        .RunAsync(async context =>
        {
            await context.SignInDirectlyAsync();
            await context.TestBaseThemeFeaturesAsync();

            await context.SignInDirectlyAsync();
            await context.TestBaseThemeSiteSettingsAsync();
        });
}
