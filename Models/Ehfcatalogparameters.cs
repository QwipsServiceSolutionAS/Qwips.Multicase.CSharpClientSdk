using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Ehfcatalogparameters : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The FraDato property</summary>
        public DateTimeOffset? FraDato { get; set; }
        /// <summary>The KontraktKundeNr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KontraktKundeNr { get; set; }
#nullable restore
#else
        public string KontraktKundeNr { get; set; }
#endif
        /// <summary>The Kontraktsnummer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Kontraktsnummer { get; set; }
#nullable restore
#else
        public string Kontraktsnummer { get; set; }
#endif
        /// <summary>The TomDato property</summary>
        public DateTimeOffset? TomDato { get; set; }
        /// <summary>
        /// Instantiates a new ehfcatalogparameters and sets the default values.
        /// </summary>
        public Ehfcatalogparameters() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Ehfcatalogparameters CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Ehfcatalogparameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"FraDato", n => { FraDato = n.GetDateTimeOffsetValue(); } },
                {"KontraktKundeNr", n => { KontraktKundeNr = n.GetStringValue(); } },
                {"Kontraktsnummer", n => { Kontraktsnummer = n.GetStringValue(); } },
                {"TomDato", n => { TomDato = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("FraDato", FraDato);
            writer.WriteStringValue("KontraktKundeNr", KontraktKundeNr);
            writer.WriteStringValue("Kontraktsnummer", Kontraktsnummer);
            writer.WriteDateTimeOffsetValue("TomDato", TomDato);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
