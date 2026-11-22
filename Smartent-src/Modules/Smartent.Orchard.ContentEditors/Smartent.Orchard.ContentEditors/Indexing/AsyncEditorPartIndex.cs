using YesSql.Indexes;

namespace Smartent.Orchard.ContentEditors.Indexing;

public class AsyncEditorPartIndex : MapIndex
{
    public int DocumentId { get; set; }
    public string ContentItemId { get; set; }
    public string AsyncEditorId { get; set; }
    public string FilledEditorGroup { get; set; }
}
