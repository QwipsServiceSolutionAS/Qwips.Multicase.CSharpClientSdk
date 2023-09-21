using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Customerlistresponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Customers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Customer1>? Customers { get; set; }
#nullable restore
#else
        public List<Customer1> Customers { get; set; }
#endif
        /// <summary>The Timestamp property</summary>
        public long? Timestamp { get; set; }
        /// <summary>
        /// Instantiates a new Customerlistresponse and sets the default values.
        /// </summary>
        public Customerlistresponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Customerlistresponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Customerlistresponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Customers", n => { Customers = n.GetCollectionOfObjectValues<Customer1>(Customer1.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Timestamp", n => { Timestamp = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Customer1>("Customers", Customers);
            writer.WriteLongValue("Timestamp", Timestamp);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
