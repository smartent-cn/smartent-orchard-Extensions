using Smartent.Orchard.Platform.Contents;
using OrchardCore.DisplayManagement;

namespace Smartent.Orchard.UIKit.Widgets.ViewModels;

public class RandomWidgetDisplayViewModel
{
    public IEnumerable<IShape> Shapes { get; set; } = [];
}

public class RandomWidgetEditorViewModel
{
    public IEnumerable<string> AvailableContentTypes { get; set; } = [];
    public IEnumerable<string> SelectedContentTypes { get; set; } = [];
    public string? DisplayType { get; set; } = CommonContentDisplayTypes.Summary;
    public string? GroupId { get; set; }
    public int Count { get; set; } = 1;
}
