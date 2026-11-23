using Microsoft.AspNetCore.Mvc.ModelBinding;
using OrchardCore.DisplayManagement;

namespace Smartent.Orchard.Theme.Base.Core.ViewModels;

public class BaseThemeSettingsViewModel
{
    public string Icon { get; set; }

    public required bool HideMenu { get; set; }

    [BindNever]
    public IShape Editor { get; set; }
}
