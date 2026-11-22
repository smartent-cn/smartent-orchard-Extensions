using System.Collections.Generic;

namespace Smartent.Orchard.Hosting.Tenants.Maintenance.Maintenance.UpdateSiteUrl;

public class UpdateSiteUrlMaintenanceOptions
{
    public bool IsEnabled { get; set; }
    public string DefaultTenantSiteUrl { get; set; }
    public string SiteUrl { get; set; }
    public IDictionary<string, string> SiteUrlFromTenantName { get; init; }
}
