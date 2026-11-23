using OrchardCore.DisplayManagement.Manifest;
using OrchardCore.ResourceManagement;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace Smartent.Orchard.Theme.Base.Core.Attributes;

/// <summary>
/// Indicates a theme derived from <c>Smartent.Orchard.Theme.Base</c>.
/// </summary>
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
[SuppressMessage("Performance", "CA1813:Avoid unsealed attributes", Justification = "Needed to support Sass and CSS base themes.")]
public class DerivedThemeAttribute : ThemeAttribute
{
    public string LinksJson { get; set; }
    public string Favicon { get; set; }

    public IEnumerable<LinkEntry> Links => LinksJson == null
        ? []
        : JsonSerializer.Deserialize<IEnumerable<LinkEntry>>(LinksJson);

    // The default value is hard coded, because we moved this attribute to the "Core" project so it can be reused by
    // Smartent.Orchard.Theme.Base.Native, but that also means the constant for "Smartent.Orchard.Theme.Base" is not available (and it
    // shouldn't be used anywhere else anyway).
    public DerivedThemeAttribute(string baseTheme = "Smartent.Orchard.Theme.Base") =>
        BaseTheme = baseTheme;
}
