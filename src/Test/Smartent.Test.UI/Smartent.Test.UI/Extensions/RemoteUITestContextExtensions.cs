using Smartent.Test.UI.Services;
using System;

namespace Smartent.Test.UI.Extensions;

public static class RemoteUITestContextExtensions
{
    public static bool IsLocalUITest(this UITestContext context) => context.TestStartUri.Host.ContainsOrdinalIgnoreCase("localhost");
}
