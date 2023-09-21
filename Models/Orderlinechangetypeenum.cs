using System.Runtime.Serialization;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public enum Orderlinechangetypeenum {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Add")]
        Add,
        [EnumMember(Value = "Update")]
        Update,
        [EnumMember(Value = "Delete")]
        Delete,
    }
}
