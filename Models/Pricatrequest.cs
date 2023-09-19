using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Pricatrequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AvsAdresseId property</summary>
        public int? AvsAdresseId { get; set; }
        /// <summary>The ClientId property</summary>
        public int? ClientId { get; set; }
        /// <summary>The Clientnr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Clientnr { get; set; }
#nullable restore
#else
        public string Clientnr { get; set; }
#endif
        /// <summary>The Currency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
#endif
        /// <summary>The CurrencyHistoryId property</summary>
        public int? CurrencyHistoryId { get; set; }
        /// <summary>The EndDate property</summary>
        public DateTimeOffset? EndDate { get; set; }
        /// <summary>The ListPriceGroupId property</summary>
        public int? ListPriceGroupId { get; set; }
        /// <summary>The ManufacturerId property</summary>
        public int? ManufacturerId { get; set; }
        /// <summary>The PreOrderEndDate property</summary>
        public DateTimeOffset? PreOrderEndDate { get; set; }
        /// <summary>The Procedure property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Procedure { get; set; }
#nullable restore
#else
        public string Procedure { get; set; }
#endif
        /// <summary>The Productnr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Productnr { get; set; }
#nullable restore
#else
        public string Productnr { get; set; }
#endif
        /// <summary>The RetailPriceGroupId1 property</summary>
        public int? RetailPriceGroupId1 { get; set; }
        /// <summary>The RetailPriceGroupId2 property</summary>
        public int? RetailPriceGroupId2 { get; set; }
        /// <summary>The RetailPriceGroupId3 property</summary>
        public int? RetailPriceGroupId3 { get; set; }
        /// <summary>The Season property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Season { get; set; }
#nullable restore
#else
        public string Season { get; set; }
#endif
        /// <summary>The StartDate property</summary>
        public DateTimeOffset? StartDate { get; set; }
        /// <summary>The StorageId property</summary>
        public int? StorageId { get; set; }
        /// <summary>
        /// Instantiates a new Pricatrequest and sets the default values.
        /// </summary>
        public Pricatrequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Pricatrequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Pricatrequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AvsAdresseId", n => { AvsAdresseId = n.GetIntValue(); } },
                {"ClientId", n => { ClientId = n.GetIntValue(); } },
                {"Clientnr", n => { Clientnr = n.GetStringValue(); } },
                {"Currency", n => { Currency = n.GetStringValue(); } },
                {"CurrencyHistoryId", n => { CurrencyHistoryId = n.GetIntValue(); } },
                {"EndDate", n => { EndDate = n.GetDateTimeOffsetValue(); } },
                {"ListPriceGroupId", n => { ListPriceGroupId = n.GetIntValue(); } },
                {"ManufacturerId", n => { ManufacturerId = n.GetIntValue(); } },
                {"PreOrderEndDate", n => { PreOrderEndDate = n.GetDateTimeOffsetValue(); } },
                {"Procedure", n => { Procedure = n.GetStringValue(); } },
                {"Productnr", n => { Productnr = n.GetStringValue(); } },
                {"RetailPriceGroupId1", n => { RetailPriceGroupId1 = n.GetIntValue(); } },
                {"RetailPriceGroupId2", n => { RetailPriceGroupId2 = n.GetIntValue(); } },
                {"RetailPriceGroupId3", n => { RetailPriceGroupId3 = n.GetIntValue(); } },
                {"Season", n => { Season = n.GetStringValue(); } },
                {"StartDate", n => { StartDate = n.GetDateTimeOffsetValue(); } },
                {"StorageId", n => { StorageId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("AvsAdresseId", AvsAdresseId);
            writer.WriteIntValue("ClientId", ClientId);
            writer.WriteStringValue("Clientnr", Clientnr);
            writer.WriteStringValue("Currency", Currency);
            writer.WriteIntValue("CurrencyHistoryId", CurrencyHistoryId);
            writer.WriteDateTimeOffsetValue("EndDate", EndDate);
            writer.WriteIntValue("ListPriceGroupId", ListPriceGroupId);
            writer.WriteIntValue("ManufacturerId", ManufacturerId);
            writer.WriteDateTimeOffsetValue("PreOrderEndDate", PreOrderEndDate);
            writer.WriteStringValue("Procedure", Procedure);
            writer.WriteStringValue("Productnr", Productnr);
            writer.WriteIntValue("RetailPriceGroupId1", RetailPriceGroupId1);
            writer.WriteIntValue("RetailPriceGroupId2", RetailPriceGroupId2);
            writer.WriteIntValue("RetailPriceGroupId3", RetailPriceGroupId3);
            writer.WriteStringValue("Season", Season);
            writer.WriteDateTimeOffsetValue("StartDate", StartDate);
            writer.WriteIntValue("StorageId", StorageId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
