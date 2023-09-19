using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Orderlineextra : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Extra1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Extra1 { get; set; }
#nullable restore
#else
        public string Extra1 { get; set; }
#endif
        /// <summary>The Extra2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Extra2 { get; set; }
#nullable restore
#else
        public string Extra2 { get; set; }
#endif
        /// <summary>The Extra3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Extra3 { get; set; }
#nullable restore
#else
        public string Extra3 { get; set; }
#endif
        /// <summary>The Extra4 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Extra4 { get; set; }
#nullable restore
#else
        public string Extra4 { get; set; }
#endif
        /// <summary>
        /// Instantiates a new orderlineextra and sets the default values.
        /// </summary>
        public Orderlineextra() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderlineextra CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderlineextra();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Extra1", n => { Extra1 = n.GetStringValue(); } },
                {"Extra2", n => { Extra2 = n.GetStringValue(); } },
                {"Extra3", n => { Extra3 = n.GetStringValue(); } },
                {"Extra4", n => { Extra4 = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Extra1", Extra1);
            writer.WriteStringValue("Extra2", Extra2);
            writer.WriteStringValue("Extra3", Extra3);
            writer.WriteStringValue("Extra4", Extra4);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
