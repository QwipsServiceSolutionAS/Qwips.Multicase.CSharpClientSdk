using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Warehousecostadjustmentparameters : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Excel property</summary>
        public bool? Excel { get; set; }
        /// <summary>The FomDato property</summary>
        public DateTimeOffset? FomDato { get; set; }
        /// <summary>The LagerGeoNavnID property</summary>
        public int? LagerGeoNavnID { get; set; }
        /// <summary>The ProductDescription property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductDescription { get; set; }
#nullable restore
#else
        public string ProductDescription { get; set; }
#endif
        /// <summary>The TomDato property</summary>
        public DateTimeOffset? TomDato { get; set; }
        /// <summary>The Varenr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Varenr { get; set; }
#nullable restore
#else
        public string Varenr { get; set; }
#endif
        /// <summary>
        /// Instantiates a new warehousecostadjustmentparameters and sets the default values.
        /// </summary>
        public Warehousecostadjustmentparameters() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Warehousecostadjustmentparameters CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Warehousecostadjustmentparameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Excel", n => { Excel = n.GetBoolValue(); } },
                {"FomDato", n => { FomDato = n.GetDateTimeOffsetValue(); } },
                {"LagerGeoNavnID", n => { LagerGeoNavnID = n.GetIntValue(); } },
                {"ProductDescription", n => { ProductDescription = n.GetStringValue(); } },
                {"TomDato", n => { TomDato = n.GetDateTimeOffsetValue(); } },
                {"Varenr", n => { Varenr = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("Excel", Excel);
            writer.WriteDateTimeOffsetValue("FomDato", FomDato);
            writer.WriteIntValue("LagerGeoNavnID", LagerGeoNavnID);
            writer.WriteStringValue("ProductDescription", ProductDescription);
            writer.WriteDateTimeOffsetValue("TomDato", TomDato);
            writer.WriteStringValue("Varenr", Varenr);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
