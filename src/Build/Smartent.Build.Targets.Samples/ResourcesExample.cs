using Smartent.Core.CodeGen.Attributes;

namespace Smartent.Build.Targets.Samples;

[LibManVersions]
public static partial class ResourcesExample
{
    public static bool IsVersionCorrectlyGenerated() =>
        LibManVersions.Async == "3.2.6";
}