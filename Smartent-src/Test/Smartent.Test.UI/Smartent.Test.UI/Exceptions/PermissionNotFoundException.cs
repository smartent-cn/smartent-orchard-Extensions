using System;

namespace Smartent.Test.UI.Exceptions;

public class PermissionNotFoundException : Exception
{
    public PermissionNotFoundException(string message)
        : base(message)
    {
    }

    public PermissionNotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public PermissionNotFoundException()
    {
    }
}
