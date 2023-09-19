using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Ordersorderdelivery : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The DeliveryMethod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveryMethod { get; set; }
#nullable restore
#else
        public string DeliveryMethod { get; set; }
#endif
        /// <summary>The FreightID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FreightID { get; set; }
#nullable restore
#else
        public string FreightID { get; set; }
#endif
        /// <summary>The Packages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Packages { get; set; }
#nullable restore
#else
        public string Packages { get; set; }
#endif
        /// <summary>The PackingListID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackingListID { get; set; }
#nullable restore
#else
        public string PackingListID { get; set; }
#endif
        /// <summary>The TrackingNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TrackingNumber { get; set; }
#nullable restore
#else
        public string TrackingNumber { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ordersorderdelivery and sets the default values.
        /// </summary>
        public Ordersorderdelivery() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Ordersorderdelivery CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Ordersorderdelivery();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"DeliveryMethod", n => { DeliveryMethod = n.GetStringValue(); } },
                {"FreightID", n => { FreightID = n.GetStringValue(); } },
                {"Packages", n => { Packages = n.GetStringValue(); } },
                {"PackingListID", n => { PackingListID = n.GetStringValue(); } },
                {"TrackingNumber", n => { TrackingNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("DeliveryMethod", DeliveryMethod);
            writer.WriteStringValue("FreightID", FreightID);
            writer.WriteStringValue("Packages", Packages);
            writer.WriteStringValue("PackingListID", PackingListID);
            writer.WriteStringValue("TrackingNumber", TrackingNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
