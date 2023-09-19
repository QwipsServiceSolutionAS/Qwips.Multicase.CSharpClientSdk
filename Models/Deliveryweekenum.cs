using System.Runtime.Serialization;
using System;
namespace Qwips.Core.MultiCase.Models {
    public enum Deliveryweekenum {
        [EnumMember(Value = "AllWeeks")]
        AllWeeks,
        [EnumMember(Value = "EvenNumberedWeeks")]
        EvenNumberedWeeks,
        [EnumMember(Value = "OddNumberedWeeks")]
        OddNumberedWeeks,
    }
}
