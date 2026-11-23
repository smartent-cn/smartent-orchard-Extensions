namespace Smartent.Orchard.Hosting.Tenants.FeaturesGuard.Constants;

public static class FeatureNames
{
    public const string Module = "Smartent.Hosting";

    public const string Tenants = Module + "." + nameof(Tenants);

    public const string FeaturesGuard = Tenants + "." + nameof(FeaturesGuard);
}
