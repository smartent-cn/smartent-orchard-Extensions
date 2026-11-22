using System.Collections.Generic;

namespace Smartent.Orchard.Hosting.Tenants.FeaturesGuard.Models;

public class ConditionallyEnabledFeaturesOptions
{
    public IDictionary<string, IEnumerable<string>> EnableFeatureIfOtherFeatureIsEnabled { get; } =
        new Dictionary<string, IEnumerable<string>>();
}
