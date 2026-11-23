namespace Smartent.Orchard.Hosting.Tenants.Maintenance.Models;

public class StaggeredTenantWakeUpOptions
{
    public int? BatchIntervalSeconds { get; set; }
    public int? BatchSize { get; set; }
    public bool? RunParallel { get; set; }
    public bool? RunOnStartup { get; set; }
}
