using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Productsstocklevel : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AvailableForSale property</summary>
        public double? AvailableForSale { get; set; }
        /// <summary>The AvailableFromPurchaseOrders property</summary>
        public double? AvailableFromPurchaseOrders { get; set; }
        /// <summary>The AvailableFromSuppliers property</summary>
        public double? AvailableFromSuppliers { get; set; }
        /// <summary>The AvailableInWarehouse property</summary>
        public double? AvailableInWarehouse { get; set; }
        /// <summary>The ETA property</summary>
        public DateTimeOffset? ETA { get; set; }
        /// <summary>The ETAConfirmed property</summary>
        public bool? ETAConfirmed { get; set; }
        /// <summary>The ProductId property</summary>
        public int? ProductId { get; set; }
        /// <summary>The ProductStockId property</summary>
        public int? ProductStockId { get; set; }
        /// <summary>The WarehouseId property</summary>
        public int? WarehouseId { get; set; }
        /// <summary>
        /// Instantiates a new Productsstocklevel and sets the default values.
        /// </summary>
        public Productsstocklevel() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Productsstocklevel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Productsstocklevel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AvailableForSale", n => { AvailableForSale = n.GetDoubleValue(); } },
                {"AvailableFromPurchaseOrders", n => { AvailableFromPurchaseOrders = n.GetDoubleValue(); } },
                {"AvailableFromSuppliers", n => { AvailableFromSuppliers = n.GetDoubleValue(); } },
                {"AvailableInWarehouse", n => { AvailableInWarehouse = n.GetDoubleValue(); } },
                {"ETA", n => { ETA = n.GetDateTimeOffsetValue(); } },
                {"ETAConfirmed", n => { ETAConfirmed = n.GetBoolValue(); } },
                {"ProductId", n => { ProductId = n.GetIntValue(); } },
                {"ProductStockId", n => { ProductStockId = n.GetIntValue(); } },
                {"WarehouseId", n => { WarehouseId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("AvailableForSale", AvailableForSale);
            writer.WriteDoubleValue("AvailableFromPurchaseOrders", AvailableFromPurchaseOrders);
            writer.WriteDoubleValue("AvailableFromSuppliers", AvailableFromSuppliers);
            writer.WriteDoubleValue("AvailableInWarehouse", AvailableInWarehouse);
            writer.WriteDateTimeOffsetValue("ETA", ETA);
            writer.WriteBoolValue("ETAConfirmed", ETAConfirmed);
            writer.WriteIntValue("ProductId", ProductId);
            writer.WriteIntValue("ProductStockId", ProductStockId);
            writer.WriteIntValue("WarehouseId", WarehouseId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
