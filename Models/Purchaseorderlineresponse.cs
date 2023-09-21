using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Purchaseorderlineresponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The LineDataId property</summary>
        public int? LineDataId { get; set; }
        /// <summary>The LinePrice property</summary>
        public double? LinePrice { get; set; }
        /// <summary>The OrderedQuantity property</summary>
        public double? OrderedQuantity { get; set; }
        /// <summary>The ProductDescription property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ProductDescription { get; set; }
#nullable restore
#else
        public List<string> ProductDescription { get; set; }
#endif
        /// <summary>The ProductId property</summary>
        public int? ProductId { get; set; }
        /// <summary>The ProductPartNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductPartNumber { get; set; }
#nullable restore
#else
        public string ProductPartNumber { get; set; }
#endif
        /// <summary>The ProductUnit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductUnit { get; set; }
#nullable restore
#else
        public string ProductUnit { get; set; }
#endif
        /// <summary>The UnitPrice property</summary>
        public double? UnitPrice { get; set; }
        /// <summary>
        /// Instantiates a new purchaseorderlineresponse and sets the default values.
        /// </summary>
        public Purchaseorderlineresponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Purchaseorderlineresponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Purchaseorderlineresponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"LineDataId", n => { LineDataId = n.GetIntValue(); } },
                {"LinePrice", n => { LinePrice = n.GetDoubleValue(); } },
                {"OrderedQuantity", n => { OrderedQuantity = n.GetDoubleValue(); } },
                {"ProductDescription", n => { ProductDescription = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"ProductId", n => { ProductId = n.GetIntValue(); } },
                {"ProductPartNumber", n => { ProductPartNumber = n.GetStringValue(); } },
                {"ProductUnit", n => { ProductUnit = n.GetStringValue(); } },
                {"UnitPrice", n => { UnitPrice = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("LineDataId", LineDataId);
            writer.WriteDoubleValue("LinePrice", LinePrice);
            writer.WriteDoubleValue("OrderedQuantity", OrderedQuantity);
            writer.WriteCollectionOfPrimitiveValues<string>("ProductDescription", ProductDescription);
            writer.WriteIntValue("ProductId", ProductId);
            writer.WriteStringValue("ProductPartNumber", ProductPartNumber);
            writer.WriteStringValue("ProductUnit", ProductUnit);
            writer.WriteDoubleValue("UnitPrice", UnitPrice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
