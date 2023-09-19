using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Qwips.Core.MultiCase.Models {
    public class Getproductpriceex : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CustomerId property</summary>
        public int? CustomerID { get; set; }
        /// <summary>The Products property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Productamount>? Products { get; set; }
#nullable restore
#else
        public List<Productamount> Products { get; set; }
#endif
        /// <summary>The WarehouseId property</summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        public int? WarehouseId { get; set; }
        /// <summary>
        /// Instantiates a new Getproductpriceex and sets the default values.
        /// </summary>
        public Getproductpriceex() {
            AdditionalData = new Dictionary<string, object>();

        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Getproductpriceex CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Getproductpriceex();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CustomerID", n => { CustomerID = n.GetIntValue(); } },
                {"Products", n => { Products = n.GetCollectionOfObjectValues<Productamount>(Productamount.CreateFromDiscriminatorValue)?.ToList(); } },
                {"WarehouseId", n => { WarehouseId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("CustomerID", CustomerID);
            writer.WriteCollectionOfObjectValues<Productamount>("Products", Products);
            if (WarehouseId == null)
                writer.WriteNullValue("WarehouseId");
            else
                writer.WriteIntValue("WarehouseId", WarehouseId);
            
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
