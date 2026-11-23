using Smartent.Orchard.ApiClient.Interfaces;
using Smartent.Orchard.ApiClient.Models;

namespace Smartent.Orchard.ApiClient.Clients;

public class ContentsApiClient : ApiClient<IOrchardCoreContentsApi>
{
    public ContentsApiClient(ApiClientSettings apiClientSettings)
        : base(apiClientSettings)
    {
    }
}
