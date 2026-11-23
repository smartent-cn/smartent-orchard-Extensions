using Smartent.Test.UI.Extensions;
using Smartent.Test.UI.Services;
using OpenQA.Selenium;
using Shouldly;
using System.Threading.Tasks;

namespace Smartent.Build.Targets.Tests.UI.Extensions;

public static class UITestContextExtensions
{
    public static async Task TestSdkUsingThemeAsync(this UITestContext context)
    {
        void Validate(string cssSelector, string expected) =>
            context.Get(By.CssSelector(cssSelector)).GetTextTrimmed().ShouldBe(expected);

        await context.SignInDirectlyAsync();
        await context.GoToAdminRelativeUrlAsync("/Themes");
        await context.ClickReliablyOnAsync(By.CssSelector("form[action='/Admin/Themes/SetCurrentTheme/Smartent.Build.Sdk.Samples'] button"));

        Validate("h4.card-title", "Smartent MSBuild SDK Theme Sample");
        Validate(".theme-card p", "Minimal theme sample validating Smartent.Build.OrchardCore.Theme.Sdk.");

        await context.GoToHomePageAsync();
        context.Get(By.Id("sdk-test")).GetTextTrimmed().ShouldBe("This is a working theme!");
    }
}