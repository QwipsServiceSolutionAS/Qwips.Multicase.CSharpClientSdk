using System.Runtime.Serialization;
using System;
namespace Qwips.Core.MultiCase.Models {
    public enum Customerstatusenum {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "A")]
        A,
        [EnumMember(Value = "B")]
        B,
        [EnumMember(Value = "C")]
        C,
        [EnumMember(Value = "D")]
        D,
        [EnumMember(Value = "E")]
        E,
        [EnumMember(Value = "F")]
        F,
    }
}
