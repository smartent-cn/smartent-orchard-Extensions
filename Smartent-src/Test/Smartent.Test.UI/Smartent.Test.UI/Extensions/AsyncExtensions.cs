using System;
using System.Threading.Tasks;

namespace Smartent.Test.UI.Extensions;

public static class AsyncExtensions
{
    public static Func<T, Task> AsCompletedTask<T>(this Action<T> action) =>
        target =>
        {
            action?.Invoke(target);
            return Task.CompletedTask;
        };
}
