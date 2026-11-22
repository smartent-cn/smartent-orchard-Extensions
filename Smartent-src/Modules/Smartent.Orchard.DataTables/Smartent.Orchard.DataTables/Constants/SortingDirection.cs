using System.Runtime.Serialization;

namespace Smartent.Orchard.DataTables.Constants;

public enum SortingDirection
{
    [EnumMember(Value = "ascending")]
    Ascending = 0,

    [EnumMember(Value = "descending")]
    Descending,
}
