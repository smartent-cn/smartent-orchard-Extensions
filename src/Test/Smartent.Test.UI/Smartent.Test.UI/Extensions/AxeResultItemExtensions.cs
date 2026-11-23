#nullable enable

using Deque.AxeCore.Commons;
using Smartent.Test.UI.Services;
using Shouldly;
using System.Collections.Generic;
using System.Linq;

namespace Smartent.Test.UI.Extensions;

public static class AxeResultItemExtensions
{
    /// <summary>
    /// Asserts if <paramref name="axeResultItems"/> is empty, and if not then produces an error with <see
    /// cref="AxeResultItem"/>s converted into human-readable strings.
    /// </summary>
    public static void AxeResultItemsShouldBeEmpty(this IEnumerable<AxeResultItem?> axeResultItems)
    {
        var results = axeResultItems
            .CastWhere<AxeResultItem>()
            .ToList();

        results.ShouldBeEmpty(AccessibilityCheckingConfiguration.AxeResultItemsToString(results));
    }
}
