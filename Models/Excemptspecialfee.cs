using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Excemptspecialfee : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The InvoiceCharge property</summary>
        public bool? InvoiceCharge { get; set; }
        /// <summary>The OrderCharge property</summary>
        public bool? OrderCharge { get; set; }
        /// <summary>The ReminderCharge property</summary>
        public bool? ReminderCharge { get; set; }
        /// <summary>The ReturnCharge property</summary>
        public bool? ReturnCharge { get; set; }
        /// <summary>
        /// Instantiates a new excemptspecialfee and sets the default values.
        /// </summary>
        public Excemptspecialfee() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Excemptspecialfee CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Excemptspecialfee();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"InvoiceCharge", n => { InvoiceCharge = n.GetBoolValue(); } },
                {"OrderCharge", n => { OrderCharge = n.GetBoolValue(); } },
                {"ReminderCharge", n => { ReminderCharge = n.GetBoolValue(); } },
                {"ReturnCharge", n => { ReturnCharge = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("InvoiceCharge", InvoiceCharge);
            writer.WriteBoolValue("OrderCharge", OrderCharge);
            writer.WriteBoolValue("ReminderCharge", ReminderCharge);
            writer.WriteBoolValue("ReturnCharge", ReturnCharge);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
