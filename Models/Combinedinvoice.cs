using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Combinedinvoice : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Combine property</summary>
        public bool? Combine { get; set; }
        /// <summary>The CombineInvoiceOnNextRun property</summary>
        public bool? CombineInvoiceOnNextRun { get; set; }
        /// <summary>The FollowUpDate property</summary>
        public DateTimeOffset? FollowUpDate { get; set; }
        /// <summary>
        /// Instantiates a new combinedinvoice and sets the default values.
        /// </summary>
        public Combinedinvoice() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Combinedinvoice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Combinedinvoice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Combine", n => { Combine = n.GetBoolValue(); } },
                {"CombineInvoiceOnNextRun", n => { CombineInvoiceOnNextRun = n.GetBoolValue(); } },
                {"FollowUpDate", n => { FollowUpDate = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("Combine", Combine);
            writer.WriteBoolValue("CombineInvoiceOnNextRun", CombineInvoiceOnNextRun);
            writer.WriteDateTimeOffsetValue("FollowUpDate", FollowUpDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
