using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Updateprocessedbundle : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The BundleId property</summary>
        public int? BundleId { get; set; }
        /// <summary>The Processed property</summary>
        public bool? Processed { get; set; }
        /// <summary>The UpdateBundleLines property</summary>
        public bool? UpdateBundleLines { get; set; }
        /// <summary>
        /// Instantiates a new Updateprocessedbundle and sets the default values.
        /// </summary>
        public Updateprocessedbundle() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Updateprocessedbundle CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Updateprocessedbundle();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"BundleId", n => { BundleId = n.GetIntValue(); } },
                {"Processed", n => { Processed = n.GetBoolValue(); } },
                {"UpdateBundleLines", n => { UpdateBundleLines = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("BundleId", BundleId);
            writer.WriteBoolValue("Processed", Processed);
            writer.WriteBoolValue("UpdateBundleLines", UpdateBundleLines);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
