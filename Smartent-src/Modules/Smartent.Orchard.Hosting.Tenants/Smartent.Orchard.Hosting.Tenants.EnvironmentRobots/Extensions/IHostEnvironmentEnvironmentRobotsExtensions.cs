using Smartent.Orchard.Hosting.Tenants.EnvironmentRobots.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace Smartent.Orchard.Hosting.Tenants.EnvironmentRobots.Extensions;
public static class IHostEnvironmentEnvironmentRobotsExtensions
{
    public static bool IsProductionWithConfiguration(
        this IHostEnvironment hostEnvironment,
        IOptions<EnvironmentRobotsOptions> options) =>
        options.Value.IsProduction ?? hostEnvironment.IsProduction();
}
