using Smartent.Test.UI.Extensions;
using Smartent.Test.UI.Services;
using System;

namespace Smartent.Test.UI.Exceptions;

public class PageChangeAssertionException : Exception, IAssertionException
{
    public Uri Address { get; }
    public string Title { get; }

    public PageChangeAssertionException(
        UITestContext context,
        Exception innerException)
        : base(
            $"An assertion during the page change event has failed on page {context.GetPageTitleAndAddress()}.",
            innerException)
    {
        Address = new Uri(context.Driver.Url);
        Title = context.Driver.Title;
    }

    public PageChangeAssertionException()
    {
    }

    public PageChangeAssertionException(string message)
        : base(message)
    {
    }

    public PageChangeAssertionException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
