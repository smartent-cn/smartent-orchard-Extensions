using OrchardCore.ContentManagement;

namespace Smartent.Orchard.Extensions.Cms.Extensions.Flows.Models;

public class AdditionalStylingPart : ContentPart
{
    public string CustomClasses { get; set; }
    public bool RemoveGridExtensionClasses { get; set; }
}
