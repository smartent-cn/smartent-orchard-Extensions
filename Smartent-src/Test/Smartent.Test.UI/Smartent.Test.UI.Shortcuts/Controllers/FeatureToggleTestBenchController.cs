using Microsoft.AspNetCore.Mvc;
using OrchardCore.Modules;

namespace Smartent.Test.UI.Shortcuts.Controllers;

[Feature(ShortcutsFeatureIds.FeatureToggleTestBench)]
public sealed class FeatureToggleTestBenchController : Controller
{
    public IActionResult Index() => Content("The Feature Toggle Test Bench worked.");
}
