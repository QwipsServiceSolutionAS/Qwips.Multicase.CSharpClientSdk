using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Insertedorder : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ExternalOrderNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalOrderNumber { get; set; }
#nullable restore
#else
        public string ExternalOrderNumber { get; set; }
#endif
        /// <summary>The OrderHeadID property</summary>
        public int? OrderHeadID { get; set; }
        /// <summary>The OrderNumber property</summary>
        public int? OrderNumber { get; set; }
        /// <summary>
        /// Instantiates a new insertedorder and sets the default values.
        /// </summary>
        public Insertedorder() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Insertedorder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Insertedorder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ExternalOrderNumber", n => { ExternalOrderNumber = n.GetStringValue(); } },
                {"OrderHeadID", n => { OrderHeadID = n.GetIntValue(); } },
                {"OrderNumber", n => { OrderNumber = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ExternalOrderNumber", ExternalOrderNumber);
            writer.WriteIntValue("OrderHeadID", OrderHeadID);
            writer.WriteIntValue("OrderNumber", OrderNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
