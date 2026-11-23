using System.Threading.Tasks;

namespace Smartent.Orchard.Hosting.Tenants.IdleTenantManagement.Services;

/// <summary>
/// Service to shut down idle tenants.
/// </summary>
internal interface IIdleShutdownService
{
    /// <summary>
    /// Shuts down idle tenants if they are idle for more than the configured time.
    /// </summary>
    Task ShutDownTenantIfIdleAsync();
}
