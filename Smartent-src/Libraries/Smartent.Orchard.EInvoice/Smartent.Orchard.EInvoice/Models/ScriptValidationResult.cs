namespace Smartent.Orchard.EInvoice.Models;

public record ScriptValidationResult(string OutputXml, int DurationMs, string? Error = null);
