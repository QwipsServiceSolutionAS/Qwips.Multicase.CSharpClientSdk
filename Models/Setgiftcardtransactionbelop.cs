using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Setgiftcardtransactionbelop : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Belop property</summary>
        public double? Belop { get; set; }
        /// <summary>The GavekortTransID property</summary>
        public int? GavekortTransID { get; set; }
        /// <summary>The ValutaHistoryID property</summary>
        public int? ValutaHistoryID { get; set; }
        /// <summary>
        /// Instantiates a new Setgiftcardtransactionbelop and sets the default values.
        /// </summary>
        public Setgiftcardtransactionbelop() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Setgiftcardtransactionbelop CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Setgiftcardtransactionbelop();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Belop", n => { Belop = n.GetDoubleValue(); } },
                {"GavekortTransID", n => { GavekortTransID = n.GetIntValue(); } },
                {"ValutaHistoryID", n => { ValutaHistoryID = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("Belop", Belop);
            writer.WriteIntValue("GavekortTransID", GavekortTransID);
            writer.WriteIntValue("ValutaHistoryID", ValutaHistoryID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
