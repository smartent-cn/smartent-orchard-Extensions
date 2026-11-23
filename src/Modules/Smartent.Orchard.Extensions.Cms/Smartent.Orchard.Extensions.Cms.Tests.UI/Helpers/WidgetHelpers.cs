using Atata;
using Smartent.Test.UI.Extensions;
using Smartent.Test.UI.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using static Smartent.Orchard.Extensions.Cms.Tests.UI.Constants.XPathSelectors;

namespace Smartent.Orchard.Extensions.Cms.Tests.UI.Helpers;

internal static class WidgetHelpers
{
    public static void AddWidgetToPageFlow(UITestContext context, string widget) =>
        new Actions(context.Driver)
            .Click(context.Get(By.XPath(AddWidgetButton)))
            .Click(context.Get(By.XPath($"{WidgetList}/a[text()='{widget} Widget']").OfAnyVisibility()))
            .Build()
            .Perform();
}
