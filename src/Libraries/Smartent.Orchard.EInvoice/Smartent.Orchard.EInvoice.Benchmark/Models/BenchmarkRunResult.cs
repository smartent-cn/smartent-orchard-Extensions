using Smartent.Orchard.EInvoice.Models;

namespace Smartent.Orchard.EInvoice.Benchmark.Models;

public class BenchmarkRunResult
{
    public InvoiceValidationResult Result { get; set; }
    public long ElapsedMilliseconds { get; set; }
}
