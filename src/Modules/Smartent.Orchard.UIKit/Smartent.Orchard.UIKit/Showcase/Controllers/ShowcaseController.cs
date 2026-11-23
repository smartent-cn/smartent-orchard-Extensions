using Smartent.Orchard.UIKit.Showcase.Constants;
using Smartent.Orchard.UIKit.ViewModels;
using Microsoft.AspNetCore.Mvc;
using OrchardCore.Admin;
using OrchardCore.Modules;

namespace Smartent.Orchard.UIKit.Showcase.Controllers;

[Feature(FeatureIds.Showcase)]
[Admin(Routes.UIKitShowcase)]
public sealed class ShowcaseController : Controller
{
    [HttpGet]
    public IActionResult Showcase() => View(model: new ShowcaseViewModel());
}
