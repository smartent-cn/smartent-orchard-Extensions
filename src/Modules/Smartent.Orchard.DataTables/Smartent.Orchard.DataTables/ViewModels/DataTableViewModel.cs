using Smartent.Orchard.DataTables.Services;
using OrchardCore.DisplayManagement;
using System.Collections.Generic;

namespace Smartent.Orchard.DataTables.ViewModels;

public class DataTableViewModel
{
    public DataTableDefinitionViewModel Definition { get; set; }
    public IDataTableDataProvider Provider { get; set; }

    public IEnumerable<IShape> BeforeTable { get; set; }
    public IEnumerable<IShape> AfterTable { get; set; }
}
