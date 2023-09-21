using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Giftcardavsenderinfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AvsAdresseId property</summary>
        public int? AvsAdresseId { get; set; }
        /// <summary>The B_Adr1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BAdr1 { get; set; }
#nullable restore
#else
        public string BAdr1 { get; set; }
#endif
        /// <summary>The B_Adr2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BAdr2 { get; set; }
#nullable restore
#else
        public string BAdr2 { get; set; }
#endif
        /// <summary>The B_Adr3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BAdr3 { get; set; }
#nullable restore
#else
        public string BAdr3 { get; set; }
#endif
        /// <summary>The B_Land property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BLand { get; set; }
#nullable restore
#else
        public string BLand { get; set; }
#endif
        /// <summary>The B_PostNr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BPostNr { get; set; }
#nullable restore
#else
        public string BPostNr { get; set; }
#endif
        /// <summary>The B_Poststed property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BPoststed { get; set; }
#nullable restore
#else
        public string BPoststed { get; set; }
#endif
        /// <summary>The DisplayNavn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayNavn { get; set; }
#nullable restore
#else
        public string DisplayNavn { get; set; }
#endif
        /// <summary>The EMail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EMail { get; set; }
#nullable restore
#else
        public string EMail { get; set; }
#endif
        /// <summary>The Foretaknr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Foretaknr { get; set; }
#nullable restore
#else
        public string Foretaknr { get; set; }
#endif
        /// <summary>The HovedTlf1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HovedTlf1 { get; set; }
#nullable restore
#else
        public string HovedTlf1 { get; set; }
#endif
        /// <summary>The MCGavekortGyldigAntallMnd property</summary>
        public int? MCGavekortGyldigAntallMnd { get; set; }
        /// <summary>The MCGavekortMaksBelop property</summary>
        public double? MCGavekortMaksBelop { get; set; }
        /// <summary>
        /// Instantiates a new Giftcardavsenderinfo and sets the default values.
        /// </summary>
        public Giftcardavsenderinfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Giftcardavsenderinfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Giftcardavsenderinfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AvsAdresseId", n => { AvsAdresseId = n.GetIntValue(); } },
                {"B_Adr1", n => { BAdr1 = n.GetStringValue(); } },
                {"B_Adr2", n => { BAdr2 = n.GetStringValue(); } },
                {"B_Adr3", n => { BAdr3 = n.GetStringValue(); } },
                {"B_Land", n => { BLand = n.GetStringValue(); } },
                {"B_PostNr", n => { BPostNr = n.GetStringValue(); } },
                {"B_Poststed", n => { BPoststed = n.GetStringValue(); } },
                {"DisplayNavn", n => { DisplayNavn = n.GetStringValue(); } },
                {"EMail", n => { EMail = n.GetStringValue(); } },
                {"Foretaknr", n => { Foretaknr = n.GetStringValue(); } },
                {"HovedTlf1", n => { HovedTlf1 = n.GetStringValue(); } },
                {"MCGavekortGyldigAntallMnd", n => { MCGavekortGyldigAntallMnd = n.GetIntValue(); } },
                {"MCGavekortMaksBelop", n => { MCGavekortMaksBelop = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("AvsAdresseId", AvsAdresseId);
            writer.WriteStringValue("B_Adr1", BAdr1);
            writer.WriteStringValue("B_Adr2", BAdr2);
            writer.WriteStringValue("B_Adr3", BAdr3);
            writer.WriteStringValue("B_Land", BLand);
            writer.WriteStringValue("B_PostNr", BPostNr);
            writer.WriteStringValue("B_Poststed", BPoststed);
            writer.WriteStringValue("DisplayNavn", DisplayNavn);
            writer.WriteStringValue("EMail", EMail);
            writer.WriteStringValue("Foretaknr", Foretaknr);
            writer.WriteStringValue("HovedTlf1", HovedTlf1);
            writer.WriteIntValue("MCGavekortGyldigAntallMnd", MCGavekortGyldigAntallMnd);
            writer.WriteDoubleValue("MCGavekortMaksBelop", MCGavekortMaksBelop);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
