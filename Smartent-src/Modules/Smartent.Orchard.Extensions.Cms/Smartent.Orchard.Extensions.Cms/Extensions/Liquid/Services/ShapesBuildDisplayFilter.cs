using OrchardCore.Contents.Liquid;

namespace Smartent.Orchard.Extensions.Cms.Extensions.Liquid.Services;

public class ShapesBuildDisplayFilter : ArrayFilterBase
{
    public ShapesBuildDisplayFilter(BuildDisplayFilter buildDisplayFilter)
        : base(buildDisplayFilter)
    {
    }
}
