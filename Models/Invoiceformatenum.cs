using System.Runtime.Serialization;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public enum Invoiceformatenum {
        [EnumMember(Value = "Paper")]
        Paper,
        [EnumMember(Value = "EDI_MC")]
        EDI_MC,
        [EnumMember(Value = "EHF")]
        EHF,
        [EnumMember(Value = "EmailPDF")]
        EmailPDF,
        [EnumMember(Value = "EDI_BWISE")]
        EDI_BWISE,
    }
}
