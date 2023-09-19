using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Creditnote : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Amount property</summary>
        public double? Amount { get; set; }
        /// <summary>The ClientNumber property</summary>
        public double? ClientNumber { get; set; }
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
        public Qwips.Core.MultiCase.Models.Customer? Customer { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Customer Customer { get; set; }
#endif
        /// <summary>The DateCreated property</summary>
        public DateTimeOffset? DateCreated { get; set; }
        /// <summary>The DateInvoiced property</summary>
        public DateTimeOffset? DateInvoiced { get; set; }
        /// <summary>The Department property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Department? Department { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Department Department { get; set; }
#endif
        /// <summary>The InvoiceDate property</summary>
        public DateTimeOffset? InvoiceDate { get; set; }
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
        /// <summary>The VatAmount property</summary>
        public double? VatAmount { get; set; }
        /// <summary>The VatApplicableAmount property</summary>
        public double? VatApplicableAmount { get; set; }
        /// <summary>
        /// Instantiates a new creditnote and sets the default values.
        /// </summary>
        public Creditnote() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Creditnote CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Creditnote();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Amount", n => { Amount = n.GetDoubleValue(); } },
                {"ClientNumber", n => { ClientNumber = n.GetDoubleValue(); } },
                {"Closed", n => { Closed = n.GetBoolValue(); } },
                {"CreditorId", n => { CreditorId = n.GetIntValue(); } },
                {"CreditorName", n => { CreditorName = n.GetStringValue(); } },
                {"Customer", n => { Customer = n.GetObjectValue<Qwips.Core.MultiCase.Models.Customer>(Qwips.Core.MultiCase.Models.Customer.CreateFromDiscriminatorValue); } },
                {"DateCreated", n => { DateCreated = n.GetDateTimeOffsetValue(); } },
                {"DateInvoiced", n => { DateInvoiced = n.GetDateTimeOffsetValue(); } },
                {"Department", n => { Department = n.GetObjectValue<Qwips.Core.MultiCase.Models.Department>(Qwips.Core.MultiCase.Models.Department.CreateFromDiscriminatorValue); } },
                {"InvoiceDate", n => { InvoiceDate = n.GetDateTimeOffsetValue(); } },
                {"InvoiceNumber", n => { InvoiceNumber = n.GetIntValue(); } },
                {"KID", n => { KID = n.GetStringValue(); } },
                {"Reference", n => { Reference = n.GetStringValue(); } },
                {"Rounding", n => { Rounding = n.GetDoubleValue(); } },
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
            writer.WriteDoubleValue("ClientNumber", ClientNumber);
            writer.WriteBoolValue("Closed", Closed);
            writer.WriteIntValue("CreditorId", CreditorId);
            writer.WriteStringValue("CreditorName", CreditorName);
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Customer>("Customer", Customer);
            writer.WriteDateTimeOffsetValue("DateCreated", DateCreated);
            writer.WriteDateTimeOffsetValue("DateInvoiced", DateInvoiced);
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Department>("Department", Department);
            writer.WriteDateTimeOffsetValue("InvoiceDate", InvoiceDate);
            writer.WriteIntValue("InvoiceNumber", InvoiceNumber);
            writer.WriteStringValue("KID", KID);
            writer.WriteStringValue("Reference", Reference);
            writer.WriteDoubleValue("Rounding", Rounding);
            writer.WriteDoubleValue("VatAmount", VatAmount);
            writer.WriteDoubleValue("VatApplicableAmount", VatApplicableAmount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
