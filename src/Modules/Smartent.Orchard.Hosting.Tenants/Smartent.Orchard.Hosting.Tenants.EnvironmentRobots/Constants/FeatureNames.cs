namespace Smartent.Orchard.Hosting.Tenants.EnvironmentRobots.Constants;

public static class FeatureNames
{
    public const string Module = "Smartent.Hosting";

    public const string Tenants = Module + "." + nameof(Tenants);

    public const string EnvironmentRobots = Tenants + "." + nameof(EnvironmentRobots);
}
