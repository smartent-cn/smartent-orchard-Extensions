using Smartent.Orchard.Extensions.Cms.Extensions.ContentSets.Models;
using Smartent.Orchard.Extensions.Cms.Extensions.ContentSets.ViewModels;
using Smartent.Orchard.Extensions.Cms.Extensions.ContentSets.Workflows.Activities;
using Smartent.Orchard.Extensions.Cms.Extensions.ContentSets.Workflows.Models;
using Smartent.Orchard.Platform.Workflow;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata.Models;
using OrchardCore.DisplayManagement.Notify;
using System.Collections.Generic;

namespace Smartent.Orchard.Extensions.Cms.Extensions.ContentSets.Workflows.Drivers;

public sealed class ContentSetGetSupportedOptionsEventDisplayDriver :
    DocumentedEventActivityDisplayDriverBase<ContentSetGetSupportedOptionsEvent>
{
    private readonly IHtmlLocalizer<ContentSetGetSupportedOptionsEventDisplayDriver> H;

    public override string IconClass => "fa-circle-half-stroke";

    public override LocalizedHtmlString Description =>
        H["Tries to get a list of links representing the supported options for this content set."];

    public override IDictionary<string, string> AvailableInputs { get; } = new Dictionary<string, string>
    {
        [nameof(GetSupportedOptionsContext.Definition)] = nameof(ContentTypePartDefinition),
        [nameof(GetSupportedOptionsContext.ContentSetPart)] = nameof(ContentSetPart),
        [nameof(GetSupportedOptionsContext.ContentItem)] = nameof(ContentItem),
    };

    public override IDictionary<string, string> ExpectedOutputs { get; } = new Dictionary<string, string>
    {
        [ContentSetGetSupportedOptionsEvent.OutputName] =
            $"{{ \"{nameof(ContentSetLinkViewModel.Key)}\": string, \"{nameof(ContentSetLinkViewModel.DisplayText)}\": string }}[]",
    };

    public ContentSetGetSupportedOptionsEventDisplayDriver(
        INotifier notifier,
        IStringLocalizer<DocumentedEventActivityDisplayDriver> baseLocalizer,
        IHtmlLocalizer<ContentSetGetSupportedOptionsEventDisplayDriver> htmlLocalizer)
        : base(notifier, baseLocalizer) =>
        H = htmlLocalizer;
}
