using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Orderdetailsswfitcourt_seller : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The SellerEmail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SellerEmail { get; set; }
#nullable restore
#else
        public string SellerEmail { get; set; }
#endif
        /// <summary>The SellerFullName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SellerFullName { get; set; }
#nullable restore
#else
        public string SellerFullName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new orderdetailsswfitcourt_seller and sets the default values.
        /// </summary>
        public Orderdetailsswfitcourt_seller() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderdetailsswfitcourt_seller CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderdetailsswfitcourt_seller();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"SellerEmail", n => { SellerEmail = n.GetStringValue(); } },
                {"SellerFullName", n => { SellerFullName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("SellerEmail", SellerEmail);
            writer.WriteStringValue("SellerFullName", SellerFullName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
