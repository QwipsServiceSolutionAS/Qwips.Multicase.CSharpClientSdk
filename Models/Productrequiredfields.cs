using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Productrequiredfields : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The MainResponsibleUser property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MainResponsibleUser { get; set; }
#nullable restore
#else
        public string MainResponsibleUser { get; set; }
#endif
        /// <summary>The ProductDescription1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductDescription1 { get; set; }
#nullable restore
#else
        public string ProductDescription1 { get; set; }
#endif
        /// <summary>The ProductGroup1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductGroup1 { get; set; }
#nullable restore
#else
        public string ProductGroup1 { get; set; }
#endif
        /// <summary>The ProductGroup2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductGroup2 { get; set; }
#nullable restore
#else
        public string ProductGroup2 { get; set; }
#endif
        /// <summary>The ProductGroup3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductGroup3 { get; set; }
#nullable restore
#else
        public string ProductGroup3 { get; set; }
#endif
        /// <summary>The SenderName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderName { get; set; }
#nullable restore
#else
        public string SenderName { get; set; }
#endif
        /// <summary>The SupplierCostPrice property</summary>
        public double? SupplierCostPrice { get; set; }
        /// <summary>The SupplierCustomerNumber property</summary>
        public int? SupplierCustomerNumber { get; set; }
        /// <summary>The Unit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Unit { get; set; }
#nullable restore
#else
        public string Unit { get; set; }
#endif
        /// <summary>
        /// Instantiates a new productrequiredfields and sets the default values.
        /// </summary>
        public Productrequiredfields() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Productrequiredfields CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Productrequiredfields();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"MainResponsibleUser", n => { MainResponsibleUser = n.GetStringValue(); } },
                {"ProductDescription1", n => { ProductDescription1 = n.GetStringValue(); } },
                {"ProductGroup1", n => { ProductGroup1 = n.GetStringValue(); } },
                {"ProductGroup2", n => { ProductGroup2 = n.GetStringValue(); } },
                {"ProductGroup3", n => { ProductGroup3 = n.GetStringValue(); } },
                {"SenderName", n => { SenderName = n.GetStringValue(); } },
                {"SupplierCostPrice", n => { SupplierCostPrice = n.GetDoubleValue(); } },
                {"SupplierCustomerNumber", n => { SupplierCustomerNumber = n.GetIntValue(); } },
                {"Unit", n => { Unit = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("MainResponsibleUser", MainResponsibleUser);
            writer.WriteStringValue("ProductDescription1", ProductDescription1);
            writer.WriteStringValue("ProductGroup1", ProductGroup1);
            writer.WriteStringValue("ProductGroup2", ProductGroup2);
            writer.WriteStringValue("ProductGroup3", ProductGroup3);
            writer.WriteStringValue("SenderName", SenderName);
            writer.WriteDoubleValue("SupplierCostPrice", SupplierCostPrice);
            writer.WriteIntValue("SupplierCustomerNumber", SupplierCustomerNumber);
            writer.WriteStringValue("Unit", Unit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
