using System.Runtime.Serialization;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public enum Customerpayoutenum {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Empty")]
        Empty,
        [EnumMember(Value = "Monthly")]
        Monthly,
        [EnumMember(Value = "Quarterly")]
        Quarterly,
        [EnumMember(Value = "EveryFourthMonth")]
        EveryFourthMonth,
        [EnumMember(Value = "EverySixMonth")]
        EverySixMonth,
        [EnumMember(Value = "Yearly")]
        Yearly,
    }
}
