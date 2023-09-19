using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Createproductimage : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The FileName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName { get; set; }
#nullable restore
#else
        public string FileName { get; set; }
#endif
        /// <summary>The Image property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? Image { get; set; }
#nullable restore
#else
        public List<int?> Image { get; set; }
#endif
        /// <summary>The ProductId property</summary>
        public int? ProductId { get; set; }
        /// <summary>The UpdatedByUserId property</summary>
        public int? UpdatedByUserId { get; set; }
        /// <summary>
        /// Instantiates a new Createproductimage and sets the default values.
        /// </summary>
        public Createproductimage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Createproductimage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Createproductimage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"FileName", n => { FileName = n.GetStringValue(); } },
                {"Image", n => { Image = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                {"ProductId", n => { ProductId = n.GetIntValue(); } },
                {"UpdatedByUserId", n => { UpdatedByUserId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("FileName", FileName);
            writer.WriteCollectionOfPrimitiveValues<int?>("Image", Image);
            writer.WriteIntValue("ProductId", ProductId);
            writer.WriteIntValue("UpdatedByUserId", UpdatedByUserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
