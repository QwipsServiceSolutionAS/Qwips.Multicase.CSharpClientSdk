using System.Runtime.Serialization;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public enum Reporttypeenum {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "OrderConfirmation")]
        OrderConfirmation,
        [EnumMember(Value = "Invoice")]
        Invoice,
        [EnumMember(Value = "ReturnConfirmation")]
        ReturnConfirmation,
        [EnumMember(Value = "PickingList")]
        PickingList,
        [EnumMember(Value = "PackingList")]
        PackingList,
        [EnumMember(Value = "ControlSlip")]
        ControlSlip,
        [EnumMember(Value = "NorcargoLabel")]
        NorcargoLabel,
        [EnumMember(Value = "PurchaseOrder")]
        PurchaseOrder,
        [EnumMember(Value = "DeliveryConfirmation")]
        DeliveryConfirmation,
        [EnumMember(Value = "FreightLetter")]
        FreightLetter,
        [EnumMember(Value = "PostalEDI")]
        PostalEDI,
        [EnumMember(Value = "TollpostEDI")]
        TollpostEDI,
        [EnumMember(Value = "AddressLabel")]
        AddressLabel,
        [EnumMember(Value = "DHL_EDI")]
        DHL_EDI,
        [EnumMember(Value = "LinjegodsEDI")]
        LinjegodsEDI,
        [EnumMember(Value = "ReturnRecipient")]
        ReturnRecipient,
        [EnumMember(Value = "QuotationConfirmation")]
        QuotationConfirmation,
        [EnumMember(Value = "SwedishCompanyPackage")]
        SwedishCompanyPackage,
        [EnumMember(Value = "SwedishHomePackage")]
        SwedishHomePackage,
        [EnumMember(Value = "UPSForm")]
        UPSForm,
        [EnumMember(Value = "SwedishPostalPackage")]
        SwedishPostalPackage,
        [EnumMember(Value = "CreditNote")]
        CreditNote,
        [EnumMember(Value = "PakketransEDI")]
        PakketransEDI,
        [EnumMember(Value = "DPD_EDI")]
        DPD_EDI,
        [EnumMember(Value = "CombinedInvoice")]
        CombinedInvoice,
        [EnumMember(Value = "DeletedOrderConfirmation")]
        DeletedOrderConfirmation,
        [EnumMember(Value = "InvoiceWithGiro")]
        InvoiceWithGiro,
        [EnumMember(Value = "CreditNoteWithGiro")]
        CreditNoteWithGiro,
        [EnumMember(Value = "CombinedInvoiceWithGiro")]
        CombinedInvoiceWithGiro,
        [EnumMember(Value = "CustomsInvoice")]
        CustomsInvoice,
        [EnumMember(Value = "CustomsRate")]
        CustomsRate,
        [EnumMember(Value = "EANLabel")]
        EANLabel,
        [EnumMember(Value = "InstallmentInvoice")]
        InstallmentInvoice,
        [EnumMember(Value = "ProductLabel")]
        ProductLabel,
        [EnumMember(Value = "ShelfLabel")]
        ShelfLabel,
        [EnumMember(Value = "Letter")]
        Letter,
        [EnumMember(Value = "FreightDeliveryList")]
        FreightDeliveryList,
        [EnumMember(Value = "Freight")]
        Freight,
        [EnumMember(Value = "PerformedPriceAdjustments")]
        PerformedPriceAdjustments,
        [EnumMember(Value = "IncomingCustomerOrders")]
        IncomingCustomerOrders,
        [EnumMember(Value = "IncomingProductOrders")]
        IncomingProductOrders,
        [EnumMember(Value = "StaticDataCustomer")]
        StaticDataCustomer,
        [EnumMember(Value = "StorageCorrection")]
        StorageCorrection,
        [EnumMember(Value = "CostPriceCorrection")]
        CostPriceCorrection,
        [EnumMember(Value = "PerformedStorageCorrections")]
        PerformedStorageCorrections,
        [EnumMember(Value = "TotalStorageSupplyGroup1")]
        TotalStorageSupplyGroup1,
        [EnumMember(Value = "StorageSupply")]
        StorageSupply,
        [EnumMember(Value = "ExpirationLabel")]
        ExpirationLabel,
        [EnumMember(Value = "CollectPickingList")]
        CollectPickingList,
        [EnumMember(Value = "StorageTransfer")]
        StorageTransfer,
        [EnumMember(Value = "ReturnLabel")]
        ReturnLabel,
        [EnumMember(Value = "ValueProductReception")]
        ValueProductReception,
        [EnumMember(Value = "ValueProductReceptionDetail")]
        ValueProductReceptionDetail,
        [EnumMember(Value = "SerialNumberLabel")]
        SerialNumberLabel,
        [EnumMember(Value = "SerialNumberLabelSmall")]
        SerialNumberLabelSmall,
        [EnumMember(Value = "FastRegistrationCustomer")]
        FastRegistrationCustomer,
        [EnumMember(Value = "CreditMessage")]
        CreditMessage,
        [EnumMember(Value = "PrepaidOrder")]
        PrepaidOrder,
        [EnumMember(Value = "ShopReceipt")]
        ShopReceipt,
        [EnumMember(Value = "StoreCredit")]
        StoreCredit,
        [EnumMember(Value = "AdvancedStoreCredit")]
        AdvancedStoreCredit,
        [EnumMember(Value = "CashRegisterSettlement")]
        CashRegisterSettlement,
        [EnumMember(Value = "TerminalSettlement")]
        TerminalSettlement,
        [EnumMember(Value = "IntrastatArrival")]
        IntrastatArrival,
        [EnumMember(Value = "IntrastatExport")]
        IntrastatExport,
        [EnumMember(Value = "ArrivalControl")]
        ArrivalControl,
        [EnumMember(Value = "StorageTransactionList")]
        StorageTransactionList,
        [EnumMember(Value = "PickConfirmation")]
        PickConfirmation,
        [EnumMember(Value = "CashInvoice")]
        CashInvoice,
        [EnumMember(Value = "TotalStSupplyGr1History")]
        TotalStSupplyGr1History,
        [EnumMember(Value = "StorageSupplyHistory")]
        StorageSupplyHistory,
        [EnumMember(Value = "PriceLabel")]
        PriceLabel,
        [EnumMember(Value = "CustomInvoiceExtra")]
        CustomInvoiceExtra,
        [EnumMember(Value = "InsuranceDocument")]
        InsuranceDocument,
        [EnumMember(Value = "BarcodeTestSheet")]
        BarcodeTestSheet,
        [EnumMember(Value = "LocationCheck")]
        LocationCheck,
        [EnumMember(Value = "ChangedPriceStore")]
        ChangedPriceStore,
        [EnumMember(Value = "DeliveryList")]
        DeliveryList,
        [EnumMember(Value = "ReservationReport")]
        ReservationReport,
        [EnumMember(Value = "PurchaseLineAttachment")]
        PurchaseLineAttachment,
        [EnumMember(Value = "ExchangeReceipt")]
        ExchangeReceipt,
        [EnumMember(Value = "OfferLineAttachment")]
        OfferLineAttachment,
        [EnumMember(Value = "OrderLineAttachment")]
        OrderLineAttachment,
        [EnumMember(Value = "PakcingListNeutral")]
        PakcingListNeutral,
    }
}
