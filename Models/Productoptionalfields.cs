using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Productoptionalfields : IAdditionalDataHolder, IParsable {
        /// <summary>The ABCStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ABCStatus { get; set; }
#nullable restore
#else
        public string ABCStatus { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AdditionalSuppliers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Productsupplier>? AdditionalSuppliers { get; set; }
#nullable restore
#else
        public List<Productsupplier> AdditionalSuppliers { get; set; }
#endif
        /// <summary>The AltProductNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AltProductNumber { get; set; }
#nullable restore
#else
        public string AltProductNumber { get; set; }
#endif
        /// <summary>The BrutMeasures property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Productbrutmeasure? BrutMeasures { get; set; }
#nullable restore
#else
        public Productbrutmeasure BrutMeasures { get; set; }
#endif
        /// <summary>The CostCurrency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CostCurrency { get; set; }
#nullable restore
#else
        public string CostCurrency { get; set; }
#endif
        /// <summary>The CountryOfOrigin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryOfOrigin { get; set; }
#nullable restore
#else
        public string CountryOfOrigin { get; set; }
#endif
        /// <summary>The CreatedByUser property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedByUser { get; set; }
#nullable restore
#else
        public string CreatedByUser { get; set; }
#endif
        /// <summary>The CustomsPercent property</summary>
        public double? CustomsPercent { get; set; }
        /// <summary>The DeliveryTime property</summary>
        public int? DeliveryTime { get; set; }
        /// <summary>The DoApprove property</summary>
        public bool? DoApprove { get; set; }
        /// <summary>The EANNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EANNumber { get; set; }
#nullable restore
#else
        public string EANNumber { get; set; }
#endif
        /// <summary>The FreightPercent property</summary>
        public double? FreightPercent { get; set; }
        /// <summary>The LinkToAllSenders property</summary>
        public bool? LinkToAllSenders { get; set; }
        /// <summary>The ListPrice1 property</summary>
        public double? ListPrice1 { get; set; }
        /// <summary>The ListPrice2 property</summary>
        public double? ListPrice2 { get; set; }
        /// <summary>The ListPrice3 property</summary>
        public double? ListPrice3 { get; set; }
        /// <summary>The MainResponsibleUser2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MainResponsibleUser2 { get; set; }
#nullable restore
#else
        public string MainResponsibleUser2 { get; set; }
#endif
        /// <summary>The Manufacturer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer { get; set; }
#nullable restore
#else
        public string Manufacturer { get; set; }
#endif
        /// <summary>The MaximumStock property</summary>
        public double? MaximumStock { get; set; }
        /// <summary>The MinimumStock property</summary>
        public double? MinimumStock { get; set; }
        /// <summary>The MotherChildLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MotherChildLink { get; set; }
#nullable restore
#else
        public string MotherChildLink { get; set; }
#endif
        /// <summary>The NetMeasures property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Productnetmeasure? NetMeasures { get; set; }
#nullable restore
#else
        public Productnetmeasure NetMeasures { get; set; }
#endif
        /// <summary>The NumberOfCollies property</summary>
        public double? NumberOfCollies { get; set; }
        /// <summary>The PictureFileName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PictureFileName { get; set; }
#nullable restore
#else
        public string PictureFileName { get; set; }
#endif
        /// <summary>The ProductDescription2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductDescription2 { get; set; }
#nullable restore
#else
        public string ProductDescription2 { get; set; }
#endif
        /// <summary>The ProductInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductInfo { get; set; }
#nullable restore
#else
        public string ProductInfo { get; set; }
#endif
        /// <summary>The ProductNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductNumber { get; set; }
#nullable restore
#else
        public string ProductNumber { get; set; }
#endif
        /// <summary>The ProductType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductType { get; set; }
#nullable restore
#else
        public string ProductType { get; set; }
#endif
        /// <summary>The SetBatchControl property</summary>
        public bool? SetBatchControl { get; set; }
        /// <summary>The SetWebActive property</summary>
        public bool? SetWebActive { get; set; }
        /// <summary>The ShelfLifeDays property</summary>
        public int? ShelfLifeDays { get; set; }
        /// <summary>The StockStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StockStatus { get; set; }
#nullable restore
#else
        public string StockStatus { get; set; }
#endif
        /// <summary>The SupplierProductNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupplierProductNumber { get; set; }
#nullable restore
#else
        public string SupplierProductNumber { get; set; }
#endif
        /// <summary>The TemplateProductNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TemplateProductNumber { get; set; }
#nullable restore
#else
        public string TemplateProductNumber { get; set; }
#endif
        /// <summary>The UnitsPerSale property</summary>
        public double? UnitsPerSale { get; set; }
        /// <summary>The Variant1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Variant1 { get; set; }
#nullable restore
#else
        public string Variant1 { get; set; }
#endif
        /// <summary>The Variant2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Variant2 { get; set; }
#nullable restore
#else
        public string Variant2 { get; set; }
#endif
        /// <summary>The VariantValue1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VariantValue1 { get; set; }
#nullable restore
#else
        public string VariantValue1 { get; set; }
#endif
        /// <summary>The VariantValue2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VariantValue2 { get; set; }
#nullable restore
#else
        public string VariantValue2 { get; set; }
#endif
        /// <summary>The WareHouse property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WareHouse { get; set; }
#nullable restore
#else
        public string WareHouse { get; set; }
#endif
        /// <summary>
        /// Instantiates a new productoptionalfields and sets the default values.
        /// </summary>
        public Productoptionalfields() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Productoptionalfields CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Productoptionalfields();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ABCStatus", n => { ABCStatus = n.GetStringValue(); } },
                {"AdditionalSuppliers", n => { AdditionalSuppliers = n.GetCollectionOfObjectValues<Productsupplier>(Productsupplier.CreateFromDiscriminatorValue)?.ToList(); } },
                {"AltProductNumber", n => { AltProductNumber = n.GetStringValue(); } },
                {"BrutMeasures", n => { BrutMeasures = n.GetObjectValue<Productbrutmeasure>(Productbrutmeasure.CreateFromDiscriminatorValue); } },
                {"CostCurrency", n => { CostCurrency = n.GetStringValue(); } },
                {"CountryOfOrigin", n => { CountryOfOrigin = n.GetStringValue(); } },
                {"CreatedByUser", n => { CreatedByUser = n.GetStringValue(); } },
                {"CustomsPercent", n => { CustomsPercent = n.GetDoubleValue(); } },
                {"DeliveryTime", n => { DeliveryTime = n.GetIntValue(); } },
                {"DoApprove", n => { DoApprove = n.GetBoolValue(); } },
                {"EANNumber", n => { EANNumber = n.GetStringValue(); } },
                {"FreightPercent", n => { FreightPercent = n.GetDoubleValue(); } },
                {"LinkToAllSenders", n => { LinkToAllSenders = n.GetBoolValue(); } },
                {"ListPrice1", n => { ListPrice1 = n.GetDoubleValue(); } },
                {"ListPrice2", n => { ListPrice2 = n.GetDoubleValue(); } },
                {"ListPrice3", n => { ListPrice3 = n.GetDoubleValue(); } },
                {"MainResponsibleUser2", n => { MainResponsibleUser2 = n.GetStringValue(); } },
                {"Manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"MaximumStock", n => { MaximumStock = n.GetDoubleValue(); } },
                {"MinimumStock", n => { MinimumStock = n.GetDoubleValue(); } },
                {"MotherChildLink", n => { MotherChildLink = n.GetStringValue(); } },
                {"NetMeasures", n => { NetMeasures = n.GetObjectValue<Productnetmeasure>(Productnetmeasure.CreateFromDiscriminatorValue); } },
                {"NumberOfCollies", n => { NumberOfCollies = n.GetDoubleValue(); } },
                {"PictureFileName", n => { PictureFileName = n.GetStringValue(); } },
                {"ProductDescription2", n => { ProductDescription2 = n.GetStringValue(); } },
                {"ProductInfo", n => { ProductInfo = n.GetStringValue(); } },
                {"ProductNumber", n => { ProductNumber = n.GetStringValue(); } },
                {"ProductType", n => { ProductType = n.GetStringValue(); } },
                {"SetBatchControl", n => { SetBatchControl = n.GetBoolValue(); } },
                {"SetWebActive", n => { SetWebActive = n.GetBoolValue(); } },
                {"ShelfLifeDays", n => { ShelfLifeDays = n.GetIntValue(); } },
                {"StockStatus", n => { StockStatus = n.GetStringValue(); } },
                {"SupplierProductNumber", n => { SupplierProductNumber = n.GetStringValue(); } },
                {"TemplateProductNumber", n => { TemplateProductNumber = n.GetStringValue(); } },
                {"UnitsPerSale", n => { UnitsPerSale = n.GetDoubleValue(); } },
                {"Variant1", n => { Variant1 = n.GetStringValue(); } },
                {"Variant2", n => { Variant2 = n.GetStringValue(); } },
                {"VariantValue1", n => { VariantValue1 = n.GetStringValue(); } },
                {"VariantValue2", n => { VariantValue2 = n.GetStringValue(); } },
                {"WareHouse", n => { WareHouse = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ABCStatus", ABCStatus);
            writer.WriteCollectionOfObjectValues<Productsupplier>("AdditionalSuppliers", AdditionalSuppliers);
            writer.WriteStringValue("AltProductNumber", AltProductNumber);
            writer.WriteObjectValue<Productbrutmeasure>("BrutMeasures", BrutMeasures);
            writer.WriteStringValue("CostCurrency", CostCurrency);
            writer.WriteStringValue("CountryOfOrigin", CountryOfOrigin);
            writer.WriteStringValue("CreatedByUser", CreatedByUser);
            writer.WriteDoubleValue("CustomsPercent", CustomsPercent);
            writer.WriteIntValue("DeliveryTime", DeliveryTime);
            writer.WriteBoolValue("DoApprove", DoApprove);
            writer.WriteStringValue("EANNumber", EANNumber);
            writer.WriteDoubleValue("FreightPercent", FreightPercent);
            writer.WriteBoolValue("LinkToAllSenders", LinkToAllSenders);
            writer.WriteDoubleValue("ListPrice1", ListPrice1);
            writer.WriteDoubleValue("ListPrice2", ListPrice2);
            writer.WriteDoubleValue("ListPrice3", ListPrice3);
            writer.WriteStringValue("MainResponsibleUser2", MainResponsibleUser2);
            writer.WriteStringValue("Manufacturer", Manufacturer);
            writer.WriteDoubleValue("MaximumStock", MaximumStock);
            writer.WriteDoubleValue("MinimumStock", MinimumStock);
            writer.WriteStringValue("MotherChildLink", MotherChildLink);
            writer.WriteObjectValue<Productnetmeasure>("NetMeasures", NetMeasures);
            writer.WriteDoubleValue("NumberOfCollies", NumberOfCollies);
            writer.WriteStringValue("PictureFileName", PictureFileName);
            writer.WriteStringValue("ProductDescription2", ProductDescription2);
            writer.WriteStringValue("ProductInfo", ProductInfo);
            writer.WriteStringValue("ProductNumber", ProductNumber);
            writer.WriteStringValue("ProductType", ProductType);
            writer.WriteBoolValue("SetBatchControl", SetBatchControl);
            writer.WriteBoolValue("SetWebActive", SetWebActive);
            writer.WriteIntValue("ShelfLifeDays", ShelfLifeDays);
            writer.WriteStringValue("StockStatus", StockStatus);
            writer.WriteStringValue("SupplierProductNumber", SupplierProductNumber);
            writer.WriteStringValue("TemplateProductNumber", TemplateProductNumber);
            writer.WriteDoubleValue("UnitsPerSale", UnitsPerSale);
            writer.WriteStringValue("Variant1", Variant1);
            writer.WriteStringValue("Variant2", Variant2);
            writer.WriteStringValue("VariantValue1", VariantValue1);
            writer.WriteStringValue("VariantValue2", VariantValue2);
            writer.WriteStringValue("WareHouse", WareHouse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
