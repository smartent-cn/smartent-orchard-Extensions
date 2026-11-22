using Atata;
using Atata.Bootstrap;

namespace Smartent.Test.UI.Components;

public sealed class ConfirmationModal<TNavigateTo> : BSModal<ConfirmationModal<TNavigateTo>>
    where TNavigateTo : PageObject<TNavigateTo>
{
    [FindById("modalOkButton")]
    public Button<TNavigateTo, ConfirmationModal<TNavigateTo>> Yes { get; private set; }

    [FindById("modalCancelButton")]
    public Button<TNavigateTo, ConfirmationModal<TNavigateTo>> No { get; private set; }
}
