using Smartent.Test.UI.Extensions;
using Smartent.Test.UI.Services;
using System.Threading.Tasks;

namespace Smartent.Orchard.Extensions.Cms.Tests.UI.Extensions;

public static class UITestContextExtensions
{
    public static Task GoToCreatePageAsync(this UITestContext context) =>
        context.CreateNewContentItemAsync("Page", onlyIfNotAlreadyThere: false);
}
