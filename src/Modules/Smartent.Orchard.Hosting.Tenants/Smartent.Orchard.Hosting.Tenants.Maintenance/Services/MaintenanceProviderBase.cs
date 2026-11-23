using Smartent.Orchard.Hosting.Tenants.Maintenance.Extensions;
using Smartent.Orchard.Hosting.Tenants.Maintenance.Models;
using System.Threading.Tasks;

namespace Smartent.Orchard.Hosting.Tenants.Maintenance.Services;

public abstract class MaintenanceProviderBase : IMaintenanceProvider
{
    public virtual string Id => GetType().Name;
    public virtual int Order => 0;

    public virtual Task<bool> ShouldExecuteAsync(MaintenanceTaskExecutionContext context) =>
        Task.FromResult(!context.WasLatestExecutionSuccessful());

    public abstract Task ExecuteAsync(MaintenanceTaskExecutionContext context);
}
