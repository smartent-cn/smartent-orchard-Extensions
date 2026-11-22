using Smartent.Test.UI.BasicOrchardFeaturesTesting;
using Smartent.Test.UI.Models;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.NuGet.Tests.UI.Tests;

public class BasicOrchardFeaturesTests : UITestBase
{
    public BasicOrchardFeaturesTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper) =>
        WithoutSetup();

    [Fact]
    public Task BasicOrchardFeaturesShouldWork() =>
        RunAsync(context => context.TestBasicOrchardFeaturesAsync(
            new OrchardCoreSetupParameters(context, "Smartent.NuGet.BasicOrchardFeaturesTests")
            {
                SkipRegistration = true,
            }));
}
