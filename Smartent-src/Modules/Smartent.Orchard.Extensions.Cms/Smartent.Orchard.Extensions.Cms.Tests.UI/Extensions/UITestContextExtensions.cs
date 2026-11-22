using Lombiq.Tests.UI.Extensions;
using Lombiq.Tests.UI.Services;
using System.Threading.Tasks;

namespace Smartent.Orchard.Extensions.Cms.Tests.UI.Extensions;

public static class UITestContextExtensions
{
    public static Task GoToCreatePageAsync(this UITestContext context) =>
        context.CreateNewContentItemAsync("Page", onlyIfNotAlreadyThere: false);
}
