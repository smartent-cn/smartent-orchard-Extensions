using OrchardCore.ContentManagement;

namespace Smartent.Orchard.Privacy.Models;

public class PrivacyConsentCheckboxPart : ContentPart
{
    public bool ConsentCheckbox { get; set; }
    public bool? ShowAlways { get; set; }
}
