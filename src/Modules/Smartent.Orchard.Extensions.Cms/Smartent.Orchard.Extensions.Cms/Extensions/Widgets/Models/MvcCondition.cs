using OrchardCore.Rules;
using System.Collections.Generic;

namespace Smartent.Orchard.Extensions.Cms.Extensions.Widgets.Models;

public class MvcCondition : Condition
{
    public string Area { get; set; }
    public string Controller { get; set; }
    public string Action { get; set; }
    public IDictionary<string, string> OtherRouteValues { get; } = new Dictionary<string, string>();
}
