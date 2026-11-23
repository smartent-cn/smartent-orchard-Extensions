using Smartent.Orchard.Hosting.Tenants.Maintenance.Models;
using System.Threading.Tasks;

namespace Smartent.Orchard.Hosting.Tenants.Maintenance.Services;

/// <summary>
/// This interface is used to handle events related to staggered tenant wake-up.
/// </summary>
public interface IStaggeredTenantWakeUpEvents
{
    /// <summary>
    /// Called when the staggered tenant wake-up process is starting.
    /// </summary>
    public Task StartingAsync(StaggeredTenantWakeUpPart part) => Task.CompletedTask;

    /// <summary>
    /// Called when the staggered tenant wake-up process is finished or after paused.
    /// </summary>
    public Task FinishedAsync(StaggeredTenantWakeUpPart part) => Task.CompletedTask;

    /// <summary>
    /// Called when the staggered tenant wake-up process is paused.
    /// </summary>
    public Task PausedAsync(StaggeredTenantWakeUpPart part) => Task.CompletedTask;
}
