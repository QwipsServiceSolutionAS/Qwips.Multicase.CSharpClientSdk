using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Pricat20parameters : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ButikkKundeNr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ButikkKundeNr { get; set; }
#nullable restore
#else
        public string ButikkKundeNr { get; set; }
#endif
        /// <summary>The ListePrisGruppeId property</summary>
        public int? ListePrisGruppeId { get; set; }
        /// <summary>The Season property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Season { get; set; }
#nullable restore
#else
        public string Season { get; set; }
#endif
        /// <summary>The VeilPrisgruppeId1 property</summary>
        public int? VeilPrisgruppeId1 { get; set; }
        /// <summary>The VeilPrisgruppeId2 property</summary>
        public int? VeilPrisgruppeId2 { get; set; }
        /// <summary>The VeilPrisgruppeId3 property</summary>
        public int? VeilPrisgruppeId3 { get; set; }
        /// <summary>
        /// Instantiates a new pricat20parameters and sets the default values.
        /// </summary>
        public Pricat20parameters() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Pricat20parameters CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Pricat20parameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ButikkKundeNr", n => { ButikkKundeNr = n.GetStringValue(); } },
                {"ListePrisGruppeId", n => { ListePrisGruppeId = n.GetIntValue(); } },
                {"Season", n => { Season = n.GetStringValue(); } },
                {"VeilPrisgruppeId1", n => { VeilPrisgruppeId1 = n.GetIntValue(); } },
                {"VeilPrisgruppeId2", n => { VeilPrisgruppeId2 = n.GetIntValue(); } },
                {"VeilPrisgruppeId3", n => { VeilPrisgruppeId3 = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ButikkKundeNr", ButikkKundeNr);
            writer.WriteIntValue("ListePrisGruppeId", ListePrisGruppeId);
            writer.WriteStringValue("Season", Season);
            writer.WriteIntValue("VeilPrisgruppeId1", VeilPrisgruppeId1);
            writer.WriteIntValue("VeilPrisgruppeId2", VeilPrisgruppeId2);
            writer.WriteIntValue("VeilPrisgruppeId3", VeilPrisgruppeId3);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
