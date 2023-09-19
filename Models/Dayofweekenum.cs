using System.Runtime.Serialization;
using System;
namespace Qwips.Core.MultiCase.Models {
    public enum Dayofweekenum {
        [EnumMember(Value = "Sunday")]
        Sunday,
        [EnumMember(Value = "Monday")]
        Monday,
        [EnumMember(Value = "Tuesday")]
        Tuesday,
        [EnumMember(Value = "Wednesday")]
        Wednesday,
        [EnumMember(Value = "Thursday")]
        Thursday,
        [EnumMember(Value = "Friday")]
        Friday,
        [EnumMember(Value = "Saturday")]
        Saturday,
    }
}
