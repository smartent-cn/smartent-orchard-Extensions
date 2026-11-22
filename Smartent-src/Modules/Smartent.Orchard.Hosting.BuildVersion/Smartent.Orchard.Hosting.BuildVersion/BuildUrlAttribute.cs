namespace Smartent.Orchard.Hosting.BuildVersion;

[AttributeUsage(AttributeTargets.Assembly)]
public sealed class BuildUrlAttribute : Attribute
{
    public string? Url { get; }

    public BuildUrlAttribute(string? url) => Url = url;
}
