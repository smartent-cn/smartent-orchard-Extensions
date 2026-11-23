using Smartent.Orchard.DataTables.Samples.Controllers;
using Smartent.Orchard.DataTables.Services;
using Smartent.Orchard.Platform.Mvc;
using Smartent.Test.UI.Extensions;
using Smartent.Test.UI.Services;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Smartent.Orchard.DataTables.Tests.UI.Extensions;

public static class UITestContextExtensions
{
    public static Task ExecuteDataTablesSampleRecipeDirectlyAsync(this UITestContext context) =>
        context.ExecuteRecipeDirectlyAsync("Smartent.Orchard.DataTables.Samples.Content");

    public static Task GoToDataTableTagHelperAsync(this UITestContext context) =>
        context.GoToAsync<SampleController>(controller => controller.DataTableTagHelper());

    public static Task GoToDataTableProviderWithShapeAsync(this UITestContext context) =>
        context.GoToAsync<SampleController>(controller => controller.ProviderWithShape());

    public static Task GoToAdminDataTableAsync<T>(this UITestContext context)
        where T : IDataTableDataProvider =>
        context.GoToAdminDataTableAsync(typeof(T).Name);

    public static Task GoToAdminDataTableAsync(this UITestContext context, string providerName) =>
        context.GoToAdminRelativeUrlAsync("/DataTable/" + providerName);

    public static void VerifyDataTablePager(this UITestContext context, int pageCount, int currentPage = 1)
    {
        const string pagerItemXPath = "//li[contains(@class, 'page-item') and ./button[@data-dt-idx = number(@data-dt-idx)]]";

        context.Exists(By.XPath(string.Create(
            CultureInfo.InvariantCulture,
            $"({pagerItemXPath})[last()]/button[normalize-space(.) = '{pageCount}']")));

        static void VerifyNavigation(UITestContext context, string className, bool exists)
        {
            var existsSelector = exists ? ":not(.disabled)" : ".disabled";
            context.Exists(By.CssSelector($".page-item{existsSelector} .{className}"));
        }

        VerifyNavigation(context, "previous", currentPage > 1);
        VerifyNavigation(context, "next", currentPage < pageCount);
    }

    public static async Task ClickAndWaitForTableChangeAsync(this UITestContext context, By selector)
    {
        var state = GetTableState(context);
        await context.ClickReliablyOnAsync(selector);
        context.DoWithRetriesOrFail(() => GetTableState(context) != state);
    }

    private static string GetTableState(UITestContext context) =>
        context
            .GetAll(By.CssSelector(".dataTableWrapper td"))
            .Select(element => element.Text.Trim())
            .Join();
}
