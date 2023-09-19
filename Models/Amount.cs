using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Amount : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Currency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Currency? Currency { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Currency Currency { get; set; }
#endif
        /// <summary>The Sum property</summary>
        public double? Sum { get; set; }
        /// <summary>
        /// Instantiates a new amount and sets the default values.
        /// </summary>
        public Amount() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Amount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Amount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Currency", n => { Currency = n.GetObjectValue<Qwips.Core.MultiCase.Models.Currency>(Qwips.Core.MultiCase.Models.Currency.CreateFromDiscriminatorValue); } },
                {"Sum", n => { Sum = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Currency>("Currency", Currency);
            writer.WriteDoubleValue("Sum", Sum);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
