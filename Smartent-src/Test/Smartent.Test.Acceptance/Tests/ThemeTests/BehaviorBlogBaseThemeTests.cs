using Smartent.Orchard.Theme.Base.Tests.UI.Extensions;
using Smartent.Test.Acceptance.Helpers;
using Smartent.Test.UI.Extensions;
using Smartent.Test.UI.Services;
using OpenQA.Selenium;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.ThemeTests;

// Different tests with different setups should not be run at the same time, as it upsets the shape table so shapes
// would be seen as missing even when their feature is enabled.
[Collection(nameof(BehaviorBlogBaseThemeTests))]
[CollectionDefinition(nameof(BehaviorBlogBaseThemeTests), DisableParallelization = true)]
public class BehaviorBlogBaseThemeTests : UITestBase
{
    public BehaviorBlogBaseThemeTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper) =>
        UseSetup(async context =>
        {
            var homePageUri = await SetupHelpers.RunBlogSetupAsync(context);

            await context.SignInDirectlyAsync();

            await context.GoToAdminRelativeUrlAsync("/Themes");

            await context.ClickReliablyOnAsync(By.CssSelector(
                "form[action*='SetCurrentTheme/Smartent.Orchard.Theme.Base.Native.Samples'] button"));
            context.ShouldBeSuccess();

            return homePageUri;
        });

    [Fact]
    public Task ThemeWithoutSetupShouldWork() =>
        RunAsync(
            async context =>
            {
                await context.SignInDirectlyAsync();
                await context.TestBaseThemeDependencyIsEnabledAsync();

                await context.GoToHomePageAsync();
                await context.TestBaseThemeFeaturesAsync(skipLogin: true);
                await context.SignInDirectlyAndGoToHomepageAsync();

                context.TestBlogRecipeMenuItemsAddedToMainMenu();
            });

    [Fact]
    public Task ContentMenuItemShouldWorkCorrectly() =>
        RunAsync(
            async context =>
            {
                await context.SignInDirectlyAsync();
                await context.TestAddingMenuItemToBlogMainMenuAsync();
            });

    protected override void Configure(OrchardCoreUITestExecutorConfiguration configuration)
    {
        base.Configure(configuration);

        // Disable HTML validation, because we have no control over the HTML in the Blog and the content added
        // by the Blog recipe.
        configuration.HtmlValidationConfiguration.RunHtmlValidationAssertionOnAllPageChanges = false;
    }
}
