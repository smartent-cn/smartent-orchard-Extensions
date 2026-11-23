using Smartent.Orchard.DataTables.Constants;
using System.Collections.Generic;

namespace Smartent.Orchard.DataTables.Models;

public class DataTableColumnsDefinition
{
    public IEnumerable<DataTableColumnDefinition> Columns { get; set; } = [];
    public string DefaultSortingColumnName { get; set; } = string.Empty;
    public SortingDirection DefaultSortingDirection { get; set; } = SortingDirection.Ascending;
}
