using OrchardCore.DisplayManagement.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Smartent.Orchard.Platform.ResourceManagement;

/// <summary>
/// An extension point for <see cref="ResourceFilterMiddleware"/> to add or remove themes from the current theme list.
/// </summary>
public interface IResourceFilterThemeResolver
{
    /// <summary>
    /// Updates the <paramref name="themeNames"/>, if needed.
    /// </summary>
    public Task UpdateThemeNamesAsync(
        IList<string> themeNames,
        IDictionary<string, IThemeExtensionInfo> themes,
        IList<ResourceFilterMiddleware.ProviderInfo> providers);
}
