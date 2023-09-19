using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Giftcardtransactiondetail : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Amount property</summary>
        public double? Amount { get; set; }
        /// <summary>The AmountProcessed property</summary>
        public double? AmountProcessed { get; set; }
        /// <summary>The BilagsNr property</summary>
        public int? BilagsNr { get; set; }
        /// <summary>The cts property</summary>
        public DateTimeOffset? Cts { get; set; }
        /// <summary>The ExportDate property</summary>
        public DateTimeOffset? ExportDate { get; set; }
        /// <summary>The FakturaHodeID property</summary>
        public int? FakturaHodeID { get; set; }
        /// <summary>The GavekortTransDetaljID property</summary>
        public int? GavekortTransDetaljID { get; set; }
        /// <summary>The GavekortTransID property</summary>
        public int? GavekortTransID { get; set; }
        /// <summary>The KontoID property</summary>
        public int? KontoID { get; set; }
        /// <summary>The KreditHodeID property</summary>
        public int? KreditHodeID { get; set; }
        /// <summary>The TilExport property</summary>
        public bool? TilExport { get; set; }
        /// <summary>The ts property</summary>
        public DateTimeOffset? Ts { get; set; }
        /// <summary>
        /// Instantiates a new giftcardtransactiondetail and sets the default values.
        /// </summary>
        public Giftcardtransactiondetail() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Giftcardtransactiondetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Giftcardtransactiondetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Amount", n => { Amount = n.GetDoubleValue(); } },
                {"AmountProcessed", n => { AmountProcessed = n.GetDoubleValue(); } },
                {"BilagsNr", n => { BilagsNr = n.GetIntValue(); } },
                {"cts", n => { Cts = n.GetDateTimeOffsetValue(); } },
                {"ExportDate", n => { ExportDate = n.GetDateTimeOffsetValue(); } },
                {"FakturaHodeID", n => { FakturaHodeID = n.GetIntValue(); } },
                {"GavekortTransDetaljID", n => { GavekortTransDetaljID = n.GetIntValue(); } },
                {"GavekortTransID", n => { GavekortTransID = n.GetIntValue(); } },
                {"KontoID", n => { KontoID = n.GetIntValue(); } },
                {"KreditHodeID", n => { KreditHodeID = n.GetIntValue(); } },
                {"TilExport", n => { TilExport = n.GetBoolValue(); } },
                {"ts", n => { Ts = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("Amount", Amount);
            writer.WriteDoubleValue("AmountProcessed", AmountProcessed);
            writer.WriteIntValue("BilagsNr", BilagsNr);
            writer.WriteDateTimeOffsetValue("cts", Cts);
            writer.WriteDateTimeOffsetValue("ExportDate", ExportDate);
            writer.WriteIntValue("FakturaHodeID", FakturaHodeID);
            writer.WriteIntValue("GavekortTransDetaljID", GavekortTransDetaljID);
            writer.WriteIntValue("GavekortTransID", GavekortTransID);
            writer.WriteIntValue("KontoID", KontoID);
            writer.WriteIntValue("KreditHodeID", KreditHodeID);
            writer.WriteBoolValue("TilExport", TilExport);
            writer.WriteDateTimeOffsetValue("ts", Ts);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
