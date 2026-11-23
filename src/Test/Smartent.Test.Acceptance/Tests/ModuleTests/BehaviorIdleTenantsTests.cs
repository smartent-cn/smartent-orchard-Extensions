using Smartent.Orchard.Hosting.Tenants.IdleTenantManagement.Tests.UI.Extensions;
using Smartent.Test.UI.Extensions;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.ModuleTests;

public class BehaviorIdleTenantsTests : UITestBase
{
    public BehaviorIdleTenantsTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper) =>
        AddConfiguration(configuration => configuration.ConfigureIdleTenantManagementTestSettings());

    [Fact]
    public Task ShuttingDownIdleTenantsShouldWork() =>
        RunAsync(async context =>
        {
            await context.SignInDirectlyAsync();
            await context.TestIdleTenantManagerBehaviorAsync();
        });
}
