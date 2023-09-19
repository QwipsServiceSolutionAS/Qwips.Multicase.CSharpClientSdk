using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Productgroupparameters : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The PrdGruppeLev1ID property</summary>
        public int? PrdGruppeLev1ID { get; set; }
        /// <summary>The PrdGruppeLev2ID property</summary>
        public int? PrdGruppeLev2ID { get; set; }
        /// <summary>The PrdGruppeLev3ID property</summary>
        public int? PrdGruppeLev3ID { get; set; }
        /// <summary>
        /// Instantiates a new productgroupparameters and sets the default values.
        /// </summary>
        public Productgroupparameters() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Productgroupparameters CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Productgroupparameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"PrdGruppeLev1ID", n => { PrdGruppeLev1ID = n.GetIntValue(); } },
                {"PrdGruppeLev2ID", n => { PrdGruppeLev2ID = n.GetIntValue(); } },
                {"PrdGruppeLev3ID", n => { PrdGruppeLev3ID = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("PrdGruppeLev1ID", PrdGruppeLev1ID);
            writer.WriteIntValue("PrdGruppeLev2ID", PrdGruppeLev2ID);
            writer.WriteIntValue("PrdGruppeLev3ID", PrdGruppeLev3ID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
