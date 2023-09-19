using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Productprice1 : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Amount property</summary>
        public double? Amount { get; set; }
        /// <summary>The CustomerId property</summary>
        public int? CustomerId { get; set; }
        /// <summary>The PriceExVat property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Amount? PriceExVat { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Amount PriceExVat { get; set; }
#endif
        /// <summary>The PriceIncVat property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Amount? PriceIncVat { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Amount PriceIncVat { get; set; }
#endif
        /// <summary>The ProductId property</summary>
        public int? ProductId { get; set; }
        /// <summary>The ProductWarehouseId property</summary>
        public int? ProductWarehouseId { get; set; }
        /// <summary>The WarehouseId property</summary>
        public int? WarehouseId { get; set; }
        /// <summary>
        /// Instantiates a new Productprice1 and sets the default values.
        /// </summary>
        public Productprice1() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Productprice1 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Productprice1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Amount", n => { Amount = n.GetDoubleValue(); } },
                {"CustomerId", n => { CustomerId = n.GetIntValue(); } },
                {"PriceExVat", n => { PriceExVat = n.GetObjectValue<Qwips.Core.MultiCase.Models.Amount>(Qwips.Core.MultiCase.Models.Amount.CreateFromDiscriminatorValue); } },
                {"PriceIncVat", n => { PriceIncVat = n.GetObjectValue<Qwips.Core.MultiCase.Models.Amount>(Qwips.Core.MultiCase.Models.Amount.CreateFromDiscriminatorValue); } },
                {"ProductId", n => { ProductId = n.GetIntValue(); } },
                {"ProductWarehouseId", n => { ProductWarehouseId = n.GetIntValue(); } },
                {"WarehouseId", n => { WarehouseId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("Amount", Amount);
            writer.WriteIntValue("CustomerId", CustomerId);
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Amount>("PriceExVat", PriceExVat);
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Amount>("PriceIncVat", PriceIncVat);
            writer.WriteIntValue("ProductId", ProductId);
            writer.WriteIntValue("ProductWarehouseId", ProductWarehouseId);
            writer.WriteIntValue("WarehouseId", WarehouseId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
