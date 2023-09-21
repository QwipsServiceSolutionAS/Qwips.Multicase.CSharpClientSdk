using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Orderline : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Amount property</summary>
        public double? Amount { get; set; }
        /// <summary>The DeliveryDate property</summary>
        public DateTimeOffset? DeliveryDate { get; set; }
        /// <summary>The Extra property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderlineextra? Extra { get; set; }
#nullable restore
#else
        public Orderlineextra Extra { get; set; }
#endif
        /// <summary>The Info property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderlineinfo? Info { get; set; }
#nullable restore
#else
        public Orderlineinfo Info { get; set; }
#endif
        /// <summary>The PosNo property</summary>
        public int? PosNo { get; set; }
        /// <summary>The ProductDesc property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductDesc { get; set; }
#nullable restore
#else
        public string ProductDesc { get; set; }
#endif
        /// <summary>The ProductID property</summary>
        public int? ProductID { get; set; }
        /// <summary>The ProductNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductNumber { get; set; }
#nullable restore
#else
        public string ProductNumber { get; set; }
#endif
        /// <summary>The UnitPrice property</summary>
        public double? UnitPrice { get; set; }
        /// <summary>The WarehouseID property</summary>
        public int? WarehouseID { get; set; }
        /// <summary>
        /// Instantiates a new orderline and sets the default values.
        /// </summary>
        public Orderline() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderline CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderline();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Amount", n => { Amount = n.GetDoubleValue(); } },
                {"DeliveryDate", n => { DeliveryDate = n.GetDateTimeOffsetValue(); } },
                {"Extra", n => { Extra = n.GetObjectValue<Orderlineextra>(Orderlineextra.CreateFromDiscriminatorValue); } },
                {"Info", n => { Info = n.GetObjectValue<Orderlineinfo>(Orderlineinfo.CreateFromDiscriminatorValue); } },
                {"PosNo", n => { PosNo = n.GetIntValue(); } },
                {"ProductDesc", n => { ProductDesc = n.GetStringValue(); } },
                {"ProductID", n => { ProductID = n.GetIntValue(); } },
                {"ProductNumber", n => { ProductNumber = n.GetStringValue(); } },
                {"UnitPrice", n => { UnitPrice = n.GetDoubleValue(); } },
                {"WarehouseID", n => { WarehouseID = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("Amount", Amount);
            writer.WriteDateTimeOffsetValue("DeliveryDate", DeliveryDate);
            writer.WriteObjectValue<Orderlineextra>("Extra", Extra);
            writer.WriteObjectValue<Orderlineinfo>("Info", Info);
            writer.WriteIntValue("PosNo", PosNo);
            writer.WriteStringValue("ProductDesc", ProductDesc);
            writer.WriteIntValue("ProductID", ProductID);
            writer.WriteStringValue("ProductNumber", ProductNumber);
            writer.WriteDoubleValue("UnitPrice", UnitPrice);
            writer.WriteIntValue("WarehouseID", WarehouseID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
