using Smartent.Orchard.Hosting.Tenants.HealthChecks.Tests.UI.Extensions;
using Smartent.Test.UI.Extensions;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Xunit;

namespace Smartent.Test.Acceptance.Tests.ModuleTests;

public class BehaviorHealthCheckTests : UITestBase
{
    public BehaviorHealthCheckTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper) =>
        AddConfiguration(configuration =>
        {
            configuration.ConfigureTenantHealthCheckTests();
            configuration.AssertAppLogsAsync = app => app.LogsShouldNotContainAsync(
                logEntry => logEntry.Level >= LogLevel.Error && logEntry.IsNotHealthCheckError(),
                configuration.TestCancellationToken);
        });

    [Fact]
    public Task UnhealthyTenantsShouldBeListed() =>
        RunAsync(context => context.TestHealthChecksAsync("Smartent.Demo.BasicOrchardFeaturesTests"));
}
