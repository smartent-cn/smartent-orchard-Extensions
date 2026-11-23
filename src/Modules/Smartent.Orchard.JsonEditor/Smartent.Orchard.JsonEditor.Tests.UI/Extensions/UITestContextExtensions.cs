using Smartent.Test.UI.Extensions;
using Smartent.Test.UI.Services;
using System.Threading.Tasks;

namespace Smartent.Orchard.JsonEditor.Tests.UI.Extensions;

public static class UITestContextExtensions
{
    public static Task ExecuteJsonEditorSampleRecipeDirectlyAsync(this UITestContext context) =>
        context.ExecuteRecipeDirectlyAsync("Smartent.Orchard.JsonEditor.Sample");

    public static Task EnableJsonEditorFeatureAsync(this UITestContext context) =>
        context.EnableFeatureDirectlyAsync("Smartent.Orchard.JsonEditor");

    public static Task EnableJsonContentEditorFeatureAsync(this UITestContext context) =>
        context.EnableFeatureDirectlyAsync("Smartent.Orchard.JsonEditor.ContentEditor");
}
