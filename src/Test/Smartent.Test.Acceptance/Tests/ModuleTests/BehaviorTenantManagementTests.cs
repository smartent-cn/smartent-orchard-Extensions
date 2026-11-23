using Smartent.Orchard.Hosting.Tenants.Management.Tests.UI.Extensions;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.ModuleTests;

public class BehaviorTenantManagementTests : UITestBase
{
    public BehaviorTenantManagementTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task TenantShellSettingsEditorShouldSaveSettings() =>
        RunAsync(context => context.TestShellSettingsEditorFeatureAsync());
}
