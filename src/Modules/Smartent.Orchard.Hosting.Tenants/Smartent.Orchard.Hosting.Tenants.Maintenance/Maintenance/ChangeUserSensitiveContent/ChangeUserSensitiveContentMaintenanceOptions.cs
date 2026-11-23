namespace Smartent.Orchard.Hosting.Tenants.Maintenance.Maintenance.ChangeUserSensitiveContent;

public class ChangeUserSensitiveContentMaintenanceOptions
{
    public bool IsEnabled { get; set; }
    public string TenantNames { get; set; }
    public string EmailExcludePattern { get; set; } = ".+@(gitee.com/smartent|example.com|test.com)$";
    public string TargetEmailDomainName { get; set; } = "test.com";
}
