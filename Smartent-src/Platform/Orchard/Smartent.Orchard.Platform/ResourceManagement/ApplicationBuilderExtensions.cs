using Microsoft.AspNetCore.Builder;

namespace Smartent.Orchard.Platform.ResourceManagement;

public static class ApplicationBuilderExtensions
{
    /// <summary>
    /// Activates <see cref="ResourceFilterMiddleware"/>.
    /// </summary>
    public static void UseResourceFilters(this IApplicationBuilder app) => app.UseMiddleware<ResourceFilterMiddleware>();
}
