using Smartent.Orchard.Platform.ResourceManagement;
using static Smartent.Orchard.Extensions.Cms.Extensions.Trumbowyg.Constants.PrismLanguageNames;
using static Smartent.Orchard.Extensions.Cms.Extensions.Trumbowyg.Constants.TrumbowygResourceNames;

namespace Smartent.Orchard.Extensions.Cms.Extensions.TrumbowygBlogPosts;

public class ResourceFilters : IResourceFilterProvider
{
    public void AddResourceFilter(ResourceFilterBuilder builder)
    {
        const string BlogPost = "BlogPost";

        var resourceFilters = new[]
            {
                builder.WhenContentType(BlogPost),
                builder.WhenContentTypeEditor(BlogPost),
                builder.WhenContentTypeCreate(BlogPost),
                builder.WhenContentTypePreview(BlogPost),
            };

        foreach (var resourceFilter in resourceFilters)
        {
            resourceFilter.RegisterStylesheet(Prism, PrismCoyTheme, PrismLineHighlight, TrumbowygHighlight);
            resourceFilter.RegisterFootScript(Prism, PrismLineHighlight, TrumbowygHighlight, TrumbowygHighlightExtension);
            foreach (var language in AllLanguage)
            {
                resourceFilter.RegisterFootScript(language);
            }
        }
    }
}
