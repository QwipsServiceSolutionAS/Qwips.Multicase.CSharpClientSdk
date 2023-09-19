using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Pricegroup : IAdditionalDataHolder, IParsable {
        /// <summary>The Active property</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AvgiftID property</summary>
        public int? AvgiftID { get; set; }
        /// <summary>The Description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The PriceGroupID property</summary>
        public int? PriceGroupID { get; set; }
        /// <summary>The ValutaID property</summary>
        public int? ValutaID { get; set; }
        /// <summary>
        /// Instantiates a new pricegroup and sets the default values.
        /// </summary>
        public Pricegroup() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Pricegroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Pricegroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Active", n => { Active = n.GetBoolValue(); } },
                {"AvgiftID", n => { AvgiftID = n.GetIntValue(); } },
                {"Description", n => { Description = n.GetStringValue(); } },
                {"PriceGroupID", n => { PriceGroupID = n.GetIntValue(); } },
                {"ValutaID", n => { ValutaID = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("Active", Active);
            writer.WriteIntValue("AvgiftID", AvgiftID);
            writer.WriteStringValue("Description", Description);
            writer.WriteIntValue("PriceGroupID", PriceGroupID);
            writer.WriteIntValue("ValutaID", ValutaID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
