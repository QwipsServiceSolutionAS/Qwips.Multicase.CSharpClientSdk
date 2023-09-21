using System.Runtime.Serialization;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public enum Stockcheckmodeenum {
        [EnumMember(Value = "PlaceOrderAsIs")]
        PlaceOrderAsIs,
        [EnumMember(Value = "AdjustToMaximumAmountAvailable")]
        AdjustToMaximumAmountAvailable,
        [EnumMember(Value = "ExcludeOrderLinesThatCannotBeFullyDelivered")]
        ExcludeOrderLinesThatCannotBeFullyDelivered,
        [EnumMember(Value = "RejectOrderIfNotAvailable")]
        RejectOrderIfNotAvailable,
    }
}
