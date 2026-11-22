using Smartent.Orchard.EmailClient.Models;
using System.Threading.Tasks;

namespace Smartent.Orchard.EmailClient.Services;

/// <summary>
/// Event handler for email sync events.
/// </summary>
public interface IEmailSyncEventHandler
{
    /// <summary>
    /// Called when an email is synced.
    /// </summary>
    Task EmailSyncedAsync(EmailMessage emailMessage);
}
