using System.Text.Json.Serialization;

namespace Smartent.Test.UI.Models;

public class DockerConfiguration
{
    public string ContainerName { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string ContainerSnapshotPath { get; set; } = "/data/Snapshots";
}
