using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Bundle : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The BundleId property</summary>
        public int? BundleId { get; set; }
        /// <summary>The Lines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Lines? Lines { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Lines Lines { get; set; }
#endif
        /// <summary>The Processed property</summary>
        public bool? Processed { get; set; }
        /// <summary>
        /// Instantiates a new bundle and sets the default values.
        /// </summary>
        public Bundle() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Bundle CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Bundle();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"BundleId", n => { BundleId = n.GetIntValue(); } },
                {"Lines", n => { Lines = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Lines>(Qwips.Core.ClientSdk.Multicase.Models.Lines.CreateFromDiscriminatorValue); } },
                {"Processed", n => { Processed = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("BundleId", BundleId);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Lines>("Lines", Lines);
            writer.WriteBoolValue("Processed", Processed);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
