using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Weeklycombinedinvoicing : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The WeekDay1 property</summary>
        public Dayofweekenum? WeekDay1 { get; set; }
        /// <summary>The WeekDay2 property</summary>
        public Dayofweekenum? WeekDay2 { get; set; }
        /// <summary>
        /// Instantiates a new weeklycombinedinvoicing and sets the default values.
        /// </summary>
        public Weeklycombinedinvoicing() {
            AdditionalData = new Dictionary<string, object>();
            WeekDay1 = Dayofweekenum.Sunday;
            WeekDay2 = Dayofweekenum.Sunday;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Weeklycombinedinvoicing CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Weeklycombinedinvoicing();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"WeekDay1", n => { WeekDay1 = n.GetEnumValue<Dayofweekenum>(); } },
                {"WeekDay2", n => { WeekDay2 = n.GetEnumValue<Dayofweekenum>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Dayofweekenum>("WeekDay1", WeekDay1);
            writer.WriteEnumValue<Dayofweekenum>("WeekDay2", WeekDay2);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
