using OrchardCore.Data.Documents;
using System;

namespace Smartent.Orchard.EmailClient.Models;

public class EmailSyncStateDocument : Document
{
    public uint LastSyncedImapUniqueId { get; set; }
    public DateTime? LastSyncedDateUtc { get; set; }
}
