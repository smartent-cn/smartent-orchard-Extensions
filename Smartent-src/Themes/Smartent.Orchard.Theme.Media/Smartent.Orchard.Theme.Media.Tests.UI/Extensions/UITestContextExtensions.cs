using Smartent.Test.UI.Extensions;
using Smartent.Test.UI.Services;
using System.Threading.Tasks;

namespace Smartent.Orchard.Theme.Media.Tests.UI.Extensions;

public static class UITestContextExtensions
{
    public static Task ExecuteMediaThemeSampleRecipeDirectlyAsync(this UITestContext context) =>
        context.ExecuteRecipeDirectlyAsync("Smartent.Orchard.Theme.Media.Samples");

    public static Task GoToMediaThemeTestContentPageAsync(this UITestContext context) =>
        context.GoToRelativeUrlAsync("/Contents/ContentItems/mediathemetest000000000000");
}
