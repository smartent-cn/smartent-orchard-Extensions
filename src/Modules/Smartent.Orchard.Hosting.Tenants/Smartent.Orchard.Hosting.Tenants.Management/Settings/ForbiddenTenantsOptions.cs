using System.Collections.Generic;

namespace Smartent.Orchard.Hosting.Tenants.Management.Settings;

public class ForbiddenTenantsOptions
{
    public IEnumerable<string> RequestUrlHosts { get; set; }
}
