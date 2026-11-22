using Smartent.Test.UI.Services;
using System;

namespace Smartent.Test.UI.Helpers;

public static class RemoteTestHelper
{
    public static bool RunIsForProduction =>
        Environment.GetEnvironmentVariable("GITHUB_REPOSITORY")?.ContainsOrdinalIgnoreCase("swap") == true ||
        Environment.GetEnvironmentVariable("GITHUB_EVENT_NAME")?.ContainsOrdinalIgnoreCase("schedule") == true ||
        TestConfigurationManager.GetConfiguration("Environment", "staging").EndsWithOrdinalIgnoreCase("production");
}
