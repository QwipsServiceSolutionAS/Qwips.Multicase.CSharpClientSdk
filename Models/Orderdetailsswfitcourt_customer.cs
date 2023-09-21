using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Orderdetailsswfitcourt_customer : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CustomerEmail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerEmail { get; set; }
#nullable restore
#else
        public string CustomerEmail { get; set; }
#endif
        /// <summary>The CustomerNumber property</summary>
        public int? CustomerNumber { get; set; }
        /// <summary>The CustomerPhoneNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerPhoneNumber { get; set; }
#nullable restore
#else
        public string CustomerPhoneNumber { get; set; }
#endif
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Instantiates a new orderdetailsswfitcourt_customer and sets the default values.
        /// </summary>
        public Orderdetailsswfitcourt_customer() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderdetailsswfitcourt_customer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderdetailsswfitcourt_customer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CustomerEmail", n => { CustomerEmail = n.GetStringValue(); } },
                {"CustomerNumber", n => { CustomerNumber = n.GetIntValue(); } },
                {"CustomerPhoneNumber", n => { CustomerPhoneNumber = n.GetStringValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("CustomerEmail", CustomerEmail);
            writer.WriteIntValue("CustomerNumber", CustomerNumber);
            writer.WriteStringValue("CustomerPhoneNumber", CustomerPhoneNumber);
            writer.WriteStringValue("Name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
