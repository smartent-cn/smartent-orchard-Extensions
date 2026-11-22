using Smartent.Orchard.EInvoice.Models;
using System.Xml.Schema;

namespace Smartent.Orchard.EInvoice.Services;

/// <summary>
/// Provides the XML schema set for validating eInvoices against the specified invoice format.
/// </summary>
public interface IEInvoiceXmlSchemaSet
{
    /// <summary>
    /// Gets the XML schema set for the specified invoice format.
    /// </summary>
    XmlSchemaSet GetSchemaSet(InvoiceFormat format);
}
