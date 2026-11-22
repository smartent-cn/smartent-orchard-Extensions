using Smartent.Orchard.Platform.Contents;
using OrchardCore.ContentManagement;

namespace Smartent.Orchard.UIKit.Widgets.Models;

public class RandomWidget : ContentPart
{
    public IEnumerable<string>? ContentTypes { get; set; }
    public string? DisplayType { get; set; } = CommonContentDisplayTypes.Summary;
    public string? GroupId { get; set; }
    public int Count { get; set; } = 1;
}
