using Atata.HtmlValidation;
using Lombiq.Tests.UI.Extensions;
using Lombiq.Tests.UI.Models;
using Lombiq.VueJs.Samples.Controllers;
using Lombiq.VueJs.Tests.UI.Extensions;
using Shouldly;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Lombiq.OSOCE.Tests.UI.Tests.ModuleTests;

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

    [Fact]
    public Task QrCardScanShouldWorkAsync() =>
        ExecuteTestAfterSetupAsync(
            context => context.TestQrCardFoundAsync(),
            configuration =>
            {
                configuration.BrowserConfiguration.ConfigureFakeVideoSourceForPositiveTest();
                configuration.HtmlValidationConfiguration.AssertHtmlValidationResultAsync = AssertHtmlValidationResultAsync;
            });

    [Fact]
    public Task QrCardScanShouldReportNotFoundAsync() =>
        ExecuteTestAfterSetupAsync(
            context => context.TestQrCardNotFoundAsync(),
            configuration =>
            {
                configuration.BrowserConfiguration.ConfigureFakeVideoSourceForNegativeTest();
                configuration.HtmlValidationConfiguration.AssertHtmlValidationResultAsync = AssertHtmlValidationResultAsync;

                // The fetch call reports an error to the browser console if the QrCardController.GetBusinessCard()
                // action results in NotFound.
                configuration.WithIgnoreExpectedNotFoundResponseFilter(nameof(QrCardController.GetBusinessCard));
            });

    private static Task AssertHtmlValidationResultAsync(IList<HtmlValidationError> errors)
    {
        var filteredErrors = errors
            .Where(error => error.RuleId is not "no-autoplay" and not "long-title")
            .ToList();
        filteredErrors.ShouldBeEmpty(HtmlValidationResultExtensions.GetParsedErrorMessageString(filteredErrors));
        return Task.CompletedTask;
    }
}
