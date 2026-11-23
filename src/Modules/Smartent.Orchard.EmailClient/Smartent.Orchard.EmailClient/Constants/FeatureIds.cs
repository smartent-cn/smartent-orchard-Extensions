namespace Smartent.Orchard.EmailClient.Constants;

public static class FeatureIds
{
    public const string Area = "Smartent.Orchard.EmailClient";

    public const string Default = Area;
    public const string Imap = Area + "." + nameof(Imap);
    public const string EmailSync = Area + "." + nameof(EmailSync);
}
