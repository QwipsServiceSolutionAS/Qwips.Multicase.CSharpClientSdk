using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Linkproduct : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AvsAdresseID property</summary>
        public int? AvsAdresseID { get; set; }
        /// <summary>The BrukerID property</summary>
        public int? BrukerID { get; set; }
        /// <summary>The FunctionMethod property</summary>
        public int? FunctionMethod { get; set; }
        /// <summary>The ProductNr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductNr { get; set; }
#nullable restore
#else
        public string ProductNr { get; set; }
#endif
        /// <summary>
        /// Instantiates a new linkproduct and sets the default values.
        /// </summary>
        public Linkproduct() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Linkproduct CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Linkproduct();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AvsAdresseID", n => { AvsAdresseID = n.GetIntValue(); } },
                {"BrukerID", n => { BrukerID = n.GetIntValue(); } },
                {"FunctionMethod", n => { FunctionMethod = n.GetIntValue(); } },
                {"ProductNr", n => { ProductNr = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("AvsAdresseID", AvsAdresseID);
            writer.WriteIntValue("BrukerID", BrukerID);
            writer.WriteIntValue("FunctionMethod", FunctionMethod);
            writer.WriteStringValue("ProductNr", ProductNr);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
