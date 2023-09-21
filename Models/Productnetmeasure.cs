using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Productnetmeasure : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Height property</summary>
        public double? Height { get; set; }
        /// <summary>The Length property</summary>
        public double? Length { get; set; }
        /// <summary>The Weight property</summary>
        public double? Weight { get; set; }
        /// <summary>The Width property</summary>
        public double? Width { get; set; }
        /// <summary>
        /// Instantiates a new productnetmeasure and sets the default values.
        /// </summary>
        public Productnetmeasure() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Productnetmeasure CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Productnetmeasure();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Height", n => { Height = n.GetDoubleValue(); } },
                {"Length", n => { Length = n.GetDoubleValue(); } },
                {"Weight", n => { Weight = n.GetDoubleValue(); } },
                {"Width", n => { Width = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("Height", Height);
            writer.WriteDoubleValue("Length", Length);
            writer.WriteDoubleValue("Weight", Weight);
            writer.WriteDoubleValue("Width", Width);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
