using OrchardCore.DisplayManagement;
using System.Threading.Tasks;

namespace Smartent.Orchard.Platform.Shapes;

/// <summary>
/// Renders shapes to <see langword="string"/>.
/// </summary>
public interface IShapeRenderer
{
    /// <summary>
    /// Renders shapes to <see langword="string"/>.
    /// </summary>
    Task<string> RenderAsync(IShape shape);
}
