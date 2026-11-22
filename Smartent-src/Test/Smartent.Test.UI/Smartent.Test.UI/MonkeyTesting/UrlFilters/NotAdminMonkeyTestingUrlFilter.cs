using Smartent.Test.UI.Services;
using System;

namespace Smartent.Test.UI.MonkeyTesting.UrlFilters;

/// <summary>
/// URL filter that matches the URL to see if it's NOT an admin page (i.e. an URL NOT under /admin).
/// </summary>
public class NotAdminMonkeyTestingUrlFilter : IMonkeyTestingUrlFilter
{
    private readonly AdminMonkeyTestingUrlFilter _adminMonkeyTestingUrlFilter;

    public NotAdminMonkeyTestingUrlFilter(UITestContext context) => _adminMonkeyTestingUrlFilter = new(context);

    public bool AllowUrl(UITestContext context, Uri url) => !_adminMonkeyTestingUrlFilter.AllowUrl(context, url);
}
