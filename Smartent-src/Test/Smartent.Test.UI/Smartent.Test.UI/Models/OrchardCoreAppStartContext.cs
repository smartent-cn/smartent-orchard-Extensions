using Smartent.Test.UI.Services;
using System;

namespace Smartent.Test.UI.Models;

public record OrchardCoreAppStartContext(string ContentRootPath, Uri Url, PortLeaseManager PortLeaseManager);
