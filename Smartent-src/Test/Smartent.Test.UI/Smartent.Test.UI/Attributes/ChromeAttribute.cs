using Smartent.Test.UI.Services;
using System;

namespace Smartent.Test.UI.Attributes;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public sealed class ChromeAttribute : BrowserAttributeBase
{
    protected override Browser Browser => Browser.Chrome;
}
