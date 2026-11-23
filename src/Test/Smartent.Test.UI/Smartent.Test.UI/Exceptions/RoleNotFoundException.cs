using System;

namespace Smartent.Test.UI.Exceptions;

public class RoleNotFoundException : Exception
{
    public RoleNotFoundException(string message)
        : base(message)
    {
    }

    public RoleNotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public RoleNotFoundException()
    {
    }
}
