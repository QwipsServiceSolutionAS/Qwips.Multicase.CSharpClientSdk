using System.Runtime.Serialization;
using System;
namespace Qwips.Core.MultiCase.Models {
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
