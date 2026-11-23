using System;

namespace Smartent.Test.UI.Exceptions;

public class WorkflowTypeNotFoundException : Exception
{
    public WorkflowTypeNotFoundException(string message)
        : base(message)
    {
    }

    public WorkflowTypeNotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public WorkflowTypeNotFoundException()
    {
    }
}
