using Smartent.Orchard.TrainingDemo.Fields;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata.Models;

namespace Smartent.Orchard.TrainingDemo.ViewModels;

public class DisplayColorFieldViewModel
{
    public ColorField Field { get; set; }
    public ContentPart Part { get; set; }
    public ContentPartFieldDefinition PartFieldDefinition { get; set; }
}
