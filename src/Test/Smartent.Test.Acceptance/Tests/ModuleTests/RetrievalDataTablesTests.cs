using Smartent.Orchard.DataTables.Tests.UI;
using Smartent.Orchard.DataTables.Tests.UI.Extensions;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.ModuleTests;

public class BehaviorDataTablesTests : UITestBase
{
    public BehaviorDataTablesTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Theory]
    [InlineData(TestDataTableRecipeDataSections.MainMenu)]
    [InlineData(TestDataTableRecipeDataSections.TagHelper)]
    [InlineData(TestDataTableRecipeDataSections.ProviderWithShape)]
    [InlineData(TestDataTableRecipeDataSections.JsonBasedProvider)]
    [InlineData(TestDataTableRecipeDataSections.IndexBasedProvider)]
    public Task RecipeDataShouldBeDisplayedCorrectly(TestDataTableRecipeDataSections sections) => TestBuilder
        .AddConfiguration(configuration => configuration
            .HtmlValidationConfiguration
            .WithRelativeConfigPath($"{nameof(RecipeDataShouldBeDisplayedCorrectly)}.htmlvalidate.json"))
        .RunAsync(context => context.TestDataTableRecipeDataAsync(sections));
}
