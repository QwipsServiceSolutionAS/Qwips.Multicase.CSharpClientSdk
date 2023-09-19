using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Paymentterm : IAdditionalDataHolder, IParsable {
        /// <summary>The AccountingCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountingCode { get; set; }
#nullable restore
#else
        public string AccountingCode { get; set; }
#endif
        /// <summary>The Active property</summary>
        public bool? Active { get; set; }
        /// <summary>The ActiveOrders property</summary>
        public bool? ActiveOrders { get; set; }
        /// <summary>The ActiveQuotations property</summary>
        public bool? ActiveQuotations { get; set; }
        /// <summary>The ActiveSupplier property</summary>
        public bool? ActiveSupplier { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AdvancePay property</summary>
        public bool? AdvancePay { get; set; }
        /// <summary>The AgreedDueDate property</summary>
        public bool? AgreedDueDate { get; set; }
        /// <summary>The AnnualInterest property</summary>
        public int? AnnualInterest { get; set; }
        /// <summary>The AutoHold property</summary>
        public bool? AutoHold { get; set; }
        /// <summary>The CanCopyOrders property</summary>
        public bool? CanCopyOrders { get; set; }
        /// <summary>The CardPayment property</summary>
        public bool? CardPayment { get; set; }
        /// <summary>The CreditDays property</summary>
        public int? CreditDays { get; set; }
        /// <summary>The CreditNoteMonthsBeforeExpiry property</summary>
        public int? CreditNoteMonthsBeforeExpiry { get; set; }
        /// <summary>The DnBCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DnBCode { get; set; }
#nullable restore
#else
        public string DnBCode { get; set; }
#endif
        /// <summary>The FreeDeliveryMonth property</summary>
        public bool? FreeDeliveryMonth { get; set; }
        /// <summary>The FromAmount property</summary>
        public double? FromAmount { get; set; }
        /// <summary>The InstallmentCharge property</summary>
        public double? InstallmentCharge { get; set; }
        /// <summary>The Installments property</summary>
        public bool? Installments { get; set; }
        /// <summary>The InvoicePrintoutInCheckout property</summary>
        public bool? InvoicePrintoutInCheckout { get; set; }
        /// <summary>The LockOrder property</summary>
        public bool? LockOrder { get; set; }
        /// <summary>The MamutCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MamutCode { get; set; }
#nullable restore
#else
        public string MamutCode { get; set; }
#endif
        /// <summary>The MarkInvoiceAsPrinted property</summary>
        public bool? MarkInvoiceAsPrinted { get; set; }
        /// <summary>The MarkInvoiceAsPrintedOnAllSenders property</summary>
        public bool? MarkInvoiceAsPrintedOnAllSenders { get; set; }
        /// <summary>The MayHaveInvoiceFee property</summary>
        public bool? MayHaveInvoiceFee { get; set; }
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The NetsGiftCard property</summary>
        public bool? NetsGiftCard { get; set; }
        /// <summary>The NotCombinedInvoice property</summary>
        public bool? NotCombinedInvoice { get; set; }
        /// <summary>The NumberOfDownpayments property</summary>
        public int? NumberOfDownpayments { get; set; }
        /// <summary>The OnlyCreditNoteWithFactoring property</summary>
        public bool? OnlyCreditNoteWithFactoring { get; set; }
        /// <summary>The OrderHoldStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Ordreholdstatus? OrderHoldStatus { get; set; }
#nullable restore
#else
        public Ordreholdstatus OrderHoldStatus { get; set; }
#endif
        /// <summary>The PaymentIDVismaBusiness property</summary>
        public int? PaymentIDVismaBusiness { get; set; }
        /// <summary>The PaymentIDVismaGlobal property</summary>
        public int? PaymentIDVismaGlobal { get; set; }
        /// <summary>The PaymentTermID property</summary>
        public int? PaymentTermID { get; set; }
        /// <summary>The PermissionForDirectDelivery property</summary>
        public bool? PermissionForDirectDelivery { get; set; }
        /// <summary>The Prepaid property</summary>
        public bool? Prepaid { get; set; }
        /// <summary>The RunCreditCheck property</summary>
        public bool? RunCreditCheck { get; set; }
        /// <summary>The ShowOnWeb property</summary>
        public bool? ShowOnWeb { get; set; }
        /// <summary>The StartupCharge property</summary>
        public double? StartupCharge { get; set; }
        /// <summary>The ToAmount property</summary>
        public double? ToAmount { get; set; }
        /// <summary>The UseExternalInvoiceNumber property</summary>
        public bool? UseExternalInvoiceNumber { get; set; }
        /// <summary>
        /// Instantiates a new paymentterm and sets the default values.
        /// </summary>
        public Paymentterm() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Paymentterm CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Paymentterm();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AccountingCode", n => { AccountingCode = n.GetStringValue(); } },
                {"Active", n => { Active = n.GetBoolValue(); } },
                {"ActiveOrders", n => { ActiveOrders = n.GetBoolValue(); } },
                {"ActiveQuotations", n => { ActiveQuotations = n.GetBoolValue(); } },
                {"ActiveSupplier", n => { ActiveSupplier = n.GetBoolValue(); } },
                {"AdvancePay", n => { AdvancePay = n.GetBoolValue(); } },
                {"AgreedDueDate", n => { AgreedDueDate = n.GetBoolValue(); } },
                {"AnnualInterest", n => { AnnualInterest = n.GetIntValue(); } },
                {"AutoHold", n => { AutoHold = n.GetBoolValue(); } },
                {"CanCopyOrders", n => { CanCopyOrders = n.GetBoolValue(); } },
                {"CardPayment", n => { CardPayment = n.GetBoolValue(); } },
                {"CreditDays", n => { CreditDays = n.GetIntValue(); } },
                {"CreditNoteMonthsBeforeExpiry", n => { CreditNoteMonthsBeforeExpiry = n.GetIntValue(); } },
                {"DnBCode", n => { DnBCode = n.GetStringValue(); } },
                {"FreeDeliveryMonth", n => { FreeDeliveryMonth = n.GetBoolValue(); } },
                {"FromAmount", n => { FromAmount = n.GetDoubleValue(); } },
                {"InstallmentCharge", n => { InstallmentCharge = n.GetDoubleValue(); } },
                {"Installments", n => { Installments = n.GetBoolValue(); } },
                {"InvoicePrintoutInCheckout", n => { InvoicePrintoutInCheckout = n.GetBoolValue(); } },
                {"LockOrder", n => { LockOrder = n.GetBoolValue(); } },
                {"MamutCode", n => { MamutCode = n.GetStringValue(); } },
                {"MarkInvoiceAsPrinted", n => { MarkInvoiceAsPrinted = n.GetBoolValue(); } },
                {"MarkInvoiceAsPrintedOnAllSenders", n => { MarkInvoiceAsPrintedOnAllSenders = n.GetBoolValue(); } },
                {"MayHaveInvoiceFee", n => { MayHaveInvoiceFee = n.GetBoolValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"NetsGiftCard", n => { NetsGiftCard = n.GetBoolValue(); } },
                {"NotCombinedInvoice", n => { NotCombinedInvoice = n.GetBoolValue(); } },
                {"NumberOfDownpayments", n => { NumberOfDownpayments = n.GetIntValue(); } },
                {"OnlyCreditNoteWithFactoring", n => { OnlyCreditNoteWithFactoring = n.GetBoolValue(); } },
                {"OrderHoldStatus", n => { OrderHoldStatus = n.GetObjectValue<Ordreholdstatus>(Ordreholdstatus.CreateFromDiscriminatorValue); } },
                {"PaymentIDVismaBusiness", n => { PaymentIDVismaBusiness = n.GetIntValue(); } },
                {"PaymentIDVismaGlobal", n => { PaymentIDVismaGlobal = n.GetIntValue(); } },
                {"PaymentTermID", n => { PaymentTermID = n.GetIntValue(); } },
                {"PermissionForDirectDelivery", n => { PermissionForDirectDelivery = n.GetBoolValue(); } },
                {"Prepaid", n => { Prepaid = n.GetBoolValue(); } },
                {"RunCreditCheck", n => { RunCreditCheck = n.GetBoolValue(); } },
                {"ShowOnWeb", n => { ShowOnWeb = n.GetBoolValue(); } },
                {"StartupCharge", n => { StartupCharge = n.GetDoubleValue(); } },
                {"ToAmount", n => { ToAmount = n.GetDoubleValue(); } },
                {"UseExternalInvoiceNumber", n => { UseExternalInvoiceNumber = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("AccountingCode", AccountingCode);
            writer.WriteBoolValue("Active", Active);
            writer.WriteBoolValue("ActiveOrders", ActiveOrders);
            writer.WriteBoolValue("ActiveQuotations", ActiveQuotations);
            writer.WriteBoolValue("ActiveSupplier", ActiveSupplier);
            writer.WriteBoolValue("AdvancePay", AdvancePay);
            writer.WriteBoolValue("AgreedDueDate", AgreedDueDate);
            writer.WriteIntValue("AnnualInterest", AnnualInterest);
            writer.WriteBoolValue("AutoHold", AutoHold);
            writer.WriteBoolValue("CanCopyOrders", CanCopyOrders);
            writer.WriteBoolValue("CardPayment", CardPayment);
            writer.WriteIntValue("CreditDays", CreditDays);
            writer.WriteIntValue("CreditNoteMonthsBeforeExpiry", CreditNoteMonthsBeforeExpiry);
            writer.WriteStringValue("DnBCode", DnBCode);
            writer.WriteBoolValue("FreeDeliveryMonth", FreeDeliveryMonth);
            writer.WriteDoubleValue("FromAmount", FromAmount);
            writer.WriteDoubleValue("InstallmentCharge", InstallmentCharge);
            writer.WriteBoolValue("Installments", Installments);
            writer.WriteBoolValue("InvoicePrintoutInCheckout", InvoicePrintoutInCheckout);
            writer.WriteBoolValue("LockOrder", LockOrder);
            writer.WriteStringValue("MamutCode", MamutCode);
            writer.WriteBoolValue("MarkInvoiceAsPrinted", MarkInvoiceAsPrinted);
            writer.WriteBoolValue("MarkInvoiceAsPrintedOnAllSenders", MarkInvoiceAsPrintedOnAllSenders);
            writer.WriteBoolValue("MayHaveInvoiceFee", MayHaveInvoiceFee);
            writer.WriteStringValue("Name", Name);
            writer.WriteBoolValue("NetsGiftCard", NetsGiftCard);
            writer.WriteBoolValue("NotCombinedInvoice", NotCombinedInvoice);
            writer.WriteIntValue("NumberOfDownpayments", NumberOfDownpayments);
            writer.WriteBoolValue("OnlyCreditNoteWithFactoring", OnlyCreditNoteWithFactoring);
            writer.WriteObjectValue<Ordreholdstatus>("OrderHoldStatus", OrderHoldStatus);
            writer.WriteIntValue("PaymentIDVismaBusiness", PaymentIDVismaBusiness);
            writer.WriteIntValue("PaymentIDVismaGlobal", PaymentIDVismaGlobal);
            writer.WriteIntValue("PaymentTermID", PaymentTermID);
            writer.WriteBoolValue("PermissionForDirectDelivery", PermissionForDirectDelivery);
            writer.WriteBoolValue("Prepaid", Prepaid);
            writer.WriteBoolValue("RunCreditCheck", RunCreditCheck);
            writer.WriteBoolValue("ShowOnWeb", ShowOnWeb);
            writer.WriteDoubleValue("StartupCharge", StartupCharge);
            writer.WriteDoubleValue("ToAmount", ToAmount);
            writer.WriteBoolValue("UseExternalInvoiceNumber", UseExternalInvoiceNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
