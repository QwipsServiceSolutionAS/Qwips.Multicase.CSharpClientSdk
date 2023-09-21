using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Valutatabell : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Aktiv property</summary>
        public bool? Aktiv { get; set; }
        /// <summary>The BrukesSalg property</summary>
        public bool? BrukesSalg { get; set; }
        /// <summary>The CultureName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CultureName { get; set; }
#nullable restore
#else
        public string CultureName { get; set; }
#endif
        /// <summary>The Enhet property</summary>
        public int? Enhet { get; set; }
        /// <summary>The ISO6391Kode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ISO6391Kode { get; set; }
#nullable restore
#else
        public string ISO6391Kode { get; set; }
#endif
        /// <summary>The Kurs property</summary>
        public double? Kurs { get; set; }
        /// <summary>The KursDato property</summary>
        public DateTimeOffset? KursDato { get; set; }
        /// <summary>The Myntsort property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Myntsort { get; set; }
#nullable restore
#else
        public string Myntsort { get; set; }
#endif
        /// <summary>The NextKode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NextKode { get; set; }
#nullable restore
#else
        public string NextKode { get; set; }
#endif
        /// <summary>The SpraakID property</summary>
        public int? SpraakID { get; set; }
        /// <summary>The SpraakTxt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SpraakTxt { get; set; }
#nullable restore
#else
        public string SpraakTxt { get; set; }
#endif
        /// <summary>The Symbol property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Symbol { get; set; }
#nullable restore
#else
        public string Symbol { get; set; }
#endif
        /// <summary>The TallKode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TallKode { get; set; }
#nullable restore
#else
        public string TallKode { get; set; }
#endif
        /// <summary>The TallKode1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TallKode1 { get; set; }
#nullable restore
#else
        public string TallKode1 { get; set; }
#endif
        /// <summary>The TallKode2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TallKode2 { get; set; }
#nullable restore
#else
        public string TallKode2 { get; set; }
#endif
        /// <summary>The TallKode3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TallKode3 { get; set; }
#nullable restore
#else
        public string TallKode3 { get; set; }
#endif
        /// <summary>The ValutaBetegn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValutaBetegn { get; set; }
#nullable restore
#else
        public string ValutaBetegn { get; set; }
#endif
        /// <summary>The ValutaID property</summary>
        public int? ValutaID { get; set; }
        /// <summary>The ValutaTabellID property</summary>
        public int? ValutaTabellID { get; set; }
        /// <summary>
        /// Instantiates a new Valutatabell and sets the default values.
        /// </summary>
        public Valutatabell() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Valutatabell CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Valutatabell();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Aktiv", n => { Aktiv = n.GetBoolValue(); } },
                {"BrukesSalg", n => { BrukesSalg = n.GetBoolValue(); } },
                {"CultureName", n => { CultureName = n.GetStringValue(); } },
                {"Enhet", n => { Enhet = n.GetIntValue(); } },
                {"ISO6391Kode", n => { ISO6391Kode = n.GetStringValue(); } },
                {"Kurs", n => { Kurs = n.GetDoubleValue(); } },
                {"KursDato", n => { KursDato = n.GetDateTimeOffsetValue(); } },
                {"Myntsort", n => { Myntsort = n.GetStringValue(); } },
                {"NextKode", n => { NextKode = n.GetStringValue(); } },
                {"SpraakID", n => { SpraakID = n.GetIntValue(); } },
                {"SpraakTxt", n => { SpraakTxt = n.GetStringValue(); } },
                {"Symbol", n => { Symbol = n.GetStringValue(); } },
                {"TallKode", n => { TallKode = n.GetStringValue(); } },
                {"TallKode1", n => { TallKode1 = n.GetStringValue(); } },
                {"TallKode2", n => { TallKode2 = n.GetStringValue(); } },
                {"TallKode3", n => { TallKode3 = n.GetStringValue(); } },
                {"ValutaBetegn", n => { ValutaBetegn = n.GetStringValue(); } },
                {"ValutaID", n => { ValutaID = n.GetIntValue(); } },
                {"ValutaTabellID", n => { ValutaTabellID = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("Aktiv", Aktiv);
            writer.WriteBoolValue("BrukesSalg", BrukesSalg);
            writer.WriteStringValue("CultureName", CultureName);
            writer.WriteIntValue("Enhet", Enhet);
            writer.WriteStringValue("ISO6391Kode", ISO6391Kode);
            writer.WriteDoubleValue("Kurs", Kurs);
            writer.WriteDateTimeOffsetValue("KursDato", KursDato);
            writer.WriteStringValue("Myntsort", Myntsort);
            writer.WriteStringValue("NextKode", NextKode);
            writer.WriteIntValue("SpraakID", SpraakID);
            writer.WriteStringValue("SpraakTxt", SpraakTxt);
            writer.WriteStringValue("Symbol", Symbol);
            writer.WriteStringValue("TallKode", TallKode);
            writer.WriteStringValue("TallKode1", TallKode1);
            writer.WriteStringValue("TallKode2", TallKode2);
            writer.WriteStringValue("TallKode3", TallKode3);
            writer.WriteStringValue("ValutaBetegn", ValutaBetegn);
            writer.WriteIntValue("ValutaID", ValutaID);
            writer.WriteIntValue("ValutaTabellID", ValutaTabellID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
