using System.Runtime.Serialization;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public enum Communicationtypeenum {
        [EnumMember(Value = "Fax")]
        Fax,
        [EnumMember(Value = "Postal")]
        Postal,
        [EnumMember(Value = "EMail")]
        EMail,
        [EnumMember(Value = "EDI")]
        EDI,
        [EnumMember(Value = "SMS")]
        SMS,
        [EnumMember(Value = "EDIBWISE")]
        EDIBWISE,
    }
}
