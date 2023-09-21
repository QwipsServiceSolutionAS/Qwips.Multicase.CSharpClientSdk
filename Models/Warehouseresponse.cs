using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Warehouseresponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The SenderId property</summary>
        public int? SenderId { get; set; }
        /// <summary>The WarehouseId property</summary>
        public int? WarehouseId { get; set; }
        /// <summary>The WarehouseName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WarehouseName { get; set; }
#nullable restore
#else
        public string WarehouseName { get; set; }
#endif
        /// <summary>The WarehouseType property</summary>
        public int? WarehouseType { get; set; }
        /// <summary>
        /// Instantiates a new Warehouseresponse and sets the default values.
        /// </summary>
        public Warehouseresponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Warehouseresponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Warehouseresponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"SenderId", n => { SenderId = n.GetIntValue(); } },
                {"WarehouseId", n => { WarehouseId = n.GetIntValue(); } },
                {"WarehouseName", n => { WarehouseName = n.GetStringValue(); } },
                {"WarehouseType", n => { WarehouseType = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("SenderId", SenderId);
            writer.WriteIntValue("WarehouseId", WarehouseId);
            writer.WriteStringValue("WarehouseName", WarehouseName);
            writer.WriteIntValue("WarehouseType", WarehouseType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
