using Smartent.Orchard.ChartJs.Models;
using System.Collections.Generic;

namespace Smartent.Orchard.ChartJs.Samples.ViewModels.Sample;

// Here you can see the data structure passed to the view
public class BalanceViewModel
{
    public IEnumerable<string> Labels { get; set; }
    public IEnumerable<ChartJsDataSet> DataSets { get; set; }
    public object Options { get; set; }
}

// NEXT STATION: Go to Controllers/SampleController.cs.
