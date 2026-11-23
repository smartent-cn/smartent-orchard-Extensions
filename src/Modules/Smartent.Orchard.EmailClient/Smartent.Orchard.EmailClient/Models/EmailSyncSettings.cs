using Smartent.Core.Primitives.Utilities;

namespace Smartent.Orchard.EmailClient.Models;

public class EmailSyncSettings : ICopier<EmailSyncSettings>
{
    public string SubjectFilter { get; set; }

    public void CopyTo(EmailSyncSettings target) =>
        target.SubjectFilter = SubjectFilter;
}
