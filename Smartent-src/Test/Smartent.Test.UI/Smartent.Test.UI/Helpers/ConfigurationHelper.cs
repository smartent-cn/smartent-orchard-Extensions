using Smartent.Test.UI.Services;
using System;
using System.Threading.Tasks;

namespace Smartent.Test.UI.Helpers;

public static class ConfigurationHelper
{
    public static Func<OrchardCoreUITestExecutorConfiguration, Task> DisableHtmlValidation =>
        configuration =>
        {
            configuration.HtmlValidationConfiguration.RunHtmlValidationAssertionOnAllPageChanges = false;
            return Task.CompletedTask;
        };
}
