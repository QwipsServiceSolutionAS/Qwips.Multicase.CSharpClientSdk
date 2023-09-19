using System.Runtime.Serialization;
using System;
namespace Qwips.Core.MultiCase.Models {
    public enum Documenttypeenum1 {
        [EnumMember(Value = "PDF")]
        PDF,
        [EnumMember(Value = "XML")]
        XML,
        [EnumMember(Value = "EXCEL")]
        EXCEL,
    }
}
