using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata.Models;

namespace Smartent.Orchard.JsonEditor.ViewModels;

public record EditContentItemViewModel(
    ContentItem ContentItem,
    ContentTypeDefinition ContentTypeDefinition,
    string Json);
