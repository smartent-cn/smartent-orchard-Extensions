using Microsoft.AspNetCore.Html;
using OrchardCore.ContentManagement;
using OrchardCore.Markdown.Services;
using System.Threading.Tasks;

namespace Smartent.Orchard.Extensions.Cms.Extensions.SiteTexts.Services;

public class SiteTextService : SiteTextServiceBase
{
    public SiteTextService(IContentManager contentManager, IMarkdownService markdownService)
        : base(contentManager, markdownService)
    {
    }

    public override async Task<HtmlString> RenderHtmlByIdAsync(string contentItemId)
    {
        var part = await GetSiteTextMarkdownBodyPartByIdAsync(contentItemId);
        return await RenderMarkdownAsync(part.Markdown);
    }
}
