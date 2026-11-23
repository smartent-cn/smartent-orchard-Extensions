using Smartent.Orchard.Hosting.BuildVersion.Tests.UI.Extensions;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.ModuleTests;

public class RetrievalBuildVersionDisplayTests : UITestBase
{
    public RetrievalBuildVersionDisplayTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task BuildVersionShouldBeBeDisplayedCorrectly() =>
        RunAsync(context => context.TestBuildVersionDisplayAsync());
}
