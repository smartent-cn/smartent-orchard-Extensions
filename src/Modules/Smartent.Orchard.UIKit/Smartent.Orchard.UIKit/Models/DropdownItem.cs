using Microsoft.AspNetCore.Mvc.Localization;

namespace Smartent.Orchard.UIKit.Models;

public class DropdownItem
{
    public LocalizedHtmlString Text { get; set; }

    public object DataState { get; set; }

    public string DataClass { get; set; }
}
