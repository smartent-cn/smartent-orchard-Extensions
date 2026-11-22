using System.Collections.Generic;
using System.Xml.Schema;

namespace Smartent.Orchard.EInvoice.Models;

public class SchemaValidationResult
{
    public IList<string> ErrorMessages { get; } = [];
    public IList<ValidationEventArgs> ValidationEventArgs { get; } = [];
}
