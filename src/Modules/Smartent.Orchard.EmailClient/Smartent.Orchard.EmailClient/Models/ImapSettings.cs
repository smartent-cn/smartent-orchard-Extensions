using Smartent.Core.Primitives.Utilities;

namespace Smartent.Orchard.EmailClient.Models;

public class ImapSettings : ICopier<ImapSettings>
{
    public string Host { get; set; }
    public int Port { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool UseSsl { get; set; }
    public bool RequireAuthentication { get; set; }

    public void CopyTo(ImapSettings target)
    {
        target.Host = Host;
        target.Port = Port;
        target.Username = Username;
        target.Password = Password;
        target.UseSsl = UseSsl;
        target.RequireAuthentication = RequireAuthentication;
    }
}
