using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Productresponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AltProductNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AltProductNumber { get; set; }
#nullable restore
#else
        public string AltProductNumber { get; set; }
#endif
        /// <summary>The ChildrenIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? ChildrenIds { get; set; }
#nullable restore
#else
        public List<int?> ChildrenIds { get; set; }
#endif
        /// <summary>The Description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The Description2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description2 { get; set; }
#nullable restore
#else
        public string Description2 { get; set; }
#endif
        /// <summary>The Ean property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ean { get; set; }
#nullable restore
#else
        public string Ean { get; set; }
#endif
        /// <summary>The EanText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EanText { get; set; }
#nullable restore
#else
        public string EanText { get; set; }
#endif
        /// <summary>The IsVariantMother property</summary>
        public bool? IsVariantMother { get; set; }
        /// <summary>The Level1Group property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Level1Group { get; set; }
#nullable restore
#else
        public string Level1Group { get; set; }
#endif
        /// <summary>The Level2Group property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Level2Group { get; set; }
#nullable restore
#else
        public string Level2Group { get; set; }
#endif
        /// <summary>The Level3Group property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Level3Group { get; set; }
#nullable restore
#else
        public string Level3Group { get; set; }
#endif
        /// <summary>The PictureFilePath property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PictureFilePath { get; set; }
#nullable restore
#else
        public string PictureFilePath { get; set; }
#endif
        /// <summary>The ProductId property</summary>
        public int? ProductId { get; set; }
        /// <summary>The ProductInfo1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductInfo1 { get; set; }
#nullable restore
#else
        public string ProductInfo1 { get; set; }
#endif
        /// <summary>The ProductInfo2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductInfo2 { get; set; }
#nullable restore
#else
        public string ProductInfo2 { get; set; }
#endif
        /// <summary>The ProductInfo3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductInfo3 { get; set; }
#nullable restore
#else
        public string ProductInfo3 { get; set; }
#endif
        /// <summary>The ProductNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductNumber { get; set; }
#nullable restore
#else
        public string ProductNumber { get; set; }
#endif
        /// <summary>The ProductResponsible1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductResponsible1 { get; set; }
#nullable restore
#else
        public string ProductResponsible1 { get; set; }
#endif
        /// <summary>The ProductResponsible2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductResponsible2 { get; set; }
#nullable restore
#else
        public string ProductResponsible2 { get; set; }
#endif
        /// <summary>The ProductType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductType { get; set; }
#nullable restore
#else
        public string ProductType { get; set; }
#endif
        /// <summary>The RegDate property</summary>
        public DateTimeOffset? RegDate { get; set; }
        /// <summary>The Supplier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Supplier { get; set; }
#nullable restore
#else
        public string Supplier { get; set; }
#endif
        /// <summary>The Unit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Unit { get; set; }
#nullable restore
#else
        public string Unit { get; set; }
#endif
        /// <summary>The UnitsPerPackage property</summary>
        public double? UnitsPerPackage { get; set; }
        /// <summary>
        /// Instantiates a new productresponse and sets the default values.
        /// </summary>
        public Productresponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Productresponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Productresponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AltProductNumber", n => { AltProductNumber = n.GetStringValue(); } },
                {"ChildrenIds", n => { ChildrenIds = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                {"Description", n => { Description = n.GetStringValue(); } },
                {"Description2", n => { Description2 = n.GetStringValue(); } },
                {"Ean", n => { Ean = n.GetStringValue(); } },
                {"EanText", n => { EanText = n.GetStringValue(); } },
                {"IsVariantMother", n => { IsVariantMother = n.GetBoolValue(); } },
                {"Level1Group", n => { Level1Group = n.GetStringValue(); } },
                {"Level2Group", n => { Level2Group = n.GetStringValue(); } },
                {"Level3Group", n => { Level3Group = n.GetStringValue(); } },
                {"PictureFilePath", n => { PictureFilePath = n.GetStringValue(); } },
                {"ProductId", n => { ProductId = n.GetIntValue(); } },
                {"ProductInfo1", n => { ProductInfo1 = n.GetStringValue(); } },
                {"ProductInfo2", n => { ProductInfo2 = n.GetStringValue(); } },
                {"ProductInfo3", n => { ProductInfo3 = n.GetStringValue(); } },
                {"ProductNumber", n => { ProductNumber = n.GetStringValue(); } },
                {"ProductResponsible1", n => { ProductResponsible1 = n.GetStringValue(); } },
                {"ProductResponsible2", n => { ProductResponsible2 = n.GetStringValue(); } },
                {"ProductType", n => { ProductType = n.GetStringValue(); } },
                {"RegDate", n => { RegDate = n.GetDateTimeOffsetValue(); } },
                {"Supplier", n => { Supplier = n.GetStringValue(); } },
                {"Unit", n => { Unit = n.GetStringValue(); } },
                {"UnitsPerPackage", n => { UnitsPerPackage = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("AltProductNumber", AltProductNumber);
            writer.WriteCollectionOfPrimitiveValues<int?>("ChildrenIds", ChildrenIds);
            writer.WriteStringValue("Description", Description);
            writer.WriteStringValue("Description2", Description2);
            writer.WriteStringValue("Ean", Ean);
            writer.WriteStringValue("EanText", EanText);
            writer.WriteBoolValue("IsVariantMother", IsVariantMother);
            writer.WriteStringValue("Level1Group", Level1Group);
            writer.WriteStringValue("Level2Group", Level2Group);
            writer.WriteStringValue("Level3Group", Level3Group);
            writer.WriteStringValue("PictureFilePath", PictureFilePath);
            writer.WriteIntValue("ProductId", ProductId);
            writer.WriteStringValue("ProductInfo1", ProductInfo1);
            writer.WriteStringValue("ProductInfo2", ProductInfo2);
            writer.WriteStringValue("ProductInfo3", ProductInfo3);
            writer.WriteStringValue("ProductNumber", ProductNumber);
            writer.WriteStringValue("ProductResponsible1", ProductResponsible1);
            writer.WriteStringValue("ProductResponsible2", ProductResponsible2);
            writer.WriteStringValue("ProductType", ProductType);
            writer.WriteDateTimeOffsetValue("RegDate", RegDate);
            writer.WriteStringValue("Supplier", Supplier);
            writer.WriteStringValue("Unit", Unit);
            writer.WriteDoubleValue("UnitsPerPackage", UnitsPerPackage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
