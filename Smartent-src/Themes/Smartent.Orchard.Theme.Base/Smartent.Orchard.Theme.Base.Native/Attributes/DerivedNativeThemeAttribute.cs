using Smartent.Orchard.Theme.Base.Core.Attributes;
using Smartent.Orchard.Theme.Base.Native.Constants;
using System;

namespace Smartent.Orchard.Theme.Base.Native.Attributes;

/// <summary>
/// Indicates a theme derived from the <see cref="FeatureIds.Native"/> theme.
/// </summary>
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
public sealed class DerivedNativeThemeAttribute : DerivedThemeAttribute
{
    public DerivedNativeThemeAttribute()
        : base(FeatureIds.Native)
    { }
}
