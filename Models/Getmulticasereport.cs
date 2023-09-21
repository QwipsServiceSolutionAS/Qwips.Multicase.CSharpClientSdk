using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Getmulticasereport : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AktivAvsAdresseID property</summary>
        public int? AktivAvsAdresseID { get; set; }
        /// <summary>The AktivBrukerID property</summary>
        public int? AktivBrukerID { get; set; }
        /// <summary>The AvsAdresseID property</summary>
        public int? AvsAdresseID { get; set; }
        /// <summary>The AvsAdresseID2 property</summary>
        public int? AvsAdresseID2 { get; set; }
        /// <summary>The BrukerID property</summary>
        public int? BrukerID { get; set; }
        /// <summary>The EHFCatalog property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Ehfcatalogparameters? EHFCatalog { get; set; }
#nullable restore
#else
        public Ehfcatalogparameters EHFCatalog { get; set; }
#endif
        /// <summary>The Faktura property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Fakturaparameters? Faktura { get; set; }
#nullable restore
#else
        public Fakturaparameters Faktura { get; set; }
#endif
        /// <summary>The FomDate property</summary>
        public DateTimeOffset? FomDate { get; set; }
        /// <summary>The FomDate2 property</summary>
        public DateTimeOffset? FomDate2 { get; set; }
        /// <summary>The FraktID property</summary>
        public int? FraktID { get; set; }
        /// <summary>The Fredagsdato property</summary>
        public DateTimeOffset? Fredagsdato { get; set; }
        /// <summary>The GenericSelectionField property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Getmulticasereport_GenericSelectionField? GenericSelectionField { get; set; }
#nullable restore
#else
        public Getmulticasereport_GenericSelectionField GenericSelectionField { get; set; }
#endif
        /// <summary>The GeneriskTxt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GeneriskTxt { get; set; }
#nullable restore
#else
        public string GeneriskTxt { get; set; }
#endif
        /// <summary>The IsPDFReport property</summary>
        public bool? IsPDFReport { get; set; }
        /// <summary>The KndGrpID property</summary>
        public int? KndGrpID { get; set; }
        /// <summary>The KundeID property</summary>
        public int? KundeID { get; set; }
        /// <summary>The Kundenavn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Kundenavn { get; set; }
#nullable restore
#else
        public string Kundenavn { get; set; }
#endif
        /// <summary>The LagerID property</summary>
        public int? LagerID { get; set; }
        /// <summary>The LanguageID property</summary>
        public int? LanguageID { get; set; }
        /// <summary>The LeverandID property</summary>
        public int? LeverandID { get; set; }
        /// <summary>The Pricat property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Pricatparameters? Pricat { get; set; }
#nullable restore
#else
        public Pricatparameters Pricat { get; set; }
#endif
        /// <summary>The Pricat20 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Pricat20parameters? Pricat20 { get; set; }
#nullable restore
#else
        public Pricat20parameters Pricat20 { get; set; }
#endif
        /// <summary>The PrisGruppeIDs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? PrisGruppeIDs { get; set; }
#nullable restore
#else
        public List<int?> PrisGruppeIDs { get; set; }
#endif
        /// <summary>The ProductGroup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Productgroupparameters? ProductGroup { get; set; }
#nullable restore
#else
        public Productgroupparameters ProductGroup { get; set; }
#endif
        /// <summary>The ProdusentID property</summary>
        public int? ProdusentID { get; set; }
        /// <summary>The Referanse property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Referanseparameters? Referanse { get; set; }
#nullable restore
#else
        public Referanseparameters Referanse { get; set; }
#endif
        /// <summary>The ReportID property</summary>
        public int? ReportID { get; set; }
        /// <summary>The TomDate property</summary>
        public DateTimeOffset? TomDate { get; set; }
        /// <summary>The TomDate2 property</summary>
        public DateTimeOffset? TomDate2 { get; set; }
        /// <summary>The Varenr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Varenr { get; set; }
#nullable restore
#else
        public string Varenr { get; set; }
#endif
        /// <summary>The WarehouseCorrections property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Warehousecorrectionsparameters? WarehouseCorrections { get; set; }
#nullable restore
#else
        public Warehousecorrectionsparameters WarehouseCorrections { get; set; }
#endif
        /// <summary>The WarehouseCostAdjustment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Warehousecostadjustmentparameters? WarehouseCostAdjustment { get; set; }
#nullable restore
#else
        public Warehousecostadjustmentparameters WarehouseCostAdjustment { get; set; }
#endif
        /// <summary>The WebDataId property</summary>
        public int? WebDataId { get; set; }
        /// <summary>
        /// Instantiates a new Getmulticasereport and sets the default values.
        /// </summary>
        public Getmulticasereport() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Getmulticasereport CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Getmulticasereport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AktivAvsAdresseID", n => { AktivAvsAdresseID = n.GetIntValue(); } },
                {"AktivBrukerID", n => { AktivBrukerID = n.GetIntValue(); } },
                {"AvsAdresseID", n => { AvsAdresseID = n.GetIntValue(); } },
                {"AvsAdresseID2", n => { AvsAdresseID2 = n.GetIntValue(); } },
                {"BrukerID", n => { BrukerID = n.GetIntValue(); } },
                {"EHFCatalog", n => { EHFCatalog = n.GetObjectValue<Ehfcatalogparameters>(Ehfcatalogparameters.CreateFromDiscriminatorValue); } },
                {"Faktura", n => { Faktura = n.GetObjectValue<Fakturaparameters>(Fakturaparameters.CreateFromDiscriminatorValue); } },
                {"FomDate", n => { FomDate = n.GetDateTimeOffsetValue(); } },
                {"FomDate2", n => { FomDate2 = n.GetDateTimeOffsetValue(); } },
                {"FraktID", n => { FraktID = n.GetIntValue(); } },
                {"Fredagsdato", n => { Fredagsdato = n.GetDateTimeOffsetValue(); } },
                {"GenericSelectionField", n => { GenericSelectionField = n.GetObjectValue<Getmulticasereport_GenericSelectionField>(Getmulticasereport_GenericSelectionField.CreateFromDiscriminatorValue); } },
                {"GeneriskTxt", n => { GeneriskTxt = n.GetStringValue(); } },
                {"IsPDFReport", n => { IsPDFReport = n.GetBoolValue(); } },
                {"KndGrpID", n => { KndGrpID = n.GetIntValue(); } },
                {"KundeID", n => { KundeID = n.GetIntValue(); } },
                {"Kundenavn", n => { Kundenavn = n.GetStringValue(); } },
                {"LagerID", n => { LagerID = n.GetIntValue(); } },
                {"LanguageID", n => { LanguageID = n.GetIntValue(); } },
                {"LeverandID", n => { LeverandID = n.GetIntValue(); } },
                {"Pricat", n => { Pricat = n.GetObjectValue<Pricatparameters>(Pricatparameters.CreateFromDiscriminatorValue); } },
                {"Pricat20", n => { Pricat20 = n.GetObjectValue<Pricat20parameters>(Pricat20parameters.CreateFromDiscriminatorValue); } },
                {"PrisGruppeIDs", n => { PrisGruppeIDs = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                {"ProductGroup", n => { ProductGroup = n.GetObjectValue<Productgroupparameters>(Productgroupparameters.CreateFromDiscriminatorValue); } },
                {"ProdusentID", n => { ProdusentID = n.GetIntValue(); } },
                {"Referanse", n => { Referanse = n.GetObjectValue<Referanseparameters>(Referanseparameters.CreateFromDiscriminatorValue); } },
                {"ReportID", n => { ReportID = n.GetIntValue(); } },
                {"TomDate", n => { TomDate = n.GetDateTimeOffsetValue(); } },
                {"TomDate2", n => { TomDate2 = n.GetDateTimeOffsetValue(); } },
                {"Varenr", n => { Varenr = n.GetStringValue(); } },
                {"WarehouseCorrections", n => { WarehouseCorrections = n.GetObjectValue<Warehousecorrectionsparameters>(Warehousecorrectionsparameters.CreateFromDiscriminatorValue); } },
                {"WarehouseCostAdjustment", n => { WarehouseCostAdjustment = n.GetObjectValue<Warehousecostadjustmentparameters>(Warehousecostadjustmentparameters.CreateFromDiscriminatorValue); } },
                {"WebDataId", n => { WebDataId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("AktivAvsAdresseID", AktivAvsAdresseID);
            writer.WriteIntValue("AktivBrukerID", AktivBrukerID);
            writer.WriteIntValue("AvsAdresseID", AvsAdresseID);
            writer.WriteIntValue("AvsAdresseID2", AvsAdresseID2);
            writer.WriteIntValue("BrukerID", BrukerID);
            writer.WriteObjectValue<Ehfcatalogparameters>("EHFCatalog", EHFCatalog);
            writer.WriteObjectValue<Fakturaparameters>("Faktura", Faktura);
            writer.WriteDateTimeOffsetValue("FomDate", FomDate);
            writer.WriteDateTimeOffsetValue("FomDate2", FomDate2);
            writer.WriteIntValue("FraktID", FraktID);
            writer.WriteDateTimeOffsetValue("Fredagsdato", Fredagsdato);
            writer.WriteObjectValue<Getmulticasereport_GenericSelectionField>("GenericSelectionField", GenericSelectionField);
            writer.WriteStringValue("GeneriskTxt", GeneriskTxt);
            writer.WriteBoolValue("IsPDFReport", IsPDFReport);
            writer.WriteIntValue("KndGrpID", KndGrpID);
            writer.WriteIntValue("KundeID", KundeID);
            writer.WriteStringValue("Kundenavn", Kundenavn);
            writer.WriteIntValue("LagerID", LagerID);
            writer.WriteIntValue("LanguageID", LanguageID);
            writer.WriteIntValue("LeverandID", LeverandID);
            writer.WriteObjectValue<Pricatparameters>("Pricat", Pricat);
            writer.WriteObjectValue<Pricat20parameters>("Pricat20", Pricat20);
            writer.WriteCollectionOfPrimitiveValues<int?>("PrisGruppeIDs", PrisGruppeIDs);
            writer.WriteObjectValue<Productgroupparameters>("ProductGroup", ProductGroup);
            writer.WriteIntValue("ProdusentID", ProdusentID);
            writer.WriteObjectValue<Referanseparameters>("Referanse", Referanse);
            writer.WriteIntValue("ReportID", ReportID);
            writer.WriteDateTimeOffsetValue("TomDate", TomDate);
            writer.WriteDateTimeOffsetValue("TomDate2", TomDate2);
            writer.WriteStringValue("Varenr", Varenr);
            writer.WriteObjectValue<Warehousecorrectionsparameters>("WarehouseCorrections", WarehouseCorrections);
            writer.WriteObjectValue<Warehousecostadjustmentparameters>("WarehouseCostAdjustment", WarehouseCostAdjustment);
            writer.WriteIntValue("WebDataId", WebDataId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
