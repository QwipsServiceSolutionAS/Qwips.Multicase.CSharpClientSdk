using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Postaladdress : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Line1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Line1 { get; set; }
#nullable restore
#else
        public string Line1 { get; set; }
#endif
        /// <summary>The Line2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Line2 { get; set; }
#nullable restore
#else
        public string Line2 { get; set; }
#endif
        /// <summary>The Postal property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Postalarea? Postal { get; set; }
#nullable restore
#else
        public Postalarea Postal { get; set; }
#endif
        /// <summary>The PostBox property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostBox { get; set; }
#nullable restore
#else
        public string PostBox { get; set; }
#endif
        /// <summary>
        /// Instantiates a new postaladdress and sets the default values.
        /// </summary>
        public Postaladdress() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Postaladdress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Postaladdress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Line1", n => { Line1 = n.GetStringValue(); } },
                {"Line2", n => { Line2 = n.GetStringValue(); } },
                {"Postal", n => { Postal = n.GetObjectValue<Postalarea>(Postalarea.CreateFromDiscriminatorValue); } },
                {"PostBox", n => { PostBox = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Line1", Line1);
            writer.WriteStringValue("Line2", Line2);
            writer.WriteObjectValue<Postalarea>("Postal", Postal);
            writer.WriteStringValue("PostBox", PostBox);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
