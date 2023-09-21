using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Generalapierror : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Error property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Error { get; set; }
#nullable restore
#else
        public string Error { get; set; }
#endif
        /// <summary>The ErrorCode property</summary>
        public int? ErrorCode { get; set; }
        /// <summary>The ErrorLine property</summary>
        public int? ErrorLine { get; set; }
        /// <summary>
        /// Instantiates a new generalapierror and sets the default values.
        /// </summary>
        public Generalapierror() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Generalapierror CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Generalapierror();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Error", n => { Error = n.GetStringValue(); } },
                {"ErrorCode", n => { ErrorCode = n.GetIntValue(); } },
                {"ErrorLine", n => { ErrorLine = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Error", Error);
            writer.WriteIntValue("ErrorCode", ErrorCode);
            writer.WriteIntValue("ErrorLine", ErrorLine);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
