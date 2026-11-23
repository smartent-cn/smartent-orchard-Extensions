using Smartent.Test.UI.SecurityScanning;
using Smartent.Test.UI.Services;
using System;
using Xunit;

namespace Smartent.Test.UI.Models;

public record UITestContextData(
    string Id,
    UITestManifest TestManifest,
    OrchardCoreUITestExecutorConfiguration Configuration,
    IWebApplicationInstance Application,
    ITestOutputHelper TestOutputHelper,
    Uri AppBaseUri,
    Uri TestStartUri,
    RunningContextContainer RunningContextContainer,
    ZapManager ZapManager);
