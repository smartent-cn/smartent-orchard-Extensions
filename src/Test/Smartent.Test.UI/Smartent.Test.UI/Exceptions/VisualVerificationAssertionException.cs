using System;

namespace Smartent.Test.UI.Exceptions;

public class VisualVerificationAssertionException : Exception, IAssertionException
{
    public VisualVerificationAssertionException(string message)
        : base(message)
    {
    }

    public VisualVerificationAssertionException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public VisualVerificationAssertionException()
    {
    }
}
