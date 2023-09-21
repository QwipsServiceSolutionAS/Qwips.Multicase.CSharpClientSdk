using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Outstandingvoucher : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Amount property</summary>
        public double? Amount { get; set; }
        /// <summary>The AmountInCurrency property</summary>
        public double? AmountInCurrency { get; set; }
        /// <summary>The CurrencyCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>The CustomerName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerName { get; set; }
#nullable restore
#else
        public string CustomerName { get; set; }
#endif
        /// <summary>The CustomerNumber property</summary>
        public int? CustomerNumber { get; set; }
        /// <summary>The DueDate property</summary>
        public DateTimeOffset? DueDate { get; set; }
        /// <summary>The Industry property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Industry { get; set; }
#nullable restore
#else
        public string Industry { get; set; }
#endif
        /// <summary>The InvoiceNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceNumber { get; set; }
#nullable restore
#else
        public string InvoiceNumber { get; set; }
#endif
        /// <summary>The NumberOfReminders property</summary>
        public int? NumberOfReminders { get; set; }
        /// <summary>The RemainingAmount property</summary>
        public double? RemainingAmount { get; set; }
        /// <summary>The RemainingAmountCurrency property</summary>
        public double? RemainingAmountCurrency { get; set; }
        /// <summary>The RemainingCreditDays property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemainingCreditDays { get; set; }
#nullable restore
#else
        public string RemainingCreditDays { get; set; }
#endif
        /// <summary>The ReminderDate property</summary>
        public DateTimeOffset? ReminderDate { get; set; }
        /// <summary>The SenderID property</summary>
        public int? SenderID { get; set; }
        /// <summary>The VoucherDate property</summary>
        public DateTimeOffset? VoucherDate { get; set; }
        /// <summary>The VoucherNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VoucherNumber { get; set; }
#nullable restore
#else
        public string VoucherNumber { get; set; }
#endif
        /// <summary>The VoucherText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VoucherText { get; set; }
#nullable restore
#else
        public string VoucherText { get; set; }
#endif
        /// <summary>The VoucherTypeIndicator property</summary>
        public int? VoucherTypeIndicator { get; set; }
        /// <summary>
        /// Instantiates a new outstandingvoucher and sets the default values.
        /// </summary>
        public Outstandingvoucher() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Outstandingvoucher CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Outstandingvoucher();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Amount", n => { Amount = n.GetDoubleValue(); } },
                {"AmountInCurrency", n => { AmountInCurrency = n.GetDoubleValue(); } },
                {"CurrencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"CustomerName", n => { CustomerName = n.GetStringValue(); } },
                {"CustomerNumber", n => { CustomerNumber = n.GetIntValue(); } },
                {"DueDate", n => { DueDate = n.GetDateTimeOffsetValue(); } },
                {"Industry", n => { Industry = n.GetStringValue(); } },
                {"InvoiceNumber", n => { InvoiceNumber = n.GetStringValue(); } },
                {"NumberOfReminders", n => { NumberOfReminders = n.GetIntValue(); } },
                {"RemainingAmount", n => { RemainingAmount = n.GetDoubleValue(); } },
                {"RemainingAmountCurrency", n => { RemainingAmountCurrency = n.GetDoubleValue(); } },
                {"RemainingCreditDays", n => { RemainingCreditDays = n.GetStringValue(); } },
                {"ReminderDate", n => { ReminderDate = n.GetDateTimeOffsetValue(); } },
                {"SenderID", n => { SenderID = n.GetIntValue(); } },
                {"VoucherDate", n => { VoucherDate = n.GetDateTimeOffsetValue(); } },
                {"VoucherNumber", n => { VoucherNumber = n.GetStringValue(); } },
                {"VoucherText", n => { VoucherText = n.GetStringValue(); } },
                {"VoucherTypeIndicator", n => { VoucherTypeIndicator = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("Amount", Amount);
            writer.WriteDoubleValue("AmountInCurrency", AmountInCurrency);
            writer.WriteStringValue("CurrencyCode", CurrencyCode);
            writer.WriteStringValue("CustomerName", CustomerName);
            writer.WriteIntValue("CustomerNumber", CustomerNumber);
            writer.WriteDateTimeOffsetValue("DueDate", DueDate);
            writer.WriteStringValue("Industry", Industry);
            writer.WriteStringValue("InvoiceNumber", InvoiceNumber);
            writer.WriteIntValue("NumberOfReminders", NumberOfReminders);
            writer.WriteDoubleValue("RemainingAmount", RemainingAmount);
            writer.WriteDoubleValue("RemainingAmountCurrency", RemainingAmountCurrency);
            writer.WriteStringValue("RemainingCreditDays", RemainingCreditDays);
            writer.WriteDateTimeOffsetValue("ReminderDate", ReminderDate);
            writer.WriteIntValue("SenderID", SenderID);
            writer.WriteDateTimeOffsetValue("VoucherDate", VoucherDate);
            writer.WriteStringValue("VoucherNumber", VoucherNumber);
            writer.WriteStringValue("VoucherText", VoucherText);
            writer.WriteIntValue("VoucherTypeIndicator", VoucherTypeIndicator);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
