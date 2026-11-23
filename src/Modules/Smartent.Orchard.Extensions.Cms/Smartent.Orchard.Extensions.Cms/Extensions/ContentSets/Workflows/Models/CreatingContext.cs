using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata.Models;

namespace Smartent.Orchard.Extensions.Cms.Extensions.ContentSets.Workflows.Models;

public record CreatingContext(
    ContentItem ContentItem,
    ContentTypePartDefinition Definition,
    string ContentSet,
    string NewKey);
