using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Reportparameters : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The LanguageId property</summary>
        public int? LanguageId { get; set; }
        /// <summary>The RecordId property</summary>
        public int? RecordId { get; set; }
        /// <summary>The ReportTypeId property</summary>
        public int? ReportTypeId { get; set; }
        /// <summary>
        /// Instantiates a new reportparameters and sets the default values.
        /// </summary>
        public Reportparameters() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Reportparameters CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Reportparameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"LanguageId", n => { LanguageId = n.GetIntValue(); } },
                {"RecordId", n => { RecordId = n.GetIntValue(); } },
                {"ReportTypeId", n => { ReportTypeId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("LanguageId", LanguageId);
            writer.WriteIntValue("RecordId", RecordId);
            writer.WriteIntValue("ReportTypeId", ReportTypeId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
