using System.Runtime.Serialization;
using System;
namespace Qwips.Core.MultiCase.Models {
    public enum Invoicescheduletypeenum {
        [EnumMember(Value = "Continuous")]
        Continuous,
        [EnumMember(Value = "DailyCombined")]
        DailyCombined,
        [EnumMember(Value = "WeeklyCombined")]
        WeeklyCombined,
        [EnumMember(Value = "MonthlyCombined")]
        MonthlyCombined,
    }
}
