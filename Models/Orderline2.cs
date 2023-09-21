using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Orderline2 : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Amount property</summary>
        public double? Amount { get; set; }
        /// <summary>The ChangeType property</summary>
        public Orderlinechangetypeenum? ChangeType { get; set; }
        /// <summary>The CombinedDelivery property</summary>
        public bool? CombinedDelivery { get; set; }
        /// <summary>The Cost property</summary>
        public double? Cost { get; set; }
        /// <summary>The DaysInProduction property</summary>
        public int? DaysInProduction { get; set; }
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
        /// <summary>The FifoDate property</summary>
        public DateTimeOffset? FifoDate { get; set; }
        /// <summary>The InfoXML property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InfoXML { get; set; }
#nullable restore
#else
        public string InfoXML { get; set; }
#endif
        /// <summary>The OrderLineId property</summary>
        public int? OrderLineId { get; set; }
        /// <summary>The Product property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Product2? Product { get; set; }
#nullable restore
#else
        public Product2 Product { get; set; }
#endif
        /// <summary>The UnitPrice property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Unitprice1? UnitPrice { get; set; }
#nullable restore
#else
        public Unitprice1 UnitPrice { get; set; }
#endif
        /// <summary>The Warehouse property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Warehouse1? Warehouse { get; set; }
#nullable restore
#else
        public Warehouse1 Warehouse { get; set; }
#endif
        /// <summary>
        /// Instantiates a new orderline2 and sets the default values.
        /// </summary>
        public Orderline2() {
            AdditionalData = new Dictionary<string, object>();
            ChangeType = Orderlinechangetypeenum.None;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderline2 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderline2();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Amount", n => { Amount = n.GetDoubleValue(); } },
                {"ChangeType", n => { ChangeType = n.GetEnumValue<Orderlinechangetypeenum>(); } },
                {"CombinedDelivery", n => { CombinedDelivery = n.GetBoolValue(); } },
                {"Cost", n => { Cost = n.GetDoubleValue(); } },
                {"DaysInProduction", n => { DaysInProduction = n.GetIntValue(); } },
                {"Extra1", n => { Extra1 = n.GetStringValue(); } },
                {"Extra2", n => { Extra2 = n.GetStringValue(); } },
                {"Extra3", n => { Extra3 = n.GetStringValue(); } },
                {"Extra4", n => { Extra4 = n.GetStringValue(); } },
                {"FifoDate", n => { FifoDate = n.GetDateTimeOffsetValue(); } },
                {"InfoXML", n => { InfoXML = n.GetStringValue(); } },
                {"OrderLineId", n => { OrderLineId = n.GetIntValue(); } },
                {"Product", n => { Product = n.GetObjectValue<Product2>(Product2.CreateFromDiscriminatorValue); } },
                {"UnitPrice", n => { UnitPrice = n.GetObjectValue<Unitprice1>(Unitprice1.CreateFromDiscriminatorValue); } },
                {"Warehouse", n => { Warehouse = n.GetObjectValue<Warehouse1>(Warehouse1.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("Amount", Amount);
            writer.WriteEnumValue<Orderlinechangetypeenum>("ChangeType", ChangeType);
            writer.WriteBoolValue("CombinedDelivery", CombinedDelivery);
            writer.WriteDoubleValue("Cost", Cost);
            writer.WriteIntValue("DaysInProduction", DaysInProduction);
            writer.WriteStringValue("Extra1", Extra1);
            writer.WriteStringValue("Extra2", Extra2);
            writer.WriteStringValue("Extra3", Extra3);
            writer.WriteStringValue("Extra4", Extra4);
            writer.WriteDateTimeOffsetValue("FifoDate", FifoDate);
            writer.WriteStringValue("InfoXML", InfoXML);
            writer.WriteIntValue("OrderLineId", OrderLineId);
            writer.WriteObjectValue<Product2>("Product", Product);
            writer.WriteObjectValue<Unitprice1>("UnitPrice", UnitPrice);
            writer.WriteObjectValue<Warehouse1>("Warehouse", Warehouse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
