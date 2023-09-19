using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Report : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Document property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? Document { get; set; }
#nullable restore
#else
        public List<int?> Document { get; set; }
#endif
        /// <summary>The DocumentName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DocumentName { get; set; }
#nullable restore
#else
        public string DocumentName { get; set; }
#endif
        /// <summary>The DocumentType property</summary>
        public Documenttypeenum1? DocumentType { get; set; }
        /// <summary>
        /// Instantiates a new Report and sets the default values.
        /// </summary>
        public Report() {
            AdditionalData = new Dictionary<string, object>();
            DocumentType = Documenttypeenum1.PDF;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Report CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Report();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Document", n => { Document = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                {"DocumentName", n => { DocumentName = n.GetStringValue(); } },
                {"DocumentType", n => { DocumentType = n.GetEnumValue<Documenttypeenum1>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<int?>("Document", Document);
            writer.WriteStringValue("DocumentName", DocumentName);
            writer.WriteEnumValue<Documenttypeenum1>("DocumentType", DocumentType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
