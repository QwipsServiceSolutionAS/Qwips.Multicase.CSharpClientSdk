using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Purchaseline : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Pos property</summary>
        public int? Pos { get; set; }
        /// <summary>The QuantityDelivered property</summary>
        public double? QuantityDelivered { get; set; }
        /// <summary>The SerialNumbers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Serialnumbers? SerialNumbers { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Serialnumbers SerialNumbers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new purchaseline and sets the default values.
        /// </summary>
        public Purchaseline() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Purchaseline CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Purchaseline();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Pos", n => { Pos = n.GetIntValue(); } },
                {"QuantityDelivered", n => { QuantityDelivered = n.GetDoubleValue(); } },
                {"SerialNumbers", n => { SerialNumbers = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Serialnumbers>(Qwips.Core.ClientSdk.Multicase.Models.Serialnumbers.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("Pos", Pos);
            writer.WriteDoubleValue("QuantityDelivered", QuantityDelivered);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Serialnumbers>("SerialNumbers", SerialNumbers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
