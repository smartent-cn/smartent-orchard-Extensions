using System.Collections.Generic;

namespace Smartent.Orchard.Extensions.Cms.Extensions.Widgets.ViewModels;

public class MvcConditionViewModel
{
    public string Area { get; set; }
    public string Controller { get; set; }
    public string Action { get; set; }

    public IList<string> OtherRouteNames { get; } = [];
    public IList<string> OtherRouteValues { get; } = [];
}
