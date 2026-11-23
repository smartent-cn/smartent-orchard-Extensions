using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Smartent.Test.UI.SqlQueryMonitoring;

public sealed class SqlQueryMonitoringContext : ISqlQueryMonitoringContext
{
    private readonly ConcurrentQueue<SqlQueryExecutionEntry> _executions = new();

    public IReadOnlyList<SqlQueryExecutionEntry> Executions => [.. _executions];

    public void RecordExecution(SqlQueryExecutionEntry entry)
    {
        if (entry == null) return;
        _executions.Enqueue(entry);
    }
}
