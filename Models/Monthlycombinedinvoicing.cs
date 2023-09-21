using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Monthlycombinedinvoicing : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The DayOfMonth1 property</summary>
        public int? DayOfMonth1 { get; set; }
        /// <summary>The DayOfMonth2 property</summary>
        public int? DayOfMonth2 { get; set; }
        /// <summary>
        /// Instantiates a new monthlycombinedinvoicing and sets the default values.
        /// </summary>
        public Monthlycombinedinvoicing() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Monthlycombinedinvoicing CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Monthlycombinedinvoicing();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"DayOfMonth1", n => { DayOfMonth1 = n.GetIntValue(); } },
                {"DayOfMonth2", n => { DayOfMonth2 = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("DayOfMonth1", DayOfMonth1);
            writer.WriteIntValue("DayOfMonth2", DayOfMonth2);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
