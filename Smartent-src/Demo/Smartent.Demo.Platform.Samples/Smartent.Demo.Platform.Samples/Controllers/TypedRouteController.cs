using Microsoft.AspNetCore.Mvc;
using System;

namespace Smartent.Demo.Platform.Samples.Controllers;

public sealed class TypedRouteController : Controller
{
    // Open this from under /Smartent.Demo.Platform.Samples/TypedRoute/Index
    public ActionResult Index() => View();

    public ActionResult TypedRouteSample(string text, int number) =>
        ModelState.IsValid ? Content($"{text}: {number.ToTechnicalString()}") : BadRequest(ModelState);
}
