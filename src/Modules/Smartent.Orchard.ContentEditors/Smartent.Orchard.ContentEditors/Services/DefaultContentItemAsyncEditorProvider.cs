using Smartent.Orchard.ContentEditors.Models;
using OrchardCore.ContentManagement;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartent.Orchard.ContentEditors.Services;

public class DefaultContentItemAsyncEditorProvider : ContentItemAsyncEditorProviderBase<DefaultContentItemAsyncEditorProvider>
{
    public override string Name => "Default";

    public DefaultContentItemAsyncEditorProvider(
        IContentItemAsyncEditorProviderServices<DefaultContentItemAsyncEditorProvider> providerServices)
        : base(providerServices)
    {
    }

    public override Task<IEnumerable<AsyncEditorGroupDescriptor<ContentItem>>> DescribeEditorGroupsAsync() =>
        Task.FromResult(new[]
        {
            DescribeEditorGroup(name: null, T["Content"], isPublishGroup: true),
        }.AsEnumerable());
}
