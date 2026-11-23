using Atata;

namespace Smartent.Test.UI.Components;

public sealed class ValidationSummaryErrorList<TOwner> : ControlList<ValidationSummaryError<TOwner>, TOwner>
    where TOwner : PageObject<TOwner>
{
}
