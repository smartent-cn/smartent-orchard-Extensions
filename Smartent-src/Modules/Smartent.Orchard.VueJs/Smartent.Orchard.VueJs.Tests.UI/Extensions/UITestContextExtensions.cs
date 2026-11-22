using Smartent.Orchard.Platform.Mvc;
using Lombiq.Tests.UI.Extensions;
using Lombiq.Tests.UI.Services;
using Smartent.Orchard.VueJs.Samples.Controllers;
using System.Threading.Tasks;

namespace Smartent.Orchard.VueJs.Tests.UI.Extensions;

public static class UITestContextExtensions
{
    public static Task GoToVueSfcAsync(this UITestContext context) =>
        context.GoToAsync<VueSfcController>(controller => controller.Index());

    public static Task GoToVueSfcAppTagHelperAsync(this UITestContext context) =>
        context.GoToAsync<VueSfcController>(controller => controller.AppTagHelper());

    public static Task GoToVueSfcEnhancedListAsync(this UITestContext context, int page = 1) =>
        context.GoToAsync<VueSfcController>(controller => controller.EnhancedList(page));

    public static Task ExecuteQrCardSampleRecipeDirectlyAsync(this UITestContext context) =>
        context.ExecuteRecipeDirectlyAsync("Smartent.Orchard.VueJs.Samples.Content");

    public static Task GoToQrCardAppAsync(this UITestContext context) =>
        context.GoToAsync<QrCardController>(controller => controller.Index());
}
