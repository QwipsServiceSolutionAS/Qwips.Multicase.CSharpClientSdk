using System.Runtime.Serialization;
using System;
namespace Qwips.Core.MultiCase.Models {
    public enum Genderenum {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "Male")]
        Male,
        [EnumMember(Value = "Female")]
        Female,
    }
}
