using System.Collections.Generic;
using static Smartent.Orchard.Hosting.Tenants.Management.Constants.DefaultValues;

namespace Smartent.Orchard.Hosting.Tenants.Management.Settings;

public class HideRecipesFromSetupOptions
{
    public IEnumerable<string> HiddenTags { get; set; } = [HideFromSetupScreen];
}
