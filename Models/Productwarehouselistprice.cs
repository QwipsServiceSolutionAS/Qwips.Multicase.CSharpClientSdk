using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Productwarehouselistprice : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The PriceGroup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Productwarehousepricegroup? PriceGroup { get; set; }
#nullable restore
#else
        public Productwarehousepricegroup PriceGroup { get; set; }
#endif
        /// <summary>The ProductWarehouseID property</summary>
        public int? ProductWarehouseID { get; set; }
        /// <summary>The WarehouseID property</summary>
        public int? WarehouseID { get; set; }
        /// <summary>
        /// Instantiates a new productwarehouselistprice and sets the default values.
        /// </summary>
        public Productwarehouselistprice() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Productwarehouselistprice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Productwarehouselistprice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Name", n => { Name = n.GetStringValue(); } },
                {"PriceGroup", n => { PriceGroup = n.GetObjectValue<Productwarehousepricegroup>(Productwarehousepricegroup.CreateFromDiscriminatorValue); } },
                {"ProductWarehouseID", n => { ProductWarehouseID = n.GetIntValue(); } },
                {"WarehouseID", n => { WarehouseID = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Name", Name);
            writer.WriteObjectValue<Productwarehousepricegroup>("PriceGroup", PriceGroup);
            writer.WriteIntValue("ProductWarehouseID", ProductWarehouseID);
            writer.WriteIntValue("WarehouseID", WarehouseID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
