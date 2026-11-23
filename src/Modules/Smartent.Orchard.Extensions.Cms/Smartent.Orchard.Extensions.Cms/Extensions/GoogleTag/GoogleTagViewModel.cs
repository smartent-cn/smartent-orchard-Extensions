using OrchardCore.DisplayManagement.Views;

namespace Smartent.Orchard.Extensions.Cms.Extensions.GoogleTag;

public class GoogleTagViewModel : ShapeViewModel
{
    public const string ShapeType = "GoogleTag";

    public string GoogleTagPropertyId { get; set; }
    public string CookieDomain { get; set; }

    public GoogleTagViewModel() => Metadata.Type = ShapeType;

    public GoogleTagViewModel(string googleTagPropertyId, string cookieDomain)
        : this()
    {
        GoogleTagPropertyId = googleTagPropertyId;
        CookieDomain = cookieDomain;
    }
}
