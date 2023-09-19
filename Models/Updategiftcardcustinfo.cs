using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Updategiftcardcustinfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ePost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EPost { get; set; }
#nullable restore
#else
        public string EPost { get; set; }
#endif
        /// <summary>The GUID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GUID { get; set; }
#nullable restore
#else
        public string GUID { get; set; }
#endif
        /// <summary>The HilsenTxt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HilsenTxt { get; set; }
#nullable restore
#else
        public string HilsenTxt { get; set; }
#endif
        /// <summary>The Mobilnr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mobilnr { get; set; }
#nullable restore
#else
        public string Mobilnr { get; set; }
#endif
        /// <summary>The Overskrift property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Overskrift { get; set; }
#nullable restore
#else
        public string Overskrift { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Updategiftcardcustinfo and sets the default values.
        /// </summary>
        public Updategiftcardcustinfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Updategiftcardcustinfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Updategiftcardcustinfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ePost", n => { EPost = n.GetStringValue(); } },
                {"GUID", n => { GUID = n.GetStringValue(); } },
                {"HilsenTxt", n => { HilsenTxt = n.GetStringValue(); } },
                {"Mobilnr", n => { Mobilnr = n.GetStringValue(); } },
                {"Overskrift", n => { Overskrift = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ePost", EPost);
            writer.WriteStringValue("GUID", GUID);
            writer.WriteStringValue("HilsenTxt", HilsenTxt);
            writer.WriteStringValue("Mobilnr", Mobilnr);
            writer.WriteStringValue("Overskrift", Overskrift);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
