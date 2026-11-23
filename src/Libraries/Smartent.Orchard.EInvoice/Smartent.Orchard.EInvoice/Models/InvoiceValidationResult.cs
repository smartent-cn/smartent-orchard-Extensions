using Smartent.Orchard.EInvoice.Constants;

namespace Smartent.Orchard.EInvoice.Models;

public record InvoiceValidationResult(
    SchemaValidationResult? SchemaValidationResult,
    SchematronValidationResult? SchematronValidationResult,
    InvoiceFormat Format,
    string Standard = Standards.EN16931,
    bool Successful = false,
    bool HasWarnings = false);
