using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Cardpayment : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AmountAuth property</summary>
        public double? AmountAuth { get; set; }
        /// <summary>The MerchantID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MerchantID { get; set; }
#nullable restore
#else
        public string MerchantID { get; set; }
#endif
        /// <summary>The Token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>The TransactionID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionID { get; set; }
#nullable restore
#else
        public string TransactionID { get; set; }
#endif
        /// <summary>
        /// Instantiates a new cardpayment and sets the default values.
        /// </summary>
        public Cardpayment() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Cardpayment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Cardpayment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AmountAuth", n => { AmountAuth = n.GetDoubleValue(); } },
                {"MerchantID", n => { MerchantID = n.GetStringValue(); } },
                {"Token", n => { Token = n.GetStringValue(); } },
                {"TransactionID", n => { TransactionID = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("AmountAuth", AmountAuth);
            writer.WriteStringValue("MerchantID", MerchantID);
            writer.WriteStringValue("Token", Token);
            writer.WriteStringValue("TransactionID", TransactionID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
