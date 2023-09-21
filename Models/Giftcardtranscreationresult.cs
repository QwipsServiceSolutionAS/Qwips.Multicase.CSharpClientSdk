using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Giftcardtranscreationresult : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ErrorMsg property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorMsg { get; set; }
#nullable restore
#else
        public string ErrorMsg { get; set; }
#endif
        /// <summary>The GavekortTransID property</summary>
        public int? GavekortTransID { get; set; }
        /// <summary>
        /// Instantiates a new Giftcardtranscreationresult and sets the default values.
        /// </summary>
        public Giftcardtranscreationresult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Giftcardtranscreationresult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Giftcardtranscreationresult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ErrorMsg", n => { ErrorMsg = n.GetStringValue(); } },
                {"GavekortTransID", n => { GavekortTransID = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ErrorMsg", ErrorMsg);
            writer.WriteIntValue("GavekortTransID", GavekortTransID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
