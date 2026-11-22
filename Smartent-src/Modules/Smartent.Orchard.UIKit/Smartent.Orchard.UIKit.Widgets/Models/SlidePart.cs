using OrchardCore.ContentManagement;
using OrchardCore.Media.Fields;

namespace Smartent.Orchard.UIKit.Widgets.Models;

public class SlidePart : ContentPart
{
    public MediaField Image { get; set; } = new();
}
