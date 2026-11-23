using OrchardCore.ContentLocalization.Models;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Builders;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using OrchardCore.Markdown.Models;
using System.Threading.Tasks;
using static Smartent.Orchard.Extensions.Cms.Extensions.SiteTexts.Constants.ContentTypes;
using static Smartent.Orchard.Platform.Contents.ContentFieldEditorEnums;

namespace Smartent.Orchard.Extensions.Cms.Extensions.SiteTexts;

public sealed class SiteTextMigrations : DataMigration
{
    private readonly IContentDefinitionManager _contentDefinitionManager;

    public SiteTextMigrations(IContentDefinitionManager contentDefinitionManager) =>
        _contentDefinitionManager = contentDefinitionManager;

    public async Task<int> CreateAsync()
    {
        await _contentDefinitionManager.AlterTypeDefinitionAsync(SiteText, builder => builder
            .SetAbilities(
                creatable: true,
                securable: true,
                draftable: false,
                listable: true,
                versionable: false)
            .WithPart(nameof(MarkdownBodyPart), part => part.WithEditor(MarkdownFieldEditors.Wysiwyg))
            .WithPart(nameof(LocalizationPart)));

        return 1;
    }
}
