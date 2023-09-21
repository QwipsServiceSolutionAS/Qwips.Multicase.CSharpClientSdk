using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Product : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ProductDescription property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductDescription { get; set; }
#nullable restore
#else
        public string ProductDescription { get; set; }
#endif
        /// <summary>The ProductDescription2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductDescription2 { get; set; }
#nullable restore
#else
        public string ProductDescription2 { get; set; }
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
        /// <summary>
        /// Instantiates a new product and sets the default values.
        /// </summary>
        public Product() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Product CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Product();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ProductDescription", n => { ProductDescription = n.GetStringValue(); } },
                {"ProductDescription2", n => { ProductDescription2 = n.GetStringValue(); } },
                {"ProductID", n => { ProductID = n.GetIntValue(); } },
                {"ProductNumber", n => { ProductNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ProductDescription", ProductDescription);
            writer.WriteStringValue("ProductDescription2", ProductDescription2);
            writer.WriteIntValue("ProductID", ProductID);
            writer.WriteStringValue("ProductNumber", ProductNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
