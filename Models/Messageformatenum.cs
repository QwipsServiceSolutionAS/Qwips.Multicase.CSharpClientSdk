using System.Runtime.Serialization;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public enum Messageformatenum {
        [EnumMember(Value = "Text")]
        Text,
        [EnumMember(Value = "HTML")]
        HTML,
        [EnumMember(Value = "XML")]
        XML,
        [EnumMember(Value = "Fax")]
        Fax,
    }
}
