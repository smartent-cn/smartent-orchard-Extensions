using System.Text.Json.Serialization;

namespace Smartent.Orchard.ApiClient.Models;

public class Token
{
    [JsonPropertyName("token_type")]
    public string TokenType { get; set; }

    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }

    [JsonPropertyName("error")]
    public string Error { get; set; }

    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }
}
