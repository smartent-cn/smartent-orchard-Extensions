using Lombiq.Tests.UI.Models;

namespace Smartent.Orchard.ApiClient.Models;

public static class TenantSetupApiModelExtensions
{
    public static UserLoginParameters ToLoginParameters(
        this TenantSetupApiModel model,
        string loginButtonText = UserLoginParameters.DefaultLoginButtonText) =>
        new(model.UserName, model.Password, loginButtonText);
}
