using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;

namespace Smartent.Orchard.VueJs.Samples.Models;

public class BusinessCard : ContentPart
{
    public TextField FirstName { get; set; }
    public TextField LastName { get; set; }
    public TextField Email { get; set; }
    public TextField Phone { get; set; }
}
