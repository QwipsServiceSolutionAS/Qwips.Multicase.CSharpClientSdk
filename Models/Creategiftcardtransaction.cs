using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Creategiftcardtransaction : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AvsAdresseID property</summary>
        public int? AvsAdresseID { get; set; }
        /// <summary>The Belop property</summary>
        public double? Belop { get; set; }
        /// <summary>The ButikkID property</summary>
        public int? ButikkID { get; set; }
        /// <summary>The EndretAvBrukerID property</summary>
        public int? EndretAvBrukerID { get; set; }
        /// <summary>The GavekortID property</summary>
        public int? GavekortID { get; set; }
        /// <summary>The KundeID property</summary>
        public int? KundeID { get; set; }
        /// <summary>The Lading property</summary>
        public bool? Lading { get; set; }
        /// <summary>The OrdreHodeID property</summary>
        public int? OrdreHodeID { get; set; }
        /// <summary>The Status property</summary>
        public int? Status { get; set; }
        /// <summary>The ValutaHistoryID property</summary>
        public int? ValutaHistoryID { get; set; }
        /// <summary>The ValutaID property</summary>
        public int? ValutaID { get; set; }
        /// <summary>The Web30CartID property</summary>
        public int? Web30CartID { get; set; }
        /// <summary>The Web30DomeneMaskeID property</summary>
        public int? Web30DomeneMaskeID { get; set; }
        /// <summary>The WebDataID property</summary>
        public int? WebDataID { get; set; }
        /// <summary>
        /// Instantiates a new Creategiftcardtransaction and sets the default values.
        /// </summary>
        public Creategiftcardtransaction() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Creategiftcardtransaction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Creategiftcardtransaction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AvsAdresseID", n => { AvsAdresseID = n.GetIntValue(); } },
                {"Belop", n => { Belop = n.GetDoubleValue(); } },
                {"ButikkID", n => { ButikkID = n.GetIntValue(); } },
                {"EndretAvBrukerID", n => { EndretAvBrukerID = n.GetIntValue(); } },
                {"GavekortID", n => { GavekortID = n.GetIntValue(); } },
                {"KundeID", n => { KundeID = n.GetIntValue(); } },
                {"Lading", n => { Lading = n.GetBoolValue(); } },
                {"OrdreHodeID", n => { OrdreHodeID = n.GetIntValue(); } },
                {"Status", n => { Status = n.GetIntValue(); } },
                {"ValutaHistoryID", n => { ValutaHistoryID = n.GetIntValue(); } },
                {"ValutaID", n => { ValutaID = n.GetIntValue(); } },
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
            writer.WriteIntValue("AvsAdresseID", AvsAdresseID);
            writer.WriteDoubleValue("Belop", Belop);
            writer.WriteIntValue("ButikkID", ButikkID);
            writer.WriteIntValue("EndretAvBrukerID", EndretAvBrukerID);
            writer.WriteIntValue("GavekortID", GavekortID);
            writer.WriteIntValue("KundeID", KundeID);
            writer.WriteBoolValue("Lading", Lading);
            writer.WriteIntValue("OrdreHodeID", OrdreHodeID);
            writer.WriteIntValue("Status", Status);
            writer.WriteIntValue("ValutaHistoryID", ValutaHistoryID);
            writer.WriteIntValue("ValutaID", ValutaID);
            writer.WriteIntValue("Web30CartID", Web30CartID);
            writer.WriteIntValue("Web30DomeneMaskeID", Web30DomeneMaskeID);
            writer.WriteIntValue("WebDataID", WebDataID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
