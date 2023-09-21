using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Productslist : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Products property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Productresponse>? Products { get; set; }
#nullable restore
#else
        public List<Productresponse> Products { get; set; }
#endif
        /// <summary>The RetrieveTimestamp property</summary>
        public long? RetrieveTimestamp { get; set; }
        /// <summary>
        /// Instantiates a new Productslist and sets the default values.
        /// </summary>
        public Productslist() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Productslist CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Productslist();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Products", n => { Products = n.GetCollectionOfObjectValues<Productresponse>(Productresponse.CreateFromDiscriminatorValue)?.ToList(); } },
                {"RetrieveTimestamp", n => { RetrieveTimestamp = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Productresponse>("Products", Products);
            writer.WriteLongValue("RetrieveTimestamp", RetrieveTimestamp);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
