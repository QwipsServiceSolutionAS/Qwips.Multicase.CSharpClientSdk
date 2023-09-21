using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Productsupplier : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CostCurrency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CostCurrency { get; set; }
#nullable restore
#else
        public string CostCurrency { get; set; }
#endif
        /// <summary>The SupplierCostPrice property</summary>
        public double? SupplierCostPrice { get; set; }
        /// <summary>The SupplierNumber property</summary>
        public int? SupplierNumber { get; set; }
        /// <summary>The SupplierProductNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupplierProductNumber { get; set; }
#nullable restore
#else
        public string SupplierProductNumber { get; set; }
#endif
        /// <summary>
        /// Instantiates a new productsupplier and sets the default values.
        /// </summary>
        public Productsupplier() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Productsupplier CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Productsupplier();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CostCurrency", n => { CostCurrency = n.GetStringValue(); } },
                {"SupplierCostPrice", n => { SupplierCostPrice = n.GetDoubleValue(); } },
                {"SupplierNumber", n => { SupplierNumber = n.GetIntValue(); } },
                {"SupplierProductNumber", n => { SupplierProductNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("CostCurrency", CostCurrency);
            writer.WriteDoubleValue("SupplierCostPrice", SupplierCostPrice);
            writer.WriteIntValue("SupplierNumber", SupplierNumber);
            writer.WriteStringValue("SupplierProductNumber", SupplierProductNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
