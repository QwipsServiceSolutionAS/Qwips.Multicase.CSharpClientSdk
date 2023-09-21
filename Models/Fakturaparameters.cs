using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Fakturaparameters : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Fakturanr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fakturanr { get; set; }
#nullable restore
#else
        public string Fakturanr { get; set; }
#endif
        /// <summary>The FakturanrFra property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FakturanrFra { get; set; }
#nullable restore
#else
        public string FakturanrFra { get; set; }
#endif
        /// <summary>The FakturanrTil property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FakturanrTil { get; set; }
#nullable restore
#else
        public string FakturanrTil { get; set; }
#endif
        /// <summary>
        /// Instantiates a new fakturaparameters and sets the default values.
        /// </summary>
        public Fakturaparameters() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Fakturaparameters CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Fakturaparameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Fakturanr", n => { Fakturanr = n.GetStringValue(); } },
                {"FakturanrFra", n => { FakturanrFra = n.GetStringValue(); } },
                {"FakturanrTil", n => { FakturanrTil = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Fakturanr", Fakturanr);
            writer.WriteStringValue("FakturanrFra", FakturanrFra);
            writer.WriteStringValue("FakturanrTil", FakturanrTil);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
