using Smartent.Test.UI.Extensions;
using Smartent.Test.UI.Services;
using OpenQA.Selenium;
using Shouldly;
using System.Threading.Tasks;

namespace Smartent.Orchard.Extensions.Cms.Tests.UI.Extensions;

public static class TrumbowygBlogPostsTestCaseUITestContextExtensions
{
    /// <summary>
    /// Tests the Lombiq Helpful Extensions - Trumbowyg code snippet - Blog Posts feature, and thus also the Lombiq Helpful
    /// Extensions - Trumbowyg code snippet one.
    /// </summary>
    public static async Task TestTrumbowygBlogPostsFeatureAsync(this UITestContext context)
    {
        void AssertCodeSnippetIsHighlighted() =>
            context.Get(By.CssSelector("code.language-clike")).Text.ShouldStartWith("Console");

        await context.EnableFeatureDirectlyAsync(FeatureIds.TrumbowygBlogPosts);
        await context.ExecuteRecipeDirectlyAsync("Smartent.Orchard.Extensions.Cms.Tests.UI.TrumbowygBlogPosts.Tests");

        await context.SignInDirectlyAndGoToDashboardAsync();

        await context.ClickReliablyOnByLinkTextAsync("Blog");
        await context.ClickReliablyOnByLinkTextAsync("Man must explore, and this is exploration at its greatest");

        await context.ClickReliablyOnAsync(By.ClassName("trumbowyg-highlight-button"));
        await context.FillInWithRetriesAsync(By.CssSelector("textarea.trumbowyg-highlight-form-control"), "Console.WriteLine(\"Hello, world!\");");
        await context.ClickReliablyOnAsync(By.ClassName("trumbowyg-modal-submit"));
        AssertCodeSnippetIsHighlighted();

        await context.ClickPublishAsync();

        await context.GoToRelativeUrlAsync("/blog/post-1");
        AssertCodeSnippetIsHighlighted();
    }
}
