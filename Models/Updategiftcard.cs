using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Updategiftcard : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Giftcard property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Giftcard? Giftcard { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Giftcard Giftcard { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Updategiftcard and sets the default values.
        /// </summary>
        public Updategiftcard() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Updategiftcard CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Updategiftcard();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Giftcard", n => { Giftcard = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Giftcard>(Qwips.Core.ClientSdk.Multicase.Models.Giftcard.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Giftcard>("Giftcard", Giftcard);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
