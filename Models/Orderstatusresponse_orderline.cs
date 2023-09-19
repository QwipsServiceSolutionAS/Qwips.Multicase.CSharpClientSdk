using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Orderstatusresponse_orderline : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CurrencyCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>The DateOfAction property</summary>
        public DateTimeOffset? DateOfAction { get; set; }
        /// <summary>The Delivered property</summary>
        public double? Delivered { get; set; }
        /// <summary>The Deliveries property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Orderlinedelivery>? Deliveries { get; set; }
#nullable restore
#else
        public List<Orderlinedelivery> Deliveries { get; set; }
#endif
        /// <summary>The ExternalPosition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalPosition { get; set; }
#nullable restore
#else
        public string ExternalPosition { get; set; }
#endif
        /// <summary>The Extra1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Extra1 { get; set; }
#nullable restore
#else
        public string Extra1 { get; set; }
#endif
        /// <summary>The Extra2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Extra2 { get; set; }
#nullable restore
#else
        public string Extra2 { get; set; }
#endif
        /// <summary>The Extra3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Extra3 { get; set; }
#nullable restore
#else
        public string Extra3 { get; set; }
#endif
        /// <summary>The Extra4 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Extra4 { get; set; }
#nullable restore
#else
        public string Extra4 { get; set; }
#endif
        /// <summary>The ListPrice property</summary>
        public double? ListPrice { get; set; }
        /// <summary>The OrderLineId property</summary>
        public int? OrderLineId { get; set; }
        /// <summary>The OrderLineStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderstatusresponse_orderlinestatus? OrderLineStatus { get; set; }
#nullable restore
#else
        public Orderstatusresponse_orderlinestatus OrderLineStatus { get; set; }
#endif
        /// <summary>The Picked property</summary>
        public double? Picked { get; set; }
        /// <summary>The Position property</summary>
        public int? Position { get; set; }
        /// <summary>The Product property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderstatusresponse_product? Product { get; set; }
#nullable restore
#else
        public Orderstatusresponse_product Product { get; set; }
#endif
        /// <summary>The Quantity property</summary>
        public double? Quantity { get; set; }
        /// <summary>The ReadyToBeDelivered property</summary>
        public double? ReadyToBeDelivered { get; set; }
        /// <summary>The Tax property</summary>
        public double? Tax { get; set; }
        /// <summary>The TaxPercent property</summary>
        public double? TaxPercent { get; set; }
        /// <summary>The UnitPrice property</summary>
        public double? UnitPrice { get; set; }
        /// <summary>
        /// Instantiates a new orderstatusresponse_orderline and sets the default values.
        /// </summary>
        public Orderstatusresponse_orderline() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderstatusresponse_orderline CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderstatusresponse_orderline();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CurrencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"DateOfAction", n => { DateOfAction = n.GetDateTimeOffsetValue(); } },
                {"Delivered", n => { Delivered = n.GetDoubleValue(); } },
                {"Deliveries", n => { Deliveries = n.GetCollectionOfObjectValues<Orderlinedelivery>(Orderlinedelivery.CreateFromDiscriminatorValue)?.ToList(); } },
                {"ExternalPosition", n => { ExternalPosition = n.GetStringValue(); } },
                {"Extra1", n => { Extra1 = n.GetStringValue(); } },
                {"Extra2", n => { Extra2 = n.GetStringValue(); } },
                {"Extra3", n => { Extra3 = n.GetStringValue(); } },
                {"Extra4", n => { Extra4 = n.GetStringValue(); } },
                {"ListPrice", n => { ListPrice = n.GetDoubleValue(); } },
                {"OrderLineId", n => { OrderLineId = n.GetIntValue(); } },
                {"OrderLineStatus", n => { OrderLineStatus = n.GetObjectValue<Orderstatusresponse_orderlinestatus>(Orderstatusresponse_orderlinestatus.CreateFromDiscriminatorValue); } },
                {"Picked", n => { Picked = n.GetDoubleValue(); } },
                {"Position", n => { Position = n.GetIntValue(); } },
                {"Product", n => { Product = n.GetObjectValue<Orderstatusresponse_product>(Orderstatusresponse_product.CreateFromDiscriminatorValue); } },
                {"Quantity", n => { Quantity = n.GetDoubleValue(); } },
                {"ReadyToBeDelivered", n => { ReadyToBeDelivered = n.GetDoubleValue(); } },
                {"Tax", n => { Tax = n.GetDoubleValue(); } },
                {"TaxPercent", n => { TaxPercent = n.GetDoubleValue(); } },
                {"UnitPrice", n => { UnitPrice = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("CurrencyCode", CurrencyCode);
            writer.WriteDateTimeOffsetValue("DateOfAction", DateOfAction);
            writer.WriteDoubleValue("Delivered", Delivered);
            writer.WriteCollectionOfObjectValues<Orderlinedelivery>("Deliveries", Deliveries);
            writer.WriteStringValue("ExternalPosition", ExternalPosition);
            writer.WriteStringValue("Extra1", Extra1);
            writer.WriteStringValue("Extra2", Extra2);
            writer.WriteStringValue("Extra3", Extra3);
            writer.WriteStringValue("Extra4", Extra4);
            writer.WriteDoubleValue("ListPrice", ListPrice);
            writer.WriteIntValue("OrderLineId", OrderLineId);
            writer.WriteObjectValue<Orderstatusresponse_orderlinestatus>("OrderLineStatus", OrderLineStatus);
            writer.WriteDoubleValue("Picked", Picked);
            writer.WriteIntValue("Position", Position);
            writer.WriteObjectValue<Orderstatusresponse_product>("Product", Product);
            writer.WriteDoubleValue("Quantity", Quantity);
            writer.WriteDoubleValue("ReadyToBeDelivered", ReadyToBeDelivered);
            writer.WriteDoubleValue("Tax", Tax);
            writer.WriteDoubleValue("TaxPercent", TaxPercent);
            writer.WriteDoubleValue("UnitPrice", UnitPrice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
