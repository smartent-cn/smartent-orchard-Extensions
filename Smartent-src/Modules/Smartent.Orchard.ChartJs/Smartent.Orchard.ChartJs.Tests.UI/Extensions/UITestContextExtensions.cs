using Smartent.Orchard.ChartJs.Samples.Controllers;
using Smartent.Orchard.Platform.Mvc;
using Smartent.Test.UI.Extensions;
using Smartent.Test.UI.Services;
using System.Threading.Tasks;

namespace Smartent.Orchard.ChartJs.Tests.UI.Extensions;

public static class UITestContextExtensions
{
    public static Task ExecuteChartJsSampleRecipeDirectlyAsync(this UITestContext context) =>
        context.ExecuteRecipeDirectlyAsync("Smartent.Orchard.ChartJs.Samples.Content");

    public static Task GoToBalanceAsync(this UITestContext context) =>
        context.GoToAsync<SampleController>(controller => controller.Balance());

    public static Task GoToHistoryAsync(this UITestContext context) =>
        context.GoToAsync<SampleController>(controller => controller.History(incomeTag: null, expenseTag: null));
}
