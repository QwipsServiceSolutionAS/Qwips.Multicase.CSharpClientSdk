using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Deliverydays : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Friday property</summary>
        public bool? Friday { get; set; }
        /// <summary>The Monday property</summary>
        public bool? Monday { get; set; }
        /// <summary>The Saturday property</summary>
        public bool? Saturday { get; set; }
        /// <summary>The Sunday property</summary>
        public bool? Sunday { get; set; }
        /// <summary>The Thursday property</summary>
        public bool? Thursday { get; set; }
        /// <summary>The Tuesday property</summary>
        public bool? Tuesday { get; set; }
        /// <summary>The Wednesday property</summary>
        public bool? Wednesday { get; set; }
        /// <summary>
        /// Instantiates a new deliverydays and sets the default values.
        /// </summary>
        public Deliverydays() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Deliverydays CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Deliverydays();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Friday", n => { Friday = n.GetBoolValue(); } },
                {"Monday", n => { Monday = n.GetBoolValue(); } },
                {"Saturday", n => { Saturday = n.GetBoolValue(); } },
                {"Sunday", n => { Sunday = n.GetBoolValue(); } },
                {"Thursday", n => { Thursday = n.GetBoolValue(); } },
                {"Tuesday", n => { Tuesday = n.GetBoolValue(); } },
                {"Wednesday", n => { Wednesday = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("Friday", Friday);
            writer.WriteBoolValue("Monday", Monday);
            writer.WriteBoolValue("Saturday", Saturday);
            writer.WriteBoolValue("Sunday", Sunday);
            writer.WriteBoolValue("Thursday", Thursday);
            writer.WriteBoolValue("Tuesday", Tuesday);
            writer.WriteBoolValue("Wednesday", Wednesday);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
