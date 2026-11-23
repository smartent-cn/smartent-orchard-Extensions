using Smartent.Core.Primitives.Utilities;

namespace Smartent.Orchard.JsonEditor.Settings;

public class JsonFieldSettings : ICopier<JsonFieldSettings>
{
    public string JsonEditorOptions { get; set; }

    public void CopyTo(JsonFieldSettings target) => target.JsonEditorOptions = JsonEditorOptions;
}
