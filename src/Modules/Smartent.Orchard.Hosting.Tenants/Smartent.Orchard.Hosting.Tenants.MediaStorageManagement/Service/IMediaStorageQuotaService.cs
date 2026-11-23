using System.Threading.Tasks;

namespace Smartent.Orchard.Hosting.Tenants.MediaStorageManagement.Service;

/// <summary>
/// Storage quota related calculations.
/// </summary>
public interface IMediaStorageQuotaService
{
    /// <summary>
    /// Returns the remaining storage space left from the quota in bytes. It is always a non-negative number, meaning
    /// the minimum value is 0.
    /// </summary>
    Task<long> GetRemainingMediaStorageQuotaBytesAsync();

    /// <summary>
    /// Returns the maximum storage space form the quota in bytes.
    /// </summary>
    long GetMaxStorageQuotaBytes();
}
