using Microsoft.AspNetCore.Mvc.ModelBinding;
using OrchardCore.ContentManagement;

namespace Smartent.Orchard.UIKit.Widgets.ViewModels;

public class CarouselWidgetPartViewModel
{
    [BindNever]
    public ContentItem? ContentItem { get; set; }
}
