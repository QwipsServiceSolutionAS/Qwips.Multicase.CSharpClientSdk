using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Freight : IAdditionalDataHolder, IParsable {
        /// <summary>The Active property</summary>
        public bool? Active { get; set; }
        /// <summary>The ActiveWeb property</summary>
        public bool? ActiveWeb { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AktivInnkjop property</summary>
        public bool? AktivInnkjop { get; set; }
        /// <summary>The AutoUtmelding property</summary>
        public int? AutoUtmelding { get; set; }
        /// <summary>The AvgFrittKontoID property</summary>
        public int? AvgFrittKontoID { get; set; }
        /// <summary>The AvgiftID property</summary>
        public int? AvgiftID { get; set; }
        /// <summary>The BelastMottaker property</summary>
        public bool? BelastMottaker { get; set; }
        /// <summary>The BrukWinEDI property</summary>
        public bool? BrukWinEDI { get; set; }
        /// <summary>The Country property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Country? Country { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Country Country { get; set; }
#endif
        /// <summary>The DefaultButikkFrakt property</summary>
        public bool? DefaultButikkFrakt { get; set; }
        /// <summary>The DefaultProduktVekt property</summary>
        public double? DefaultProduktVekt { get; set; }
        /// <summary>The DuplikatPakkSeddel property</summary>
        public int? DuplikatPakkSeddel { get; set; }
        /// <summary>The EUAvgFrittKontoID property</summary>
        public int? EUAvgFrittKontoID { get; set; }
        /// <summary>The EUAvgPliktKontoID property</summary>
        public int? EUAvgPliktKontoID { get; set; }
        /// <summary>The ExternalFreightText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalFreightText { get; set; }
#nullable restore
#else
        public string ExternalFreightText { get; set; }
#endif
        /// <summary>The ForsikringEDI property</summary>
        public bool? ForsikringEDI { get; set; }
        /// <summary>The FraktformularID property</summary>
        public int? FraktformularID { get; set; }
        /// <summary>The FraktKostnad property</summary>
        public int? FraktKostnad { get; set; }
        /// <summary>The FraktTxt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FraktTxt { get; set; }
#nullable restore
#else
        public string FraktTxt { get; set; }
#endif
        /// <summary>The FreightID property</summary>
        public int? FreightID { get; set; }
        /// <summary>The KolliformularID property</summary>
        public int? KolliformularID { get; set; }
        /// <summary>The KontoID property</summary>
        public int? KontoID { get; set; }
        /// <summary>The MaxWeight property</summary>
        public double? MaxWeight { get; set; }
        /// <summary>The MaalesMot property</summary>
        public int? MaalesMot { get; set; }
        /// <summary>The OmregnFaktor property</summary>
        public double? OmregnFaktor { get; set; }
        /// <summary>The OppkravPrKolli property</summary>
        public bool? OppkravPrKolli { get; set; }
        /// <summary>The PakkeRefDefault property</summary>
        public bool? PakkeRefDefault { get; set; }
        /// <summary>The PakkeRefShow property</summary>
        public bool? PakkeRefShow { get; set; }
        /// <summary>The PlukkBekreftelse property</summary>
        public bool? PlukkBekreftelse { get; set; }
        /// <summary>The PlukkBekreftelseSMS property</summary>
        public bool? PlukkBekreftelseSMS { get; set; }
        /// <summary>The Price property</summary>
        public double? Price { get; set; }
        /// <summary>The Priority property</summary>
        public int? Priority { get; set; }
        /// <summary>The PrisFaktor property</summary>
        public double? PrisFaktor { get; set; }
        /// <summary>The ProduktCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProduktCode { get; set; }
#nullable restore
#else
        public string ProduktCode { get; set; }
#endif
        /// <summary>The ProduktPrioritet property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProduktPrioritet { get; set; }
#nullable restore
#else
        public string ProduktPrioritet { get; set; }
#endif
        /// <summary>The RabattPst property</summary>
        public double? RabattPst { get; set; }
        /// <summary>The SamletEDI property</summary>
        public bool? SamletEDI { get; set; }
        /// <summary>The SendesEDI property</summary>
        public bool? SendesEDI { get; set; }
        /// <summary>The Shortname property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Shortname { get; set; }
#nullable restore
#else
        public string Shortname { get; set; }
#endif
        /// <summary>The TillegOppkrav property</summary>
        public double? TillegOppkrav { get; set; }
        /// <summary>The TransportorFraktNr property</summary>
        public int? TransportorFraktNr { get; set; }
        /// <summary>The TransportorID property</summary>
        public int? TransportorID { get; set; }
        /// <summary>The TransportorKonseptNr property</summary>
        public int? TransportorKonseptNr { get; set; }
        /// <summary>The UseParcelNumber property</summary>
        public bool? UseParcelNumber { get; set; }
        /// <summary>
        /// Instantiates a new freight and sets the default values.
        /// </summary>
        public Freight() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Freight CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Freight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Active", n => { Active = n.GetBoolValue(); } },
                {"ActiveWeb", n => { ActiveWeb = n.GetBoolValue(); } },
                {"AktivInnkjop", n => { AktivInnkjop = n.GetBoolValue(); } },
                {"AutoUtmelding", n => { AutoUtmelding = n.GetIntValue(); } },
                {"AvgFrittKontoID", n => { AvgFrittKontoID = n.GetIntValue(); } },
                {"AvgiftID", n => { AvgiftID = n.GetIntValue(); } },
                {"BelastMottaker", n => { BelastMottaker = n.GetBoolValue(); } },
                {"BrukWinEDI", n => { BrukWinEDI = n.GetBoolValue(); } },
                {"Country", n => { Country = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Country>(Qwips.Core.ClientSdk.Multicase.Models.Country.CreateFromDiscriminatorValue); } },
                {"DefaultButikkFrakt", n => { DefaultButikkFrakt = n.GetBoolValue(); } },
                {"DefaultProduktVekt", n => { DefaultProduktVekt = n.GetDoubleValue(); } },
                {"DuplikatPakkSeddel", n => { DuplikatPakkSeddel = n.GetIntValue(); } },
                {"EUAvgFrittKontoID", n => { EUAvgFrittKontoID = n.GetIntValue(); } },
                {"EUAvgPliktKontoID", n => { EUAvgPliktKontoID = n.GetIntValue(); } },
                {"ExternalFreightText", n => { ExternalFreightText = n.GetStringValue(); } },
                {"ForsikringEDI", n => { ForsikringEDI = n.GetBoolValue(); } },
                {"FraktformularID", n => { FraktformularID = n.GetIntValue(); } },
                {"FraktKostnad", n => { FraktKostnad = n.GetIntValue(); } },
                {"FraktTxt", n => { FraktTxt = n.GetStringValue(); } },
                {"FreightID", n => { FreightID = n.GetIntValue(); } },
                {"KolliformularID", n => { KolliformularID = n.GetIntValue(); } },
                {"KontoID", n => { KontoID = n.GetIntValue(); } },
                {"MaxWeight", n => { MaxWeight = n.GetDoubleValue(); } },
                {"MaalesMot", n => { MaalesMot = n.GetIntValue(); } },
                {"OmregnFaktor", n => { OmregnFaktor = n.GetDoubleValue(); } },
                {"OppkravPrKolli", n => { OppkravPrKolli = n.GetBoolValue(); } },
                {"PakkeRefDefault", n => { PakkeRefDefault = n.GetBoolValue(); } },
                {"PakkeRefShow", n => { PakkeRefShow = n.GetBoolValue(); } },
                {"PlukkBekreftelse", n => { PlukkBekreftelse = n.GetBoolValue(); } },
                {"PlukkBekreftelseSMS", n => { PlukkBekreftelseSMS = n.GetBoolValue(); } },
                {"Price", n => { Price = n.GetDoubleValue(); } },
                {"Priority", n => { Priority = n.GetIntValue(); } },
                {"PrisFaktor", n => { PrisFaktor = n.GetDoubleValue(); } },
                {"ProduktCode", n => { ProduktCode = n.GetStringValue(); } },
                {"ProduktPrioritet", n => { ProduktPrioritet = n.GetStringValue(); } },
                {"RabattPst", n => { RabattPst = n.GetDoubleValue(); } },
                {"SamletEDI", n => { SamletEDI = n.GetBoolValue(); } },
                {"SendesEDI", n => { SendesEDI = n.GetBoolValue(); } },
                {"Shortname", n => { Shortname = n.GetStringValue(); } },
                {"TillegOppkrav", n => { TillegOppkrav = n.GetDoubleValue(); } },
                {"TransportorFraktNr", n => { TransportorFraktNr = n.GetIntValue(); } },
                {"TransportorID", n => { TransportorID = n.GetIntValue(); } },
                {"TransportorKonseptNr", n => { TransportorKonseptNr = n.GetIntValue(); } },
                {"UseParcelNumber", n => { UseParcelNumber = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("Active", Active);
            writer.WriteBoolValue("ActiveWeb", ActiveWeb);
            writer.WriteBoolValue("AktivInnkjop", AktivInnkjop);
            writer.WriteIntValue("AutoUtmelding", AutoUtmelding);
            writer.WriteIntValue("AvgFrittKontoID", AvgFrittKontoID);
            writer.WriteIntValue("AvgiftID", AvgiftID);
            writer.WriteBoolValue("BelastMottaker", BelastMottaker);
            writer.WriteBoolValue("BrukWinEDI", BrukWinEDI);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Country>("Country", Country);
            writer.WriteBoolValue("DefaultButikkFrakt", DefaultButikkFrakt);
            writer.WriteDoubleValue("DefaultProduktVekt", DefaultProduktVekt);
            writer.WriteIntValue("DuplikatPakkSeddel", DuplikatPakkSeddel);
            writer.WriteIntValue("EUAvgFrittKontoID", EUAvgFrittKontoID);
            writer.WriteIntValue("EUAvgPliktKontoID", EUAvgPliktKontoID);
            writer.WriteStringValue("ExternalFreightText", ExternalFreightText);
            writer.WriteBoolValue("ForsikringEDI", ForsikringEDI);
            writer.WriteIntValue("FraktformularID", FraktformularID);
            writer.WriteIntValue("FraktKostnad", FraktKostnad);
            writer.WriteStringValue("FraktTxt", FraktTxt);
            writer.WriteIntValue("FreightID", FreightID);
            writer.WriteIntValue("KolliformularID", KolliformularID);
            writer.WriteIntValue("KontoID", KontoID);
            writer.WriteDoubleValue("MaxWeight", MaxWeight);
            writer.WriteIntValue("MaalesMot", MaalesMot);
            writer.WriteDoubleValue("OmregnFaktor", OmregnFaktor);
            writer.WriteBoolValue("OppkravPrKolli", OppkravPrKolli);
            writer.WriteBoolValue("PakkeRefDefault", PakkeRefDefault);
            writer.WriteBoolValue("PakkeRefShow", PakkeRefShow);
            writer.WriteBoolValue("PlukkBekreftelse", PlukkBekreftelse);
            writer.WriteBoolValue("PlukkBekreftelseSMS", PlukkBekreftelseSMS);
            writer.WriteDoubleValue("Price", Price);
            writer.WriteIntValue("Priority", Priority);
            writer.WriteDoubleValue("PrisFaktor", PrisFaktor);
            writer.WriteStringValue("ProduktCode", ProduktCode);
            writer.WriteStringValue("ProduktPrioritet", ProduktPrioritet);
            writer.WriteDoubleValue("RabattPst", RabattPst);
            writer.WriteBoolValue("SamletEDI", SamletEDI);
            writer.WriteBoolValue("SendesEDI", SendesEDI);
            writer.WriteStringValue("Shortname", Shortname);
            writer.WriteDoubleValue("TillegOppkrav", TillegOppkrav);
            writer.WriteIntValue("TransportorFraktNr", TransportorFraktNr);
            writer.WriteIntValue("TransportorID", TransportorID);
            writer.WriteIntValue("TransportorKonseptNr", TransportorKonseptNr);
            writer.WriteBoolValue("UseParcelNumber", UseParcelNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
