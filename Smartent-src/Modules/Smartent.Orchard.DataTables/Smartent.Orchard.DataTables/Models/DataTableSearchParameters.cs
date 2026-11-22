using System.Text.Json.Serialization;

namespace Smartent.Orchard.DataTables.Models;

public class DataTableSearchParameters
{
    [JsonPropertyName("value")]
    public string Value { get; set; }

    [JsonPropertyName("regex")]
    public bool? IsRegex { get; set; }
}
