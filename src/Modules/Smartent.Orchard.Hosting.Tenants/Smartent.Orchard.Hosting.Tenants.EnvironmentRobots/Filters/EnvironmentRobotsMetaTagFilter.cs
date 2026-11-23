using Smartent.Orchard.Hosting.Tenants.EnvironmentRobots.Extensions;
using Smartent.Orchard.Hosting.Tenants.EnvironmentRobots.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace Smartent.Orchard.Hosting.Tenants.EnvironmentRobots.Filters;

public class EnvironmentRobotsMetaTagFilter : IResultFilter
{
    private readonly IHostEnvironment _hostEnvironment;
    private readonly IOptions<EnvironmentRobotsOptions> _options;
    private readonly IResourceManager _resourceManager;

    public EnvironmentRobotsMetaTagFilter(
        IHostEnvironment hostEnvironment,
        IOptions<EnvironmentRobotsOptions> options,
        IResourceManager resourceManager)
    {
        _hostEnvironment = hostEnvironment;
        _options = options;
        _resourceManager = resourceManager;
    }

    public void OnResultExecuting(ResultExecutingContext context)
    {
        if (!_hostEnvironment.IsProductionWithConfiguration(_options))
        {
            _resourceManager.RegisterMeta(new MetaEntry
            {
                Name = "robots",
                Content = "noindex, nofollow",
            });
        }
    }

    public void OnResultExecuted(ResultExecutedContext context)
    {
        // Intentionally empty. Required by interface implementation only.
    }
}
