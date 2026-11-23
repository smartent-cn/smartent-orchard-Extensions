using System.Threading.Tasks;

namespace Smartent.Orchard.Extensions.Cms.Extensions.Emails.Services;

/// <summary>
/// Service for managing email templates.
/// </summary>
public interface IEmailTemplateService
{
    /// <summary>
    /// Renders an email template content identified by its ID.
    /// </summary>
    /// <param name="emailTemplateId">ID of the email template.</param>
    /// <param name="model">Optional model used as replacements in the email template.</param>
    /// <returns>Rendered email template.</returns>
    Task<string> RenderEmailTemplateAsync(string emailTemplateId, object model = null);
}
