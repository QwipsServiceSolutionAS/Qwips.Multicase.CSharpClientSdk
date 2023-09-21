using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Invoice : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Amount property</summary>
        public double? Amount { get; set; }
        /// <summary>The ClientNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientNumber { get; set; }
#nullable restore
#else
        public string ClientNumber { get; set; }
#endif
        /// <summary>The Closed property</summary>
        public bool? Closed { get; set; }
        /// <summary>The CreditorId property</summary>
        public int? CreditorId { get; set; }
        /// <summary>The CreditorName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreditorName { get; set; }
#nullable restore
#else
        public string CreditorName { get; set; }
#endif
        /// <summary>The Customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Customer? Customer { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Customer Customer { get; set; }
#endif
        /// <summary>The DateCreated property</summary>
        public DateTimeOffset? DateCreated { get; set; }
        /// <summary>The DateInvoiced property</summary>
        public DateTimeOffset? DateInvoiced { get; set; }
        /// <summary>The DeliveryMethod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveryMethod { get; set; }
#nullable restore
#else
        public string DeliveryMethod { get; set; }
#endif
        /// <summary>The Department property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Department? Department { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Department Department { get; set; }
#endif
        /// <summary>The DepartmentId property</summary>
        public int? DepartmentId { get; set; }
        /// <summary>The DueDate property</summary>
        public DateTimeOffset? DueDate { get; set; }
        /// <summary>The FreightCost property</summary>
        public double? FreightCost { get; set; }
        /// <summary>The FreightCostVat property</summary>
        public double? FreightCostVat { get; set; }
        /// <summary>The InvoiceDate property</summary>
        public DateTimeOffset? InvoiceDate { get; set; }
        /// <summary>The InvoiceFee property</summary>
        public double? InvoiceFee { get; set; }
        /// <summary>The InvoiceFeeVat property</summary>
        public double? InvoiceFeeVat { get; set; }
        /// <summary>The InvoiceNumber property</summary>
        public int? InvoiceNumber { get; set; }
        /// <summary>The KID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KID { get; set; }
#nullable restore
#else
        public string KID { get; set; }
#endif
        /// <summary>The OrderNumber property</summary>
        public int? OrderNumber { get; set; }
        /// <summary>The PaymentMethod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentMethod { get; set; }
#nullable restore
#else
        public string PaymentMethod { get; set; }
#endif
        /// <summary>The PaymentMethodText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentMethodText { get; set; }
#nullable restore
#else
        public string PaymentMethodText { get; set; }
#endif
        /// <summary>The Reference property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reference { get; set; }
#nullable restore
#else
        public string Reference { get; set; }
#endif
        /// <summary>The Rounding property</summary>
        public double? Rounding { get; set; }
        /// <summary>The Text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>The VatAmount property</summary>
        public double? VatAmount { get; set; }
        /// <summary>The VatApplicableAmount property</summary>
        public double? VatApplicableAmount { get; set; }
        /// <summary>
        /// Instantiates a new invoice and sets the default values.
        /// </summary>
        public Invoice() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Invoice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Invoice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Amount", n => { Amount = n.GetDoubleValue(); } },
                {"ClientNumber", n => { ClientNumber = n.GetStringValue(); } },
                {"Closed", n => { Closed = n.GetBoolValue(); } },
                {"CreditorId", n => { CreditorId = n.GetIntValue(); } },
                {"CreditorName", n => { CreditorName = n.GetStringValue(); } },
                {"Customer", n => { Customer = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Customer>(Qwips.Core.ClientSdk.Multicase.Models.Customer.CreateFromDiscriminatorValue); } },
                {"DateCreated", n => { DateCreated = n.GetDateTimeOffsetValue(); } },
                {"DateInvoiced", n => { DateInvoiced = n.GetDateTimeOffsetValue(); } },
                {"DeliveryMethod", n => { DeliveryMethod = n.GetStringValue(); } },
                {"Department", n => { Department = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Department>(Qwips.Core.ClientSdk.Multicase.Models.Department.CreateFromDiscriminatorValue); } },
                {"DepartmentId", n => { DepartmentId = n.GetIntValue(); } },
                {"DueDate", n => { DueDate = n.GetDateTimeOffsetValue(); } },
                {"FreightCost", n => { FreightCost = n.GetDoubleValue(); } },
                {"FreightCostVat", n => { FreightCostVat = n.GetDoubleValue(); } },
                {"InvoiceDate", n => { InvoiceDate = n.GetDateTimeOffsetValue(); } },
                {"InvoiceFee", n => { InvoiceFee = n.GetDoubleValue(); } },
                {"InvoiceFeeVat", n => { InvoiceFeeVat = n.GetDoubleValue(); } },
                {"InvoiceNumber", n => { InvoiceNumber = n.GetIntValue(); } },
                {"KID", n => { KID = n.GetStringValue(); } },
                {"OrderNumber", n => { OrderNumber = n.GetIntValue(); } },
                {"PaymentMethod", n => { PaymentMethod = n.GetStringValue(); } },
                {"PaymentMethodText", n => { PaymentMethodText = n.GetStringValue(); } },
                {"Reference", n => { Reference = n.GetStringValue(); } },
                {"Rounding", n => { Rounding = n.GetDoubleValue(); } },
                {"Text", n => { Text = n.GetStringValue(); } },
                {"VatAmount", n => { VatAmount = n.GetDoubleValue(); } },
                {"VatApplicableAmount", n => { VatApplicableAmount = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("Amount", Amount);
            writer.WriteStringValue("ClientNumber", ClientNumber);
            writer.WriteBoolValue("Closed", Closed);
            writer.WriteIntValue("CreditorId", CreditorId);
            writer.WriteStringValue("CreditorName", CreditorName);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Customer>("Customer", Customer);
            writer.WriteDateTimeOffsetValue("DateCreated", DateCreated);
            writer.WriteDateTimeOffsetValue("DateInvoiced", DateInvoiced);
            writer.WriteStringValue("DeliveryMethod", DeliveryMethod);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Department>("Department", Department);
            writer.WriteIntValue("DepartmentId", DepartmentId);
            writer.WriteDateTimeOffsetValue("DueDate", DueDate);
            writer.WriteDoubleValue("FreightCost", FreightCost);
            writer.WriteDoubleValue("FreightCostVat", FreightCostVat);
            writer.WriteDateTimeOffsetValue("InvoiceDate", InvoiceDate);
            writer.WriteDoubleValue("InvoiceFee", InvoiceFee);
            writer.WriteDoubleValue("InvoiceFeeVat", InvoiceFeeVat);
            writer.WriteIntValue("InvoiceNumber", InvoiceNumber);
            writer.WriteStringValue("KID", KID);
            writer.WriteIntValue("OrderNumber", OrderNumber);
            writer.WriteStringValue("PaymentMethod", PaymentMethod);
            writer.WriteStringValue("PaymentMethodText", PaymentMethodText);
            writer.WriteStringValue("Reference", Reference);
            writer.WriteDoubleValue("Rounding", Rounding);
            writer.WriteStringValue("Text", Text);
            writer.WriteDoubleValue("VatAmount", VatAmount);
            writer.WriteDoubleValue("VatApplicableAmount", VatApplicableAmount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
