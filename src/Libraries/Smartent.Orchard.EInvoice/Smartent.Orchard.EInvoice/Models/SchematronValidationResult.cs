using System.Collections.Generic;

namespace Smartent.Orchard.EInvoice.Models;

public class SchematronValidationResult
{
    public IList<FailedAssert> WarningFailedAsserts { get; } = [];
    public IList<FailedAssert> ErrorFailedAsserts { get; } = [];
    public int InnerValidationDurationMs { get; set; }
}
