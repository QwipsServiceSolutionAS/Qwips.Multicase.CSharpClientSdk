using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Orderstatusresponse_product : IAdditionalDataHolder, IParsable {
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
        /// <summary>The Description1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description1 { get; set; }
#nullable restore
#else
        public string Description1 { get; set; }
#endif
        /// <summary>The Description2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description2 { get; set; }
#nullable restore
#else
        public string Description2 { get; set; }
#endif
        /// <summary>The ItemNo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ItemNo { get; set; }
#nullable restore
#else
        public string ItemNo { get; set; }
#endif
        /// <summary>The ProductID property</summary>
        public int? ProductID { get; set; }
        /// <summary>The ProductWarehouseID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductWarehouseID { get; set; }
#nullable restore
#else
        public string ProductWarehouseID { get; set; }
#endif
        /// <summary>The StructureChild property</summary>
        public bool? StructureChild { get; set; }
        /// <summary>The StructureMother property</summary>
        public bool? StructureMother { get; set; }
        /// <summary>
        /// Instantiates a new orderstatusresponse_product and sets the default values.
        /// </summary>
        public Orderstatusresponse_product() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderstatusresponse_product CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderstatusresponse_product();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AltProductNumber", n => { AltProductNumber = n.GetStringValue(); } },
                {"Description1", n => { Description1 = n.GetStringValue(); } },
                {"Description2", n => { Description2 = n.GetStringValue(); } },
                {"ItemNo", n => { ItemNo = n.GetStringValue(); } },
                {"ProductID", n => { ProductID = n.GetIntValue(); } },
                {"ProductWarehouseID", n => { ProductWarehouseID = n.GetStringValue(); } },
                {"StructureChild", n => { StructureChild = n.GetBoolValue(); } },
                {"StructureMother", n => { StructureMother = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("AltProductNumber", AltProductNumber);
            writer.WriteStringValue("Description1", Description1);
            writer.WriteStringValue("Description2", Description2);
            writer.WriteStringValue("ItemNo", ItemNo);
            writer.WriteIntValue("ProductID", ProductID);
            writer.WriteStringValue("ProductWarehouseID", ProductWarehouseID);
            writer.WriteBoolValue("StructureChild", StructureChild);
            writer.WriteBoolValue("StructureMother", StructureMother);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
