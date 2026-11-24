using Smartent.Orchard.Platform.ResourceManagement;
using static Smartent.Orchard.UIKit.Constants.ResourceNames;

namespace Smartent.Orchard.UIKit;

public class ResourceManagementOptionsConfiguration : ResourceManagementOptionsConfiguratorBase
{
    protected override string Area => FeatureIds.Base;

    protected override void Configure(ResourceManagementContext context)
    {
        context.DefineVendorScript(Slick, ("slick/slick.min.js", "slick/slick.js"), "jQuery");
        context.DefineVendorStyle(Slick, ("slick/slick.min.css", "slick/slick.css"));
        context.DefineVendorStyle(SlickTheme, ("slick/slick-theme.min.css", "slick/slick-theme.css"), Slick);

        context.DefineScript(SmartentDropdownScript, "dropdown-editor.js");
        context.DefineScript(SmartentTextBoxScript, "textbox-editor.js");
        context.DefineScript(SmartentSlickCarousel, "slick-carousel.js", Slick);

        context.DefineStyle(SmartentUiKitEditorStyle, "ui-kit-editor.css");
        context.DefineStyle(SmartentShowcaseStyle, "showcase.css");
    }
}
