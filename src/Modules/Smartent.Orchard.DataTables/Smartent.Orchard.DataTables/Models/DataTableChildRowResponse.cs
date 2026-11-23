using System.Text.Json.Serialization;

namespace Smartent.Orchard.DataTables.Models;

public class DataTableChildRowResponse
{
    [JsonPropertyName("error")]
    public string Error { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; }

    public static DataTableChildRowResponse ErrorResult(string errorText) => new() { Error = errorText };
}
