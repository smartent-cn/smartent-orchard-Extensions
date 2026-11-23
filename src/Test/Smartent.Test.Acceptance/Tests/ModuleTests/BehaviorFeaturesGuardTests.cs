using Smartent.Orchard.Hosting.Tenants.FeaturesGuard.Tests.UI.Extensions;
using Smartent.Test.UI.Extensions;
using Smartent.Test.UI.Helpers;
using Smartent.Test.UI.Samples.Helpers;
using Smartent.Test.UI.Services;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.ModuleTests;

public class BehaviorFeaturesGuardTests : UITestBase
{
    public BehaviorFeaturesGuardTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper) =>
        AddAsyncConfiguration(ConfigurationHelper.DisableHtmlValidation);

    // HTML validation is disabled as OC's login and dashboard pages contain several errors. See:
    // https://github.com/OrchardCMS/OrchardCore/issues/12271.
    [Fact]
    public Task ForbiddenFeaturesShouldNotBeActivatableOnTenants() =>
        RunAsync(async context =>
        {
            await BeforeTestAsync(context);
            await context.TestForbiddenFeaturesAsync(SetupHelpers.RecipeId);
        });

    // HTML validation is disabled as OC's login and dashboard pages contain several errors. See:
    // https://github.com/OrchardCMS/OrchardCore/issues/12271.
    [Fact]
    public Task ConditionallyEnabledFeaturesShouldWorkCorrectlyOnTenants() =>
        RunAsync(async context =>
        {
            await BeforeTestAsync(context);
            await context.TestConditionallyEnabledFeaturesAsync(SetupHelpers.RecipeId);
        });

    private static Task BeforeTestAsync(UITestContext context) =>
        context.ExecuteRecipeDirectlyAsync("Smartent.Demo.Tests.FeaturesGuard");
}
