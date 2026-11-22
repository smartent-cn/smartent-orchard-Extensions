using Smartent.Orchard.ContentEditors.Tests.UI.Extensions;
using Smartent.Test.UI.Extensions;
using Smartent.Test.UI.Helpers;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.ModuleTests;

public class BehaviorAsyncEditorTests : UITestBase
{
    public BehaviorAsyncEditorTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task DemoContentItemAsyncEditorShouldWork() =>
        RunAsync(async context =>
        {
            await context.SignInDirectlyAsync();
            await context.TestDemoContentItemAsyncEditorAsync();
        });

    [Fact]
    public Task DemoFrontEndAsyncEditorShouldWork() => TestBuilder
        .AddAsyncConfiguration(ConfigurationHelper.DisableHtmlValidation)
        .RunAsync(async context =>
        {
            await context.SignInDirectlyAsync();
            await context.TestDemoFrontEndAsyncEditorAsync();
        });
}
