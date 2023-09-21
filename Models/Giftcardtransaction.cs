using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Giftcardtransaction : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AltValutaHistoryID property</summary>
        public int? AltValutaHistoryID { get; set; }
        /// <summary>The AvsAdresseID property</summary>
        public int? AvsAdresseID { get; set; }
        /// <summary>The Belop property</summary>
        public double? Belop { get; set; }
        /// <summary>The BetalingMottattOK property</summary>
        public bool? BetalingMottattOK { get; set; }
        /// <summary>The ButikkID property</summary>
        public int? ButikkID { get; set; }
        /// <summary>The cts property</summary>
        public DateTimeOffset? Cts { get; set; }
        /// <summary>The EndretAvBrukerID property</summary>
        public int? EndretAvBrukerID { get; set; }
        /// <summary>The GavekortGuid property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GavekortGuid { get; set; }
#nullable restore
#else
        public string GavekortGuid { get; set; }
#endif
        /// <summary>The GavekortID property</summary>
        public int? GavekortID { get; set; }
        /// <summary>The GavekortTransID property</summary>
        public int? GavekortTransID { get; set; }
        /// <summary>The KansellertBelop property</summary>
        public double? KansellertBelop { get; set; }
        /// <summary>The KonsernValutaHistoryID property</summary>
        public int? KonsernValutaHistoryID { get; set; }
        /// <summary>The KundeID property</summary>
        public int? KundeID { get; set; }
        /// <summary>The Lading property</summary>
        public bool? Lading { get; set; }
        /// <summary>The OpprinneligBelop property</summary>
        public double? OpprinneligBelop { get; set; }
        /// <summary>The OrdreHodeID property</summary>
        public int? OrdreHodeID { get; set; }
        /// <summary>The OrdreNr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrdreNr { get; set; }
#nullable restore
#else
        public string OrdreNr { get; set; }
#endif
        /// <summary>The RapportValutaHistoryID property</summary>
        public int? RapportValutaHistoryID { get; set; }
        /// <summary>The Status property</summary>
        public int? Status { get; set; }
        /// <summary>The ts property</summary>
        public DateTimeOffset? Ts { get; set; }
        /// <summary>The ValutaBetegn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValutaBetegn { get; set; }
#nullable restore
#else
        public string ValutaBetegn { get; set; }
#endif
        /// <summary>The ValutaHistoryID property</summary>
        public int? ValutaHistoryID { get; set; }
        /// <summary>The ValutaID property</summary>
        public int? ValutaID { get; set; }
        /// <summary>The Web30BBSTransID property</summary>
        public int? Web30BBSTransID { get; set; }
        /// <summary>The Web30CartID property</summary>
        public int? Web30CartID { get; set; }
        /// <summary>The Web30DomeneMaskeID property</summary>
        public int? Web30DomeneMaskeID { get; set; }
        /// <summary>The WebDataID property</summary>
        public int? WebDataID { get; set; }
        /// <summary>
        /// Instantiates a new giftcardtransaction and sets the default values.
        /// </summary>
        public Giftcardtransaction() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Giftcardtransaction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Giftcardtransaction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AltValutaHistoryID", n => { AltValutaHistoryID = n.GetIntValue(); } },
                {"AvsAdresseID", n => { AvsAdresseID = n.GetIntValue(); } },
                {"Belop", n => { Belop = n.GetDoubleValue(); } },
                {"BetalingMottattOK", n => { BetalingMottattOK = n.GetBoolValue(); } },
                {"ButikkID", n => { ButikkID = n.GetIntValue(); } },
                {"cts", n => { Cts = n.GetDateTimeOffsetValue(); } },
                {"EndretAvBrukerID", n => { EndretAvBrukerID = n.GetIntValue(); } },
                {"GavekortGuid", n => { GavekortGuid = n.GetStringValue(); } },
                {"GavekortID", n => { GavekortID = n.GetIntValue(); } },
                {"GavekortTransID", n => { GavekortTransID = n.GetIntValue(); } },
                {"KansellertBelop", n => { KansellertBelop = n.GetDoubleValue(); } },
                {"KonsernValutaHistoryID", n => { KonsernValutaHistoryID = n.GetIntValue(); } },
                {"KundeID", n => { KundeID = n.GetIntValue(); } },
                {"Lading", n => { Lading = n.GetBoolValue(); } },
                {"OpprinneligBelop", n => { OpprinneligBelop = n.GetDoubleValue(); } },
                {"OrdreHodeID", n => { OrdreHodeID = n.GetIntValue(); } },
                {"OrdreNr", n => { OrdreNr = n.GetStringValue(); } },
                {"RapportValutaHistoryID", n => { RapportValutaHistoryID = n.GetIntValue(); } },
                {"Status", n => { Status = n.GetIntValue(); } },
                {"ts", n => { Ts = n.GetDateTimeOffsetValue(); } },
                {"ValutaBetegn", n => { ValutaBetegn = n.GetStringValue(); } },
                {"ValutaHistoryID", n => { ValutaHistoryID = n.GetIntValue(); } },
                {"ValutaID", n => { ValutaID = n.GetIntValue(); } },
                {"Web30BBSTransID", n => { Web30BBSTransID = n.GetIntValue(); } },
                {"Web30CartID", n => { Web30CartID = n.GetIntValue(); } },
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
            writer.WriteIntValue("AltValutaHistoryID", AltValutaHistoryID);
            writer.WriteIntValue("AvsAdresseID", AvsAdresseID);
            writer.WriteDoubleValue("Belop", Belop);
            writer.WriteBoolValue("BetalingMottattOK", BetalingMottattOK);
            writer.WriteIntValue("ButikkID", ButikkID);
            writer.WriteDateTimeOffsetValue("cts", Cts);
            writer.WriteIntValue("EndretAvBrukerID", EndretAvBrukerID);
            writer.WriteStringValue("GavekortGuid", GavekortGuid);
            writer.WriteIntValue("GavekortID", GavekortID);
            writer.WriteIntValue("GavekortTransID", GavekortTransID);
            writer.WriteDoubleValue("KansellertBelop", KansellertBelop);
            writer.WriteIntValue("KonsernValutaHistoryID", KonsernValutaHistoryID);
            writer.WriteIntValue("KundeID", KundeID);
            writer.WriteBoolValue("Lading", Lading);
            writer.WriteDoubleValue("OpprinneligBelop", OpprinneligBelop);
            writer.WriteIntValue("OrdreHodeID", OrdreHodeID);
            writer.WriteStringValue("OrdreNr", OrdreNr);
            writer.WriteIntValue("RapportValutaHistoryID", RapportValutaHistoryID);
            writer.WriteIntValue("Status", Status);
            writer.WriteDateTimeOffsetValue("ts", Ts);
            writer.WriteStringValue("ValutaBetegn", ValutaBetegn);
            writer.WriteIntValue("ValutaHistoryID", ValutaHistoryID);
            writer.WriteIntValue("ValutaID", ValutaID);
            writer.WriteIntValue("Web30BBSTransID", Web30BBSTransID);
            writer.WriteIntValue("Web30CartID", Web30CartID);
            writer.WriteIntValue("Web30DomeneMaskeID", Web30DomeneMaskeID);
            writer.WriteIntValue("WebDataID", WebDataID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
