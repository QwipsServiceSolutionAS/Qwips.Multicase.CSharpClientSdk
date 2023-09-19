using System.Runtime.Serialization;
using System;
namespace Qwips.Core.MultiCase.Models {
    public enum Taxmodelenum {
        [EnumMember(Value = "Standard")]
        Standard,
        [EnumMember(Value = "Special")]
        Special,
        [EnumMember(Value = "Export")]
        Export,
    }
}
