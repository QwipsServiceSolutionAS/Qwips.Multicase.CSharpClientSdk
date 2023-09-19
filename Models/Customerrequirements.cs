using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Customerrequirements : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OrderNumber property</summary>
        public bool? OrderNumber { get; set; }
        /// <summary>The PredefinedContactsOnly property</summary>
        public bool? PredefinedContactsOnly { get; set; }
        /// <summary>The SyncWithSuperOffice property</summary>
        public bool? SyncWithSuperOffice { get; set; }
        /// <summary>
        /// Instantiates a new customerrequirements and sets the default values.
        /// </summary>
        public Customerrequirements() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Customerrequirements CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Customerrequirements();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"OrderNumber", n => { OrderNumber = n.GetBoolValue(); } },
                {"PredefinedContactsOnly", n => { PredefinedContactsOnly = n.GetBoolValue(); } },
                {"SyncWithSuperOffice", n => { SyncWithSuperOffice = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("OrderNumber", OrderNumber);
            writer.WriteBoolValue("PredefinedContactsOnly", PredefinedContactsOnly);
            writer.WriteBoolValue("SyncWithSuperOffice", SyncWithSuperOffice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
