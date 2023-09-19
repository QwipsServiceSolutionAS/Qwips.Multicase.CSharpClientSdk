using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Creategiftcard : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Aktiv property</summary>
        public bool? Aktiv { get; set; }
        /// <summary>The AvsAdresseID property</summary>
        public int? AvsAdresseID { get; set; }
        /// <summary>The BakgrunnsBildeID property</summary>
        public int? BakgrunnsBildeID { get; set; }
        /// <summary>The ButikkID property</summary>
        public int? ButikkID { get; set; }
        /// <summary>The EksklusivKundeID property</summary>
        public int? EksklusivKundeID { get; set; }
        /// <summary>The ePost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EPost { get; set; }
#nullable restore
#else
        public string EPost { get; set; }
#endif
        /// <summary>The GyldigTom property</summary>
        public DateTimeOffset? GyldigTom { get; set; }
        /// <summary>The HilsenTxt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HilsenTxt { get; set; }
#nullable restore
#else
        public string HilsenTxt { get; set; }
#endif
        /// <summary>The KundeID property</summary>
        public int? KundeID { get; set; }
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
        /// <summary>The SendGavekort property</summary>
        public bool? SendGavekort { get; set; }
        /// <summary>The SolgtAvBrukerID property</summary>
        public int? SolgtAvBrukerID { get; set; }
        /// <summary>The StartBelop property</summary>
        public double? StartBelop { get; set; }
        /// <summary>The ValutaHistoryID property</summary>
        public int? ValutaHistoryID { get; set; }
        /// <summary>The ValutaID property</summary>
        public int? ValutaID { get; set; }
        /// <summary>The Web30DomeneMaskeID property</summary>
        public int? Web30DomeneMaskeID { get; set; }
        /// <summary>The WebDataID property</summary>
        public int? WebDataID { get; set; }
        /// <summary>
        /// Instantiates a new Creategiftcard and sets the default values.
        /// </summary>
        public Creategiftcard() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Creategiftcard CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Creategiftcard();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Aktiv", n => { Aktiv = n.GetBoolValue(); } },
                {"AvsAdresseID", n => { AvsAdresseID = n.GetIntValue(); } },
                {"BakgrunnsBildeID", n => { BakgrunnsBildeID = n.GetIntValue(); } },
                {"ButikkID", n => { ButikkID = n.GetIntValue(); } },
                {"EksklusivKundeID", n => { EksklusivKundeID = n.GetIntValue(); } },
                {"ePost", n => { EPost = n.GetStringValue(); } },
                {"GyldigTom", n => { GyldigTom = n.GetDateTimeOffsetValue(); } },
                {"HilsenTxt", n => { HilsenTxt = n.GetStringValue(); } },
                {"KundeID", n => { KundeID = n.GetIntValue(); } },
                {"Mobilnr", n => { Mobilnr = n.GetStringValue(); } },
                {"Overskrift", n => { Overskrift = n.GetStringValue(); } },
                {"SendGavekort", n => { SendGavekort = n.GetBoolValue(); } },
                {"SolgtAvBrukerID", n => { SolgtAvBrukerID = n.GetIntValue(); } },
                {"StartBelop", n => { StartBelop = n.GetDoubleValue(); } },
                {"ValutaHistoryID", n => { ValutaHistoryID = n.GetIntValue(); } },
                {"ValutaID", n => { ValutaID = n.GetIntValue(); } },
                {"Web30DomeneMaskeID", n => { Web30DomeneMaskeID = n.GetIntValue(); } },
                {"WebDataID", n => { WebDataID = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("Aktiv", Aktiv);
            writer.WriteIntValue("AvsAdresseID", AvsAdresseID);
            writer.WriteIntValue("BakgrunnsBildeID", BakgrunnsBildeID);
            writer.WriteIntValue("ButikkID", ButikkID);
            writer.WriteIntValue("EksklusivKundeID", EksklusivKundeID);
            writer.WriteStringValue("ePost", EPost);
            writer.WriteDateTimeOffsetValue("GyldigTom", GyldigTom);
            writer.WriteStringValue("HilsenTxt", HilsenTxt);
            writer.WriteIntValue("KundeID", KundeID);
            writer.WriteStringValue("Mobilnr", Mobilnr);
            writer.WriteStringValue("Overskrift", Overskrift);
            writer.WriteBoolValue("SendGavekort", SendGavekort);
            writer.WriteIntValue("SolgtAvBrukerID", SolgtAvBrukerID);
            writer.WriteDoubleValue("StartBelop", StartBelop);
            writer.WriteIntValue("ValutaHistoryID", ValutaHistoryID);
            writer.WriteIntValue("ValutaID", ValutaID);
            writer.WriteIntValue("Web30DomeneMaskeID", Web30DomeneMaskeID);
            writer.WriteIntValue("WebDataID", WebDataID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
