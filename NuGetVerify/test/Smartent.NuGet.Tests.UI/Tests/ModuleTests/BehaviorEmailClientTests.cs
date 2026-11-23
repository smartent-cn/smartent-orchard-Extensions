using Smartent.Orchard.EmailClient.Tests.UI.Extensions;
using Smartent.Test.UI.Extensions;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.NuGet.Tests.UI.Tests.ModuleTests;

public class BehaviorEmailClientTests : UITestBase
{
    public BehaviorEmailClientTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper) =>
        TestBuilder.UseSmtpService();

    [Fact]
    public Task ImapEmailFetchingShouldWork() =>
        RunAsync(context => context.TestImapEmailFetchingAsync());
}
