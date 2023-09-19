using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Ordreholdstatus : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Aktiv property</summary>
        public bool? Aktiv { get; set; }
        /// <summary>The OrdreHoldShortTxt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrdreHoldShortTxt { get; set; }
#nullable restore
#else
        public string OrdreHoldShortTxt { get; set; }
#endif
        /// <summary>The OrdreHoldStatusID property</summary>
        public int? OrdreHoldStatusID { get; set; }
        /// <summary>The OrdreHoldTxt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrdreHoldTxt { get; set; }
#nullable restore
#else
        public string OrdreHoldTxt { get; set; }
#endif
        /// <summary>The Prioritet property</summary>
        public int? Prioritet { get; set; }
        /// <summary>
        /// Instantiates a new ordreholdstatus and sets the default values.
        /// </summary>
        public Ordreholdstatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Ordreholdstatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Ordreholdstatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Aktiv", n => { Aktiv = n.GetBoolValue(); } },
                {"OrdreHoldShortTxt", n => { OrdreHoldShortTxt = n.GetStringValue(); } },
                {"OrdreHoldStatusID", n => { OrdreHoldStatusID = n.GetIntValue(); } },
                {"OrdreHoldTxt", n => { OrdreHoldTxt = n.GetStringValue(); } },
                {"Prioritet", n => { Prioritet = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("Aktiv", Aktiv);
            writer.WriteStringValue("OrdreHoldShortTxt", OrdreHoldShortTxt);
            writer.WriteIntValue("OrdreHoldStatusID", OrdreHoldStatusID);
            writer.WriteStringValue("OrdreHoldTxt", OrdreHoldTxt);
            writer.WriteIntValue("Prioritet", Prioritet);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
