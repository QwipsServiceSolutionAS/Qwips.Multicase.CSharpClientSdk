using System.Runtime.Serialization;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public enum Priceonpackinglistenum {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "ShowOtherPriceGroupExclTax")]
        ShowOtherPriceGroupExclTax,
        [EnumMember(Value = "ShowCustomerPriceExclTax")]
        ShowCustomerPriceExclTax,
        [EnumMember(Value = "ShowOtherPriceInclTax")]
        ShowOtherPriceInclTax,
        [EnumMember(Value = "ShowCustomerPriceTax")]
        ShowCustomerPriceTax,
    }
}
