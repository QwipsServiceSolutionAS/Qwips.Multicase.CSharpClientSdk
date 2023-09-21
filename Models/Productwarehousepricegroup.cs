using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Productwarehousepricegroup : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Currency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
#endif
        /// <summary>The ListPrice property</summary>
        public double? ListPrice { get; set; }
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The PriceGroupID property</summary>
        public int? PriceGroupID { get; set; }
        /// <summary>The TaxRate property</summary>
        public double? TaxRate { get; set; }
        /// <summary>
        /// Instantiates a new productwarehousepricegroup and sets the default values.
        /// </summary>
        public Productwarehousepricegroup() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Productwarehousepricegroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Productwarehousepricegroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Currency", n => { Currency = n.GetStringValue(); } },
                {"ListPrice", n => { ListPrice = n.GetDoubleValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"PriceGroupID", n => { PriceGroupID = n.GetIntValue(); } },
                {"TaxRate", n => { TaxRate = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Currency", Currency);
            writer.WriteDoubleValue("ListPrice", ListPrice);
            writer.WriteStringValue("Name", Name);
            writer.WriteIntValue("PriceGroupID", PriceGroupID);
            writer.WriteDoubleValue("TaxRate", TaxRate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
