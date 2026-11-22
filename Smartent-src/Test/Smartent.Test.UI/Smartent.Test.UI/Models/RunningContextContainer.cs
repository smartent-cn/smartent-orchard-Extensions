using Smartent.Test.UI.Services;

namespace Smartent.Test.UI.Models;

public record RunningContextContainer(
    SqlServerRunningContext SqlServerRunningContext,
    SmtpServiceRunningContext SmtpServiceRunningContext,
    AzureBlobStorageRunningContext AzureBlobStorageRunningContext,
    ElasticsearchRunningContext ElasticsearchRunningContext);
