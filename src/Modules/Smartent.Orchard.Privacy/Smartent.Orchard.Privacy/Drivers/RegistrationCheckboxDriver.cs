using Smartent.Orchard.Platform.Contents;
using Smartent.Orchard.Privacy.ViewModels;
using OrchardCore.DisplayManagement.Handlers;
using OrchardCore.DisplayManagement.Views;
using OrchardCore.Users.Models;

namespace Smartent.Orchard.Privacy.Drivers;

public sealed class RegistrationCheckboxDriver : DisplayDriver<RegisterUserForm>
{
    public override IDisplayResult Edit(RegisterUserForm model, BuildEditorContext context) =>
        Initialize<PrivacyRegistrationConsentCheckboxViewModel>("Smartent_Orchard_Privacy_RegistrationCheckbox", _ => { })
            .Location(CommonLocationNames.Content + ":after");
}
