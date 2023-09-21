using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Bundleline : IAdditionalDataHolder, IParsable {
        /// <summary>The AccountNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountNumber { get; set; }
#nullable restore
#else
        public string AccountNumber { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The BundleLineId property</summary>
        public int? BundleLineId { get; set; }
        /// <summary>The CurrencyCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>The Customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Customer? Customer { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Customer Customer { get; set; }
#endif
        /// <summary>The Date property</summary>
        public DateTimeOffset? Date { get; set; }
        /// <summary>The DebitAmount property</summary>
        public double? DebitAmount { get; set; }
        /// <summary>The DepartmentCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DepartmentCode { get; set; }
#nullable restore
#else
        public string DepartmentCode { get; set; }
#endif
        /// <summary>The DueDate property</summary>
        public DateTimeOffset? DueDate { get; set; }
        /// <summary>The InvoiceNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceNumber { get; set; }
#nullable restore
#else
        public string InvoiceNumber { get; set; }
#endif
        /// <summary>The IsDebtorRecord property</summary>
        public bool? IsDebtorRecord { get; set; }
        /// <summary>The IsSalesRecord property</summary>
        public bool? IsSalesRecord { get; set; }
        /// <summary>The IsSupplierRecord property</summary>
        public bool? IsSupplierRecord { get; set; }
        /// <summary>The KID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KID { get; set; }
#nullable restore
#else
        public string KID { get; set; }
#endif
        /// <summary>The LineNumber property</summary>
        public int? LineNumber { get; set; }
        /// <summary>The Processed property</summary>
        public bool? Processed { get; set; }
        /// <summary>The SupplierNumber property</summary>
        public int? SupplierNumber { get; set; }
        /// <summary>The TaxCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxCode { get; set; }
#nullable restore
#else
        public string TaxCode { get; set; }
#endif
        /// <summary>The Text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>The VoucherNumber property</summary>
        public int? VoucherNumber { get; set; }
        /// <summary>The VoucherTypeCode property</summary>
        public int? VoucherTypeCode { get; set; }
        /// <summary>
        /// Instantiates a new bundleline and sets the default values.
        /// </summary>
        public Bundleline() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Bundleline CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Bundleline();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AccountNumber", n => { AccountNumber = n.GetStringValue(); } },
                {"BundleLineId", n => { BundleLineId = n.GetIntValue(); } },
                {"CurrencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"Customer", n => { Customer = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Customer>(Qwips.Core.ClientSdk.Multicase.Models.Customer.CreateFromDiscriminatorValue); } },
                {"Date", n => { Date = n.GetDateTimeOffsetValue(); } },
                {"DebitAmount", n => { DebitAmount = n.GetDoubleValue(); } },
                {"DepartmentCode", n => { DepartmentCode = n.GetStringValue(); } },
                {"DueDate", n => { DueDate = n.GetDateTimeOffsetValue(); } },
                {"InvoiceNumber", n => { InvoiceNumber = n.GetStringValue(); } },
                {"IsDebtorRecord", n => { IsDebtorRecord = n.GetBoolValue(); } },
                {"IsSalesRecord", n => { IsSalesRecord = n.GetBoolValue(); } },
                {"IsSupplierRecord", n => { IsSupplierRecord = n.GetBoolValue(); } },
                {"KID", n => { KID = n.GetStringValue(); } },
                {"LineNumber", n => { LineNumber = n.GetIntValue(); } },
                {"Processed", n => { Processed = n.GetBoolValue(); } },
                {"SupplierNumber", n => { SupplierNumber = n.GetIntValue(); } },
                {"TaxCode", n => { TaxCode = n.GetStringValue(); } },
                {"Text", n => { Text = n.GetStringValue(); } },
                {"VoucherNumber", n => { VoucherNumber = n.GetIntValue(); } },
                {"VoucherTypeCode", n => { VoucherTypeCode = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("AccountNumber", AccountNumber);
            writer.WriteIntValue("BundleLineId", BundleLineId);
            writer.WriteStringValue("CurrencyCode", CurrencyCode);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Customer>("Customer", Customer);
            writer.WriteDateTimeOffsetValue("Date", Date);
            writer.WriteDoubleValue("DebitAmount", DebitAmount);
            writer.WriteStringValue("DepartmentCode", DepartmentCode);
            writer.WriteDateTimeOffsetValue("DueDate", DueDate);
            writer.WriteStringValue("InvoiceNumber", InvoiceNumber);
            writer.WriteBoolValue("IsDebtorRecord", IsDebtorRecord);
            writer.WriteBoolValue("IsSalesRecord", IsSalesRecord);
            writer.WriteBoolValue("IsSupplierRecord", IsSupplierRecord);
            writer.WriteStringValue("KID", KID);
            writer.WriteIntValue("LineNumber", LineNumber);
            writer.WriteBoolValue("Processed", Processed);
            writer.WriteIntValue("SupplierNumber", SupplierNumber);
            writer.WriteStringValue("TaxCode", TaxCode);
            writer.WriteStringValue("Text", Text);
            writer.WriteIntValue("VoucherNumber", VoucherNumber);
            writer.WriteIntValue("VoucherTypeCode", VoucherTypeCode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
