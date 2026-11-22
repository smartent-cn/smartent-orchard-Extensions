using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Smartent.Orchard.Platform.Validation;

/// <summary>
/// A service for returning validation errors for email of password.
/// </summary>
public interface IEmailAndPasswordValidator
{
    /// <summary>
    /// Validates the provided <paramref name="email"/> and returns any validation errors as a localized string.
    /// </summary>
    Task<IEnumerable<LocalizedString>> ValidateEmailAsync(string email);

    /// <summary>
    /// Validates the provided <paramref name="password"/> and returns any validation errors as a localized string.
    /// </summary>
    Task<IEnumerable<LocalizedString>> ValidatePasswordAsync(string? password);
}
