using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Senderdetails : IAdditionalDataHolder, IParsable {
        /// <summary>The Abonnement property</summary>
        public bool? Abonnement { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AIKolli property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AIKolli { get; set; }
#nullable restore
#else
        public string AIKolli { get; set; }
#endif
        /// <summary>The AISending property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AISending { get; set; }
#nullable restore
#else
        public string AISending { get; set; }
#endif
        /// <summary>The Aktiv property</summary>
        public bool? Aktiv { get; set; }
        /// <summary>The AktivForRabatterPaaTversAvAvsender property</summary>
        public bool? AktivForRabatterPaaTversAvAvsender { get; set; }
        /// <summary>The AktivOLAP property</summary>
        public bool? AktivOLAP { get; set; }
        /// <summary>The AlternProduktNrVisningsNavn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlternProduktNrVisningsNavn { get; set; }
#nullable restore
#else
        public string AlternProduktNrVisningsNavn { get; set; }
#endif
        /// <summary>The AlterTid property</summary>
        public bool? AlterTid { get; set; }
        /// <summary>The AntDagIkkeGodkj property</summary>
        public int? AntDagIkkeGodkj { get; set; }
        /// <summary>The AntDagIkkeOverf property</summary>
        public int? AntDagIkkeOverf { get; set; }
        /// <summary>The AntDagInnkjAnk property</summary>
        public int? AntDagInnkjAnk { get; set; }
        /// <summary>The AntDagInnkjLev property</summary>
        public int? AntDagInnkjLev { get; set; }
        /// <summary>The AntDagOppfTilbud property</summary>
        public int? AntDagOppfTilbud { get; set; }
        /// <summary>The AntDagUtgFraktAvt property</summary>
        public int? AntDagUtgFraktAvt { get; set; }
        /// <summary>The AntDagUtgRabattAvt property</summary>
        public int? AntDagUtgRabattAvt { get; set; }
        /// <summary>The AntVarsel property</summary>
        public int? AntVarsel { get; set; }
        /// <summary>The AutoKredSjekk property</summary>
        public bool? AutoKredSjekk { get; set; }
        /// <summary>The AutoSkrivUtRetur property</summary>
        public bool? AutoSkrivUtRetur { get; set; }
        /// <summary>The AvansertBid property</summary>
        public bool? AvansertBid { get; set; }
        /// <summary>The AvdRegnskap property</summary>
        public int? AvdRegnskap { get; set; }
        /// <summary>The AvgFrittRabattKontoId property</summary>
        public int? AvgFrittRabattKontoId { get; set; }
        /// <summary>The AvgiftModellFlag property</summary>
        public bool? AvgiftModellFlag { get; set; }
        /// <summary>The AvgPliktRabattKontoId property</summary>
        public int? AvgPliktRabattKontoId { get; set; }
        /// <summary>The AvvikRegnskap property</summary>
        public bool? AvvikRegnskap { get; set; }
        /// <summary>The BAdr1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BAdr1 { get; set; }
#nullable restore
#else
        public string BAdr1 { get; set; }
#endif
        /// <summary>The BAdr2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BAdr2 { get; set; }
#nullable restore
#else
        public string BAdr2 { get; set; }
#endif
        /// <summary>The BAdr3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BAdr3 { get; set; }
#nullable restore
#else
        public string BAdr3 { get; set; }
#endif
        /// <summary>The BankForb property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BankForb { get; set; }
#nullable restore
#else
        public string BankForb { get; set; }
#endif
        /// <summary>The BankKtonr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BankKtonr { get; set; }
#nullable restore
#else
        public string BankKtonr { get; set; }
#endif
        /// <summary>The BankTransNr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BankTransNr { get; set; }
#nullable restore
#else
        public string BankTransNr { get; set; }
#endif
        /// <summary>The BetVarsel property</summary>
        public int? BetVarsel { get; set; }
        /// <summary>The BevegelseIntervall property</summary>
        public int? BevegelseIntervall { get; set; }
        /// <summary>The BokforKrednotaGodkjenn property</summary>
        public bool? BokforKrednotaGodkjenn { get; set; }
        /// <summary>The BrukFargekoderPaaAbcStatus property</summary>
        public bool? BrukFargekoderPaaAbcStatus { get; set; }
        /// <summary>The BrukGrunndataProduktDesc property</summary>
        public bool? BrukGrunndataProduktDesc { get; set; }
        /// <summary>The BrukKIDNrKortBet property</summary>
        public bool? BrukKIDNrKortBet { get; set; }
        /// <summary>The BrukKundeProduktKoplingSalg property</summary>
        public bool? BrukKundeProduktKoplingSalg { get; set; }
        /// <summary>The BrukSalgsPris property</summary>
        public bool? BrukSalgsPris { get; set; }
        /// <summary>The DateFirstInd property</summary>
        public int? DateFirstInd { get; set; }
        /// <summary>The DirekteLevering property</summary>
        public bool? DirekteLevering { get; set; }
        /// <summary>The DirLevInkTjeneste property</summary>
        public bool? DirLevInkTjeneste { get; set; }
        /// <summary>The DisplayNavn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayNavn { get; set; }
#nullable restore
#else
        public string DisplayNavn { get; set; }
#endif
        /// <summary>The DisplayNavnSMS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayNavnSMS { get; set; }
#nullable restore
#else
        public string DisplayNavnSMS { get; set; }
#endif
        /// <summary>The EANNr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EANNr { get; set; }
#nullable restore
#else
        public string EANNr { get; set; }
#endif
        /// <summary>The EDIPostenProd property</summary>
        public bool? EDIPostenProd { get; set; }
        /// <summary>The EMail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EMail { get; set; }
#nullable restore
#else
        public string EMail { get; set; }
#endif
        /// <summary>The EoriNr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EoriNr { get; set; }
#nullable restore
#else
        public string EoriNr { get; set; }
#endif
        /// <summary>The ExportProformaFaktura property</summary>
        public bool? ExportProformaFaktura { get; set; }
        /// <summary>The FAdr1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FAdr1 { get; set; }
#nullable restore
#else
        public string FAdr1 { get; set; }
#endif
        /// <summary>The FAdr2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FAdr2 { get; set; }
#nullable restore
#else
        public string FAdr2 { get; set; }
#endif
        /// <summary>The FAdr3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FAdr3 { get; set; }
#nullable restore
#else
        public string FAdr3 { get; set; }
#endif
        /// <summary>The FaktGebyr property</summary>
        public double? FaktGebyr { get; set; }
        /// <summary>The FakturaAvr property</summary>
        public int? FakturaAvr { get; set; }
        /// <summary>The FakturaJournal property</summary>
        public bool? FakturaJournal { get; set; }
        /// <summary>The FakturaUtPaaUtmelding property</summary>
        public bool? FakturaUtPaaUtmelding { get; set; }
        /// <summary>The FaktUtkjValg property</summary>
        public int? FaktUtkjValg { get; set; }
        /// <summary>The FilTilIkas property</summary>
        public bool? FilTilIkas { get; set; }
        /// <summary>The ForeningsHandtering property</summary>
        public bool? ForeningsHandtering { get; set; }
        /// <summary>The Foretaknr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Foretaknr { get; set; }
#nullable restore
#else
        public string Foretaknr { get; set; }
#endif
        /// <summary>The ForskuddNyOB property</summary>
        public int? ForskuddNyOB { get; set; }
        /// <summary>The ForskuddPurring property</summary>
        public int? ForskuddPurring { get; set; }
        /// <summary>The ForskuddSlettOrdre property</summary>
        public int? ForskuddSlettOrdre { get; set; }
        /// <summary>The FraktBeregn property</summary>
        public int? FraktBeregn { get; set; }
        /// <summary>The GlobalLocationNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GlobalLocationNumber { get; set; }
#nullable restore
#else
        public string GlobalLocationNumber { get; set; }
#endif
        /// <summary>The GodkjennMinDG property</summary>
        public bool? GodkjennMinDG { get; set; }
        /// <summary>The GothiaAktivButikk property</summary>
        public bool? GothiaAktivButikk { get; set; }
        /// <summary>The GothiaAktivSalg property</summary>
        public bool? GothiaAktivSalg { get; set; }
        /// <summary>The HashKontaktPassord property</summary>
        public bool? HashKontaktPassord { get; set; }
        /// <summary>The HovedFax1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HovedFax1 { get; set; }
#nullable restore
#else
        public string HovedFax1 { get; set; }
#endif
        /// <summary>The HovedTlf1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HovedTlf1 { get; set; }
#nullable restore
#else
        public string HovedTlf1 { get; set; }
#endif
        /// <summary>The HurtigregistreringKunde property</summary>
        public bool? HurtigregistreringKunde { get; set; }
        /// <summary>The IgnorerAnnenFakturaMottaker property</summary>
        public bool? IgnorerAnnenFakturaMottaker { get; set; }
        /// <summary>The KatalogOppslagmcServicesLocalID property</summary>
        public int? KatalogOppslagmcServicesLocalID { get; set; }
        /// <summary>The KatalogOppslagModul property</summary>
        public bool? KatalogOppslagModul { get; set; }
        /// <summary>The Klientnr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Klientnr { get; set; }
#nullable restore
#else
        public string Klientnr { get; set; }
#endif
        /// <summary>The KonfigModulSalg property</summary>
        public bool? KonfigModulSalg { get; set; }
        /// <summary>The KontantRbtDag property</summary>
        public int? KontantRbtDag { get; set; }
        /// <summary>The KopierKontaktPersTilLevAdresse property</summary>
        public bool? KopierKontaktPersTilLevAdresse { get; set; }
        /// <summary>The KreditRef property</summary>
        public bool? KreditRef { get; set; }
        /// <summary>The KredNotaKortselskap property</summary>
        public bool? KredNotaKortselskap { get; set; }
        /// <summary>The KredSjekkForfallDgr property</summary>
        public int? KredSjekkForfallDgr { get; set; }
        /// <summary>The KredSjekkMsgInUtmelding property</summary>
        public bool? KredSjekkMsgInUtmelding { get; set; }
        /// <summary>The KredSjekkPlukkListe property</summary>
        public bool? KredSjekkPlukkListe { get; set; }
        /// <summary>The KundeAvsTollFaktPakk property</summary>
        public bool? KundeAvsTollFaktPakk { get; set; }
        /// <summary>The Kundenavn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Kundenavn { get; set; }
#nullable restore
#else
        public string Kundenavn { get; set; }
#endif
        /// <summary>The LAdr1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LAdr1 { get; set; }
#nullable restore
#else
        public string LAdr1 { get; set; }
#endif
        /// <summary>The LAdr2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LAdr2 { get; set; }
#nullable restore
#else
        public string LAdr2 { get; set; }
#endif
        /// <summary>The LAdr3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LAdr3 { get; set; }
#nullable restore
#else
        public string LAdr3 { get; set; }
#endif
        /// <summary>The LaasKortOrdre property</summary>
        public bool? LaasKortOrdre { get; set; }
        /// <summary>The MeldMinDGSjef property</summary>
        public bool? MeldMinDGSjef { get; set; }
        /// <summary>The MinOrdreGebyr property</summary>
        public double? MinOrdreGebyr { get; set; }
        /// <summary>The NextAktiv property</summary>
        public bool? NextAktiv { get; set; }
        /// <summary>The NextBransje property</summary>
        public int? NextBransje { get; set; }
        /// <summary>The NextInfo2 property</summary>
        public int? NextInfo2 { get; set; }
        /// <summary>The NextKlientnr property</summary>
        public int? NextKlientnr { get; set; }
        /// <summary>The NextSamleTrans property</summary>
        public bool? NextSamleTrans { get; set; }
        /// <summary>The OkoSystemId property</summary>
        public int? OkoSystemId { get; set; }
        /// <summary>The OrdrebokModul property</summary>
        public bool? OrdrebokModul { get; set; }
        /// <summary>The OrdreGebyr property</summary>
        public double? OrdreGebyr { get; set; }
        /// <summary>The OrdreHoldKredSjekk property</summary>
        public bool? OrdreHoldKredSjekk { get; set; }
        /// <summary>The OrgTollTariffNr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrgTollTariffNr { get; set; }
#nullable restore
#else
        public string OrgTollTariffNr { get; set; }
#endif
        /// <summary>The OverforVareKost property</summary>
        public int? OverforVareKost { get; set; }
        /// <summary>The PAdr1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PAdr1 { get; set; }
#nullable restore
#else
        public string PAdr1 { get; set; }
#endif
        /// <summary>The PAdr2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PAdr2 { get; set; }
#nullable restore
#else
        public string PAdr2 { get; set; }
#endif
        /// <summary>The PAdr3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PAdr3 { get; set; }
#nullable restore
#else
        public string PAdr3 { get; set; }
#endif
        /// <summary>The Pakning property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Pakning { get; set; }
#nullable restore
#else
        public string Pakning { get; set; }
#endif
        /// <summary>The PeriodeLengde property</summary>
        public int? PeriodeLengde { get; set; }
        /// <summary>The Postboks property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Postboks { get; set; }
#nullable restore
#else
        public string Postboks { get; set; }
#endif
        /// <summary>The PostGiroNr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostGiroNr { get; set; }
#nullable restore
#else
        public string PostGiroNr { get; set; }
#endif
        /// <summary>The PreForetaknr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreForetaknr { get; set; }
#nullable restore
#else
        public string PreForetaknr { get; set; }
#endif
        /// <summary>The PrisEtikettMVA1 property</summary>
        public bool? PrisEtikettMVA1 { get; set; }
        /// <summary>The PrisEtikettMVA2 property</summary>
        public bool? PrisEtikettMVA2 { get; set; }
        /// <summary>The ProsjektRegnskap property</summary>
        public bool? ProsjektRegnskap { get; set; }
        /// <summary>The PurreGebyr property</summary>
        public double? PurreGebyr { get; set; }
        /// <summary>The Paaslag property</summary>
        public double? Paaslag { get; set; }
        /// <summary>The RenteNota property</summary>
        public int? RenteNota { get; set; }
        /// <summary>The ReturGebyr property</summary>
        public double? ReturGebyr { get; set; }
        /// <summary>The ReturSpesDirekte property</summary>
        public int? ReturSpesDirekte { get; set; }
        /// <summary>The RubiconTypeKID property</summary>
        public int? RubiconTypeKID { get; set; }
        /// <summary>The SerienrTvunget property</summary>
        public bool? SerienrTvunget { get; set; }
        /// <summary>The ShowStandardKundeGrid property</summary>
        public bool? ShowStandardKundeGrid { get; set; }
        /// <summary>The SisteVarsel property</summary>
        public int? SisteVarsel { get; set; }
        /// <summary>The SkrivProformaUtm property</summary>
        public bool? SkrivProformaUtm { get; set; }
        /// <summary>The SMSVarsel property</summary>
        public bool? SMSVarsel { get; set; }
        /// <summary>The SpesialBestilling property</summary>
        public bool? SpesialBestilling { get; set; }
        /// <summary>The SporOrdrebekreftOpprette property</summary>
        public bool? SporOrdrebekreftOpprette { get; set; }
        /// <summary>The SporTilbudbekreftOpprette property</summary>
        public bool? SporTilbudbekreftOpprette { get; set; }
        /// <summary>The StdKjopForpakn property</summary>
        public bool? StdKjopForpakn { get; set; }
        /// <summary>The Suf2Foretaknr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Suf2Foretaknr { get; set; }
#nullable restore
#else
        public string Suf2Foretaknr { get; set; }
#endif
        /// <summary>The SufForetaknr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SufForetaknr { get; set; }
#nullable restore
#else
        public string SufForetaknr { get; set; }
#endif
        /// <summary>The SynkSuperOffice property</summary>
        public bool? SynkSuperOffice { get; set; }
        /// <summary>The TilbudGyldigTil property</summary>
        public int? TilbudGyldigTil { get; set; }
        /// <summary>The TimeEndring property</summary>
        public double? TimeEndring { get; set; }
        /// <summary>The TollFaktKundeLandAktiv property</summary>
        public bool? TollFaktKundeLandAktiv { get; set; }
        /// <summary>The TollFaktLandAktiv property</summary>
        public bool? TollFaktLandAktiv { get; set; }
        /// <summary>The TollFakturaType property</summary>
        public int? TollFakturaType { get; set; }
        /// <summary>The TollKonto property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TollKonto { get; set; }
#nullable restore
#else
        public string TollKonto { get; set; }
#endif
        /// <summary>The TransportorKlientNr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransportorKlientNr { get; set; }
#nullable restore
#else
        public string TransportorKlientNr { get; set; }
#endif
        /// <summary>The UrlProduktEdit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UrlProduktEdit { get; set; }
#nullable restore
#else
        public string UrlProduktEdit { get; set; }
#endif
        /// <summary>The UrlProduktInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UrlProduktInfo { get; set; }
#nullable restore
#else
        public string UrlProduktInfo { get; set; }
#endif
        /// <summary>The Use_Logistra property</summary>
        public bool? UseLogistra { get; set; }
        /// <summary>The Use_nShiftOnPrem property</summary>
        public bool? UseNShiftOnPrem { get; set; }
        /// <summary>The Use_PorterBuddy property</summary>
        public bool? UsePorterBuddy { get; set; }
        /// <summary>The UseRePurchaseValueAsDefault property</summary>
        public bool? UseRePurchaseValueAsDefault { get; set; }
        /// <summary>The UseSamSending property</summary>
        public bool? UseSamSending { get; set; }
        /// <summary>The UseShipmentServer property</summary>
        public bool? UseShipmentServer { get; set; }
        /// <summary>The UtlevInnland property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UtlevInnland { get; set; }
#nullable restore
#else
        public string UtlevInnland { get; set; }
#endif
        /// <summary>The UtlevUtland property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UtlevUtland { get; set; }
#nullable restore
#else
        public string UtlevUtland { get; set; }
#endif
        /// <summary>The VarsleBursdag property</summary>
        public bool? VarsleBursdag { get; set; }
        /// <summary>The VarsleFraktAvt property</summary>
        public bool? VarsleFraktAvt { get; set; }
        /// <summary>The VarsleHoldbarhet property</summary>
        public bool? VarsleHoldbarhet { get; set; }
        /// <summary>The VarsleIkkeGodkj property</summary>
        public bool? VarsleIkkeGodkj { get; set; }
        /// <summary>The VarsleIkkeOverf property</summary>
        public bool? VarsleIkkeOverf { get; set; }
        /// <summary>The VarsleInnkjAnk property</summary>
        public bool? VarsleInnkjAnk { get; set; }
        /// <summary>The VarsleInnkjLev property</summary>
        public bool? VarsleInnkjLev { get; set; }
        /// <summary>The VarsleKundeLogg property</summary>
        public bool? VarsleKundeLogg { get; set; }
        /// <summary>The VarsleRabattAvt property</summary>
        public bool? VarsleRabattAvt { get; set; }
        /// <summary>The VarsleTilbud property</summary>
        public bool? VarsleTilbud { get; set; }
        /// <summary>The VATNo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VATNo { get; set; }
#nullable restore
#else
        public string VATNo { get; set; }
#endif
        /// <summary>The VisAlternProduktNr property</summary>
        public bool? VisAlternProduktNr { get; set; }
        /// <summary>The VisKreditnotaEtterRetur property</summary>
        public bool? VisKreditnotaEtterRetur { get; set; }
        /// <summary>The VisMVAPaaFaktura property</summary>
        public int? VisMVAPaaFaktura { get; set; }
        /// <summary>The VisPrdKndKoblingInnkjop property</summary>
        public bool? VisPrdKndKoblingInnkjop { get; set; }
        /// <summary>The WebAdr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebAdr { get; set; }
#nullable restore
#else
        public string WebAdr { get; set; }
#endif
        /// <summary>The WebVariantSalg property</summary>
        public bool? WebVariantSalg { get; set; }
        /// <summary>The AapneForForskudd property</summary>
        public bool? AapneForForskudd { get; set; }
        /// <summary>The AapneForPredator property</summary>
        public bool? AapneForPredator { get; set; }
        /// <summary>
        /// Instantiates a new Senderdetails and sets the default values.
        /// </summary>
        public Senderdetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Senderdetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Senderdetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Abonnement", n => { Abonnement = n.GetBoolValue(); } },
                {"AIKolli", n => { AIKolli = n.GetStringValue(); } },
                {"AISending", n => { AISending = n.GetStringValue(); } },
                {"Aktiv", n => { Aktiv = n.GetBoolValue(); } },
                {"AktivForRabatterPaaTversAvAvsender", n => { AktivForRabatterPaaTversAvAvsender = n.GetBoolValue(); } },
                {"AktivOLAP", n => { AktivOLAP = n.GetBoolValue(); } },
                {"AlternProduktNrVisningsNavn", n => { AlternProduktNrVisningsNavn = n.GetStringValue(); } },
                {"AlterTid", n => { AlterTid = n.GetBoolValue(); } },
                {"AntDagIkkeGodkj", n => { AntDagIkkeGodkj = n.GetIntValue(); } },
                {"AntDagIkkeOverf", n => { AntDagIkkeOverf = n.GetIntValue(); } },
                {"AntDagInnkjAnk", n => { AntDagInnkjAnk = n.GetIntValue(); } },
                {"AntDagInnkjLev", n => { AntDagInnkjLev = n.GetIntValue(); } },
                {"AntDagOppfTilbud", n => { AntDagOppfTilbud = n.GetIntValue(); } },
                {"AntDagUtgFraktAvt", n => { AntDagUtgFraktAvt = n.GetIntValue(); } },
                {"AntDagUtgRabattAvt", n => { AntDagUtgRabattAvt = n.GetIntValue(); } },
                {"AntVarsel", n => { AntVarsel = n.GetIntValue(); } },
                {"AutoKredSjekk", n => { AutoKredSjekk = n.GetBoolValue(); } },
                {"AutoSkrivUtRetur", n => { AutoSkrivUtRetur = n.GetBoolValue(); } },
                {"AvansertBid", n => { AvansertBid = n.GetBoolValue(); } },
                {"AvdRegnskap", n => { AvdRegnskap = n.GetIntValue(); } },
                {"AvgFrittRabattKontoId", n => { AvgFrittRabattKontoId = n.GetIntValue(); } },
                {"AvgiftModellFlag", n => { AvgiftModellFlag = n.GetBoolValue(); } },
                {"AvgPliktRabattKontoId", n => { AvgPliktRabattKontoId = n.GetIntValue(); } },
                {"AvvikRegnskap", n => { AvvikRegnskap = n.GetBoolValue(); } },
                {"BAdr1", n => { BAdr1 = n.GetStringValue(); } },
                {"BAdr2", n => { BAdr2 = n.GetStringValue(); } },
                {"BAdr3", n => { BAdr3 = n.GetStringValue(); } },
                {"BankForb", n => { BankForb = n.GetStringValue(); } },
                {"BankKtonr", n => { BankKtonr = n.GetStringValue(); } },
                {"BankTransNr", n => { BankTransNr = n.GetStringValue(); } },
                {"BetVarsel", n => { BetVarsel = n.GetIntValue(); } },
                {"BevegelseIntervall", n => { BevegelseIntervall = n.GetIntValue(); } },
                {"BokforKrednotaGodkjenn", n => { BokforKrednotaGodkjenn = n.GetBoolValue(); } },
                {"BrukFargekoderPaaAbcStatus", n => { BrukFargekoderPaaAbcStatus = n.GetBoolValue(); } },
                {"BrukGrunndataProduktDesc", n => { BrukGrunndataProduktDesc = n.GetBoolValue(); } },
                {"BrukKIDNrKortBet", n => { BrukKIDNrKortBet = n.GetBoolValue(); } },
                {"BrukKundeProduktKoplingSalg", n => { BrukKundeProduktKoplingSalg = n.GetBoolValue(); } },
                {"BrukSalgsPris", n => { BrukSalgsPris = n.GetBoolValue(); } },
                {"DateFirstInd", n => { DateFirstInd = n.GetIntValue(); } },
                {"DirekteLevering", n => { DirekteLevering = n.GetBoolValue(); } },
                {"DirLevInkTjeneste", n => { DirLevInkTjeneste = n.GetBoolValue(); } },
                {"DisplayNavn", n => { DisplayNavn = n.GetStringValue(); } },
                {"DisplayNavnSMS", n => { DisplayNavnSMS = n.GetStringValue(); } },
                {"EANNr", n => { EANNr = n.GetStringValue(); } },
                {"EDIPostenProd", n => { EDIPostenProd = n.GetBoolValue(); } },
                {"EMail", n => { EMail = n.GetStringValue(); } },
                {"EoriNr", n => { EoriNr = n.GetStringValue(); } },
                {"ExportProformaFaktura", n => { ExportProformaFaktura = n.GetBoolValue(); } },
                {"FAdr1", n => { FAdr1 = n.GetStringValue(); } },
                {"FAdr2", n => { FAdr2 = n.GetStringValue(); } },
                {"FAdr3", n => { FAdr3 = n.GetStringValue(); } },
                {"FaktGebyr", n => { FaktGebyr = n.GetDoubleValue(); } },
                {"FakturaAvr", n => { FakturaAvr = n.GetIntValue(); } },
                {"FakturaJournal", n => { FakturaJournal = n.GetBoolValue(); } },
                {"FakturaUtPaaUtmelding", n => { FakturaUtPaaUtmelding = n.GetBoolValue(); } },
                {"FaktUtkjValg", n => { FaktUtkjValg = n.GetIntValue(); } },
                {"FilTilIkas", n => { FilTilIkas = n.GetBoolValue(); } },
                {"ForeningsHandtering", n => { ForeningsHandtering = n.GetBoolValue(); } },
                {"Foretaknr", n => { Foretaknr = n.GetStringValue(); } },
                {"ForskuddNyOB", n => { ForskuddNyOB = n.GetIntValue(); } },
                {"ForskuddPurring", n => { ForskuddPurring = n.GetIntValue(); } },
                {"ForskuddSlettOrdre", n => { ForskuddSlettOrdre = n.GetIntValue(); } },
                {"FraktBeregn", n => { FraktBeregn = n.GetIntValue(); } },
                {"GlobalLocationNumber", n => { GlobalLocationNumber = n.GetStringValue(); } },
                {"GodkjennMinDG", n => { GodkjennMinDG = n.GetBoolValue(); } },
                {"GothiaAktivButikk", n => { GothiaAktivButikk = n.GetBoolValue(); } },
                {"GothiaAktivSalg", n => { GothiaAktivSalg = n.GetBoolValue(); } },
                {"HashKontaktPassord", n => { HashKontaktPassord = n.GetBoolValue(); } },
                {"HovedFax1", n => { HovedFax1 = n.GetStringValue(); } },
                {"HovedTlf1", n => { HovedTlf1 = n.GetStringValue(); } },
                {"HurtigregistreringKunde", n => { HurtigregistreringKunde = n.GetBoolValue(); } },
                {"IgnorerAnnenFakturaMottaker", n => { IgnorerAnnenFakturaMottaker = n.GetBoolValue(); } },
                {"KatalogOppslagmcServicesLocalID", n => { KatalogOppslagmcServicesLocalID = n.GetIntValue(); } },
                {"KatalogOppslagModul", n => { KatalogOppslagModul = n.GetBoolValue(); } },
                {"Klientnr", n => { Klientnr = n.GetStringValue(); } },
                {"KonfigModulSalg", n => { KonfigModulSalg = n.GetBoolValue(); } },
                {"KontantRbtDag", n => { KontantRbtDag = n.GetIntValue(); } },
                {"KopierKontaktPersTilLevAdresse", n => { KopierKontaktPersTilLevAdresse = n.GetBoolValue(); } },
                {"KreditRef", n => { KreditRef = n.GetBoolValue(); } },
                {"KredNotaKortselskap", n => { KredNotaKortselskap = n.GetBoolValue(); } },
                {"KredSjekkForfallDgr", n => { KredSjekkForfallDgr = n.GetIntValue(); } },
                {"KredSjekkMsgInUtmelding", n => { KredSjekkMsgInUtmelding = n.GetBoolValue(); } },
                {"KredSjekkPlukkListe", n => { KredSjekkPlukkListe = n.GetBoolValue(); } },
                {"KundeAvsTollFaktPakk", n => { KundeAvsTollFaktPakk = n.GetBoolValue(); } },
                {"Kundenavn", n => { Kundenavn = n.GetStringValue(); } },
                {"LAdr1", n => { LAdr1 = n.GetStringValue(); } },
                {"LAdr2", n => { LAdr2 = n.GetStringValue(); } },
                {"LAdr3", n => { LAdr3 = n.GetStringValue(); } },
                {"LaasKortOrdre", n => { LaasKortOrdre = n.GetBoolValue(); } },
                {"MeldMinDGSjef", n => { MeldMinDGSjef = n.GetBoolValue(); } },
                {"MinOrdreGebyr", n => { MinOrdreGebyr = n.GetDoubleValue(); } },
                {"NextAktiv", n => { NextAktiv = n.GetBoolValue(); } },
                {"NextBransje", n => { NextBransje = n.GetIntValue(); } },
                {"NextInfo2", n => { NextInfo2 = n.GetIntValue(); } },
                {"NextKlientnr", n => { NextKlientnr = n.GetIntValue(); } },
                {"NextSamleTrans", n => { NextSamleTrans = n.GetBoolValue(); } },
                {"OkoSystemId", n => { OkoSystemId = n.GetIntValue(); } },
                {"OrdrebokModul", n => { OrdrebokModul = n.GetBoolValue(); } },
                {"OrdreGebyr", n => { OrdreGebyr = n.GetDoubleValue(); } },
                {"OrdreHoldKredSjekk", n => { OrdreHoldKredSjekk = n.GetBoolValue(); } },
                {"OrgTollTariffNr", n => { OrgTollTariffNr = n.GetStringValue(); } },
                {"OverforVareKost", n => { OverforVareKost = n.GetIntValue(); } },
                {"PAdr1", n => { PAdr1 = n.GetStringValue(); } },
                {"PAdr2", n => { PAdr2 = n.GetStringValue(); } },
                {"PAdr3", n => { PAdr3 = n.GetStringValue(); } },
                {"Pakning", n => { Pakning = n.GetStringValue(); } },
                {"PeriodeLengde", n => { PeriodeLengde = n.GetIntValue(); } },
                {"Postboks", n => { Postboks = n.GetStringValue(); } },
                {"PostGiroNr", n => { PostGiroNr = n.GetStringValue(); } },
                {"PreForetaknr", n => { PreForetaknr = n.GetStringValue(); } },
                {"PrisEtikettMVA1", n => { PrisEtikettMVA1 = n.GetBoolValue(); } },
                {"PrisEtikettMVA2", n => { PrisEtikettMVA2 = n.GetBoolValue(); } },
                {"ProsjektRegnskap", n => { ProsjektRegnskap = n.GetBoolValue(); } },
                {"PurreGebyr", n => { PurreGebyr = n.GetDoubleValue(); } },
                {"Paaslag", n => { Paaslag = n.GetDoubleValue(); } },
                {"RenteNota", n => { RenteNota = n.GetIntValue(); } },
                {"ReturGebyr", n => { ReturGebyr = n.GetDoubleValue(); } },
                {"ReturSpesDirekte", n => { ReturSpesDirekte = n.GetIntValue(); } },
                {"RubiconTypeKID", n => { RubiconTypeKID = n.GetIntValue(); } },
                {"SerienrTvunget", n => { SerienrTvunget = n.GetBoolValue(); } },
                {"ShowStandardKundeGrid", n => { ShowStandardKundeGrid = n.GetBoolValue(); } },
                {"SisteVarsel", n => { SisteVarsel = n.GetIntValue(); } },
                {"SkrivProformaUtm", n => { SkrivProformaUtm = n.GetBoolValue(); } },
                {"SMSVarsel", n => { SMSVarsel = n.GetBoolValue(); } },
                {"SpesialBestilling", n => { SpesialBestilling = n.GetBoolValue(); } },
                {"SporOrdrebekreftOpprette", n => { SporOrdrebekreftOpprette = n.GetBoolValue(); } },
                {"SporTilbudbekreftOpprette", n => { SporTilbudbekreftOpprette = n.GetBoolValue(); } },
                {"StdKjopForpakn", n => { StdKjopForpakn = n.GetBoolValue(); } },
                {"Suf2Foretaknr", n => { Suf2Foretaknr = n.GetStringValue(); } },
                {"SufForetaknr", n => { SufForetaknr = n.GetStringValue(); } },
                {"SynkSuperOffice", n => { SynkSuperOffice = n.GetBoolValue(); } },
                {"TilbudGyldigTil", n => { TilbudGyldigTil = n.GetIntValue(); } },
                {"TimeEndring", n => { TimeEndring = n.GetDoubleValue(); } },
                {"TollFaktKundeLandAktiv", n => { TollFaktKundeLandAktiv = n.GetBoolValue(); } },
                {"TollFaktLandAktiv", n => { TollFaktLandAktiv = n.GetBoolValue(); } },
                {"TollFakturaType", n => { TollFakturaType = n.GetIntValue(); } },
                {"TollKonto", n => { TollKonto = n.GetStringValue(); } },
                {"TransportorKlientNr", n => { TransportorKlientNr = n.GetStringValue(); } },
                {"UrlProduktEdit", n => { UrlProduktEdit = n.GetStringValue(); } },
                {"UrlProduktInfo", n => { UrlProduktInfo = n.GetStringValue(); } },
                {"Use_Logistra", n => { UseLogistra = n.GetBoolValue(); } },
                {"Use_nShiftOnPrem", n => { UseNShiftOnPrem = n.GetBoolValue(); } },
                {"Use_PorterBuddy", n => { UsePorterBuddy = n.GetBoolValue(); } },
                {"UseRePurchaseValueAsDefault", n => { UseRePurchaseValueAsDefault = n.GetBoolValue(); } },
                {"UseSamSending", n => { UseSamSending = n.GetBoolValue(); } },
                {"UseShipmentServer", n => { UseShipmentServer = n.GetBoolValue(); } },
                {"UtlevInnland", n => { UtlevInnland = n.GetStringValue(); } },
                {"UtlevUtland", n => { UtlevUtland = n.GetStringValue(); } },
                {"VarsleBursdag", n => { VarsleBursdag = n.GetBoolValue(); } },
                {"VarsleFraktAvt", n => { VarsleFraktAvt = n.GetBoolValue(); } },
                {"VarsleHoldbarhet", n => { VarsleHoldbarhet = n.GetBoolValue(); } },
                {"VarsleIkkeGodkj", n => { VarsleIkkeGodkj = n.GetBoolValue(); } },
                {"VarsleIkkeOverf", n => { VarsleIkkeOverf = n.GetBoolValue(); } },
                {"VarsleInnkjAnk", n => { VarsleInnkjAnk = n.GetBoolValue(); } },
                {"VarsleInnkjLev", n => { VarsleInnkjLev = n.GetBoolValue(); } },
                {"VarsleKundeLogg", n => { VarsleKundeLogg = n.GetBoolValue(); } },
                {"VarsleRabattAvt", n => { VarsleRabattAvt = n.GetBoolValue(); } },
                {"VarsleTilbud", n => { VarsleTilbud = n.GetBoolValue(); } },
                {"VATNo", n => { VATNo = n.GetStringValue(); } },
                {"VisAlternProduktNr", n => { VisAlternProduktNr = n.GetBoolValue(); } },
                {"VisKreditnotaEtterRetur", n => { VisKreditnotaEtterRetur = n.GetBoolValue(); } },
                {"VisMVAPaaFaktura", n => { VisMVAPaaFaktura = n.GetIntValue(); } },
                {"VisPrdKndKoblingInnkjop", n => { VisPrdKndKoblingInnkjop = n.GetBoolValue(); } },
                {"WebAdr", n => { WebAdr = n.GetStringValue(); } },
                {"WebVariantSalg", n => { WebVariantSalg = n.GetBoolValue(); } },
                {"AapneForForskudd", n => { AapneForForskudd = n.GetBoolValue(); } },
                {"AapneForPredator", n => { AapneForPredator = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("Abonnement", Abonnement);
            writer.WriteStringValue("AIKolli", AIKolli);
            writer.WriteStringValue("AISending", AISending);
            writer.WriteBoolValue("Aktiv", Aktiv);
            writer.WriteBoolValue("AktivForRabatterPaaTversAvAvsender", AktivForRabatterPaaTversAvAvsender);
            writer.WriteBoolValue("AktivOLAP", AktivOLAP);
            writer.WriteStringValue("AlternProduktNrVisningsNavn", AlternProduktNrVisningsNavn);
            writer.WriteBoolValue("AlterTid", AlterTid);
            writer.WriteIntValue("AntDagIkkeGodkj", AntDagIkkeGodkj);
            writer.WriteIntValue("AntDagIkkeOverf", AntDagIkkeOverf);
            writer.WriteIntValue("AntDagInnkjAnk", AntDagInnkjAnk);
            writer.WriteIntValue("AntDagInnkjLev", AntDagInnkjLev);
            writer.WriteIntValue("AntDagOppfTilbud", AntDagOppfTilbud);
            writer.WriteIntValue("AntDagUtgFraktAvt", AntDagUtgFraktAvt);
            writer.WriteIntValue("AntDagUtgRabattAvt", AntDagUtgRabattAvt);
            writer.WriteIntValue("AntVarsel", AntVarsel);
            writer.WriteBoolValue("AutoKredSjekk", AutoKredSjekk);
            writer.WriteBoolValue("AutoSkrivUtRetur", AutoSkrivUtRetur);
            writer.WriteBoolValue("AvansertBid", AvansertBid);
            writer.WriteIntValue("AvdRegnskap", AvdRegnskap);
            writer.WriteIntValue("AvgFrittRabattKontoId", AvgFrittRabattKontoId);
            writer.WriteBoolValue("AvgiftModellFlag", AvgiftModellFlag);
            writer.WriteIntValue("AvgPliktRabattKontoId", AvgPliktRabattKontoId);
            writer.WriteBoolValue("AvvikRegnskap", AvvikRegnskap);
            writer.WriteStringValue("BAdr1", BAdr1);
            writer.WriteStringValue("BAdr2", BAdr2);
            writer.WriteStringValue("BAdr3", BAdr3);
            writer.WriteStringValue("BankForb", BankForb);
            writer.WriteStringValue("BankKtonr", BankKtonr);
            writer.WriteStringValue("BankTransNr", BankTransNr);
            writer.WriteIntValue("BetVarsel", BetVarsel);
            writer.WriteIntValue("BevegelseIntervall", BevegelseIntervall);
            writer.WriteBoolValue("BokforKrednotaGodkjenn", BokforKrednotaGodkjenn);
            writer.WriteBoolValue("BrukFargekoderPaaAbcStatus", BrukFargekoderPaaAbcStatus);
            writer.WriteBoolValue("BrukGrunndataProduktDesc", BrukGrunndataProduktDesc);
            writer.WriteBoolValue("BrukKIDNrKortBet", BrukKIDNrKortBet);
            writer.WriteBoolValue("BrukKundeProduktKoplingSalg", BrukKundeProduktKoplingSalg);
            writer.WriteBoolValue("BrukSalgsPris", BrukSalgsPris);
            writer.WriteIntValue("DateFirstInd", DateFirstInd);
            writer.WriteBoolValue("DirekteLevering", DirekteLevering);
            writer.WriteBoolValue("DirLevInkTjeneste", DirLevInkTjeneste);
            writer.WriteStringValue("DisplayNavn", DisplayNavn);
            writer.WriteStringValue("DisplayNavnSMS", DisplayNavnSMS);
            writer.WriteStringValue("EANNr", EANNr);
            writer.WriteBoolValue("EDIPostenProd", EDIPostenProd);
            writer.WriteStringValue("EMail", EMail);
            writer.WriteStringValue("EoriNr", EoriNr);
            writer.WriteBoolValue("ExportProformaFaktura", ExportProformaFaktura);
            writer.WriteStringValue("FAdr1", FAdr1);
            writer.WriteStringValue("FAdr2", FAdr2);
            writer.WriteStringValue("FAdr3", FAdr3);
            writer.WriteDoubleValue("FaktGebyr", FaktGebyr);
            writer.WriteIntValue("FakturaAvr", FakturaAvr);
            writer.WriteBoolValue("FakturaJournal", FakturaJournal);
            writer.WriteBoolValue("FakturaUtPaaUtmelding", FakturaUtPaaUtmelding);
            writer.WriteIntValue("FaktUtkjValg", FaktUtkjValg);
            writer.WriteBoolValue("FilTilIkas", FilTilIkas);
            writer.WriteBoolValue("ForeningsHandtering", ForeningsHandtering);
            writer.WriteStringValue("Foretaknr", Foretaknr);
            writer.WriteIntValue("ForskuddNyOB", ForskuddNyOB);
            writer.WriteIntValue("ForskuddPurring", ForskuddPurring);
            writer.WriteIntValue("ForskuddSlettOrdre", ForskuddSlettOrdre);
            writer.WriteIntValue("FraktBeregn", FraktBeregn);
            writer.WriteStringValue("GlobalLocationNumber", GlobalLocationNumber);
            writer.WriteBoolValue("GodkjennMinDG", GodkjennMinDG);
            writer.WriteBoolValue("GothiaAktivButikk", GothiaAktivButikk);
            writer.WriteBoolValue("GothiaAktivSalg", GothiaAktivSalg);
            writer.WriteBoolValue("HashKontaktPassord", HashKontaktPassord);
            writer.WriteStringValue("HovedFax1", HovedFax1);
            writer.WriteStringValue("HovedTlf1", HovedTlf1);
            writer.WriteBoolValue("HurtigregistreringKunde", HurtigregistreringKunde);
            writer.WriteBoolValue("IgnorerAnnenFakturaMottaker", IgnorerAnnenFakturaMottaker);
            writer.WriteIntValue("KatalogOppslagmcServicesLocalID", KatalogOppslagmcServicesLocalID);
            writer.WriteBoolValue("KatalogOppslagModul", KatalogOppslagModul);
            writer.WriteStringValue("Klientnr", Klientnr);
            writer.WriteBoolValue("KonfigModulSalg", KonfigModulSalg);
            writer.WriteIntValue("KontantRbtDag", KontantRbtDag);
            writer.WriteBoolValue("KopierKontaktPersTilLevAdresse", KopierKontaktPersTilLevAdresse);
            writer.WriteBoolValue("KreditRef", KreditRef);
            writer.WriteBoolValue("KredNotaKortselskap", KredNotaKortselskap);
            writer.WriteIntValue("KredSjekkForfallDgr", KredSjekkForfallDgr);
            writer.WriteBoolValue("KredSjekkMsgInUtmelding", KredSjekkMsgInUtmelding);
            writer.WriteBoolValue("KredSjekkPlukkListe", KredSjekkPlukkListe);
            writer.WriteBoolValue("KundeAvsTollFaktPakk", KundeAvsTollFaktPakk);
            writer.WriteStringValue("Kundenavn", Kundenavn);
            writer.WriteStringValue("LAdr1", LAdr1);
            writer.WriteStringValue("LAdr2", LAdr2);
            writer.WriteStringValue("LAdr3", LAdr3);
            writer.WriteBoolValue("LaasKortOrdre", LaasKortOrdre);
            writer.WriteBoolValue("MeldMinDGSjef", MeldMinDGSjef);
            writer.WriteDoubleValue("MinOrdreGebyr", MinOrdreGebyr);
            writer.WriteBoolValue("NextAktiv", NextAktiv);
            writer.WriteIntValue("NextBransje", NextBransje);
            writer.WriteIntValue("NextInfo2", NextInfo2);
            writer.WriteIntValue("NextKlientnr", NextKlientnr);
            writer.WriteBoolValue("NextSamleTrans", NextSamleTrans);
            writer.WriteIntValue("OkoSystemId", OkoSystemId);
            writer.WriteBoolValue("OrdrebokModul", OrdrebokModul);
            writer.WriteDoubleValue("OrdreGebyr", OrdreGebyr);
            writer.WriteBoolValue("OrdreHoldKredSjekk", OrdreHoldKredSjekk);
            writer.WriteStringValue("OrgTollTariffNr", OrgTollTariffNr);
            writer.WriteIntValue("OverforVareKost", OverforVareKost);
            writer.WriteStringValue("PAdr1", PAdr1);
            writer.WriteStringValue("PAdr2", PAdr2);
            writer.WriteStringValue("PAdr3", PAdr3);
            writer.WriteStringValue("Pakning", Pakning);
            writer.WriteIntValue("PeriodeLengde", PeriodeLengde);
            writer.WriteStringValue("Postboks", Postboks);
            writer.WriteStringValue("PostGiroNr", PostGiroNr);
            writer.WriteStringValue("PreForetaknr", PreForetaknr);
            writer.WriteBoolValue("PrisEtikettMVA1", PrisEtikettMVA1);
            writer.WriteBoolValue("PrisEtikettMVA2", PrisEtikettMVA2);
            writer.WriteBoolValue("ProsjektRegnskap", ProsjektRegnskap);
            writer.WriteDoubleValue("PurreGebyr", PurreGebyr);
            writer.WriteDoubleValue("Paaslag", Paaslag);
            writer.WriteIntValue("RenteNota", RenteNota);
            writer.WriteDoubleValue("ReturGebyr", ReturGebyr);
            writer.WriteIntValue("ReturSpesDirekte", ReturSpesDirekte);
            writer.WriteIntValue("RubiconTypeKID", RubiconTypeKID);
            writer.WriteBoolValue("SerienrTvunget", SerienrTvunget);
            writer.WriteBoolValue("ShowStandardKundeGrid", ShowStandardKundeGrid);
            writer.WriteIntValue("SisteVarsel", SisteVarsel);
            writer.WriteBoolValue("SkrivProformaUtm", SkrivProformaUtm);
            writer.WriteBoolValue("SMSVarsel", SMSVarsel);
            writer.WriteBoolValue("SpesialBestilling", SpesialBestilling);
            writer.WriteBoolValue("SporOrdrebekreftOpprette", SporOrdrebekreftOpprette);
            writer.WriteBoolValue("SporTilbudbekreftOpprette", SporTilbudbekreftOpprette);
            writer.WriteBoolValue("StdKjopForpakn", StdKjopForpakn);
            writer.WriteStringValue("Suf2Foretaknr", Suf2Foretaknr);
            writer.WriteStringValue("SufForetaknr", SufForetaknr);
            writer.WriteBoolValue("SynkSuperOffice", SynkSuperOffice);
            writer.WriteIntValue("TilbudGyldigTil", TilbudGyldigTil);
            writer.WriteDoubleValue("TimeEndring", TimeEndring);
            writer.WriteBoolValue("TollFaktKundeLandAktiv", TollFaktKundeLandAktiv);
            writer.WriteBoolValue("TollFaktLandAktiv", TollFaktLandAktiv);
            writer.WriteIntValue("TollFakturaType", TollFakturaType);
            writer.WriteStringValue("TollKonto", TollKonto);
            writer.WriteStringValue("TransportorKlientNr", TransportorKlientNr);
            writer.WriteStringValue("UrlProduktEdit", UrlProduktEdit);
            writer.WriteStringValue("UrlProduktInfo", UrlProduktInfo);
            writer.WriteBoolValue("Use_Logistra", UseLogistra);
            writer.WriteBoolValue("Use_nShiftOnPrem", UseNShiftOnPrem);
            writer.WriteBoolValue("Use_PorterBuddy", UsePorterBuddy);
            writer.WriteBoolValue("UseRePurchaseValueAsDefault", UseRePurchaseValueAsDefault);
            writer.WriteBoolValue("UseSamSending", UseSamSending);
            writer.WriteBoolValue("UseShipmentServer", UseShipmentServer);
            writer.WriteStringValue("UtlevInnland", UtlevInnland);
            writer.WriteStringValue("UtlevUtland", UtlevUtland);
            writer.WriteBoolValue("VarsleBursdag", VarsleBursdag);
            writer.WriteBoolValue("VarsleFraktAvt", VarsleFraktAvt);
            writer.WriteBoolValue("VarsleHoldbarhet", VarsleHoldbarhet);
            writer.WriteBoolValue("VarsleIkkeGodkj", VarsleIkkeGodkj);
            writer.WriteBoolValue("VarsleIkkeOverf", VarsleIkkeOverf);
            writer.WriteBoolValue("VarsleInnkjAnk", VarsleInnkjAnk);
            writer.WriteBoolValue("VarsleInnkjLev", VarsleInnkjLev);
            writer.WriteBoolValue("VarsleKundeLogg", VarsleKundeLogg);
            writer.WriteBoolValue("VarsleRabattAvt", VarsleRabattAvt);
            writer.WriteBoolValue("VarsleTilbud", VarsleTilbud);
            writer.WriteStringValue("VATNo", VATNo);
            writer.WriteBoolValue("VisAlternProduktNr", VisAlternProduktNr);
            writer.WriteBoolValue("VisKreditnotaEtterRetur", VisKreditnotaEtterRetur);
            writer.WriteIntValue("VisMVAPaaFaktura", VisMVAPaaFaktura);
            writer.WriteBoolValue("VisPrdKndKoblingInnkjop", VisPrdKndKoblingInnkjop);
            writer.WriteStringValue("WebAdr", WebAdr);
            writer.WriteBoolValue("WebVariantSalg", WebVariantSalg);
            writer.WriteBoolValue("AapneForForskudd", AapneForForskudd);
            writer.WriteBoolValue("AapneForPredator", AapneForPredator);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
