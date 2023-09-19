using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Setgiftcardtransactionordrehodeid : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OrdreHodeID property</summary>
        public int? OrdreHodeID { get; set; }
        /// <summary>The Web30CartID property</summary>
        public int? Web30CartID { get; set; }
        /// <summary>
        /// Instantiates a new Setgiftcardtransactionordrehodeid and sets the default values.
        /// </summary>
        public Setgiftcardtransactionordrehodeid() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Setgiftcardtransactionordrehodeid CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Setgiftcardtransactionordrehodeid();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"OrdreHodeID", n => { OrdreHodeID = n.GetIntValue(); } },
                {"Web30CartID", n => { Web30CartID = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("OrdreHodeID", OrdreHodeID);
            writer.WriteIntValue("Web30CartID", Web30CartID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
