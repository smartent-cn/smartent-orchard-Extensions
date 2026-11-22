using Smartent.Orchard.Marketing.UrlShortener.Models;
using System.Threading.Tasks;

namespace Smartent.Orchard.Marketing.UrlShortener.Services;

/// <summary>
/// Handles a marketing hit created from a short URL redirect.
/// </summary>
public interface IShortUrlHitHandler
{
    /// <summary>
    /// Processes the short URL hit.
    /// </summary>
    /// <param name="context">The hit data.</param>
    Task HandleHitAsync(ShortUrlHitContext context);
}
