using Atata;

namespace Smartent.Test.UI.Components;

[ControlDefinition("div[contains(@class, 'validation-summary-errors')]")]
public class ValidationSummary<TOwner> : Text<TOwner>
    where TOwner : PageObject<TOwner>
{
}
