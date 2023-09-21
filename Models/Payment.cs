using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Payment : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Discount property</summary>
        public double? Discount { get; set; }
        /// <summary>The PaymentTerm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Paymentterm? PaymentTerm { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Paymentterm PaymentTerm { get; set; }
#endif
        /// <summary>
        /// Instantiates a new payment and sets the default values.
        /// </summary>
        public Payment() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Payment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Payment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Discount", n => { Discount = n.GetDoubleValue(); } },
                {"PaymentTerm", n => { PaymentTerm = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Paymentterm>(Qwips.Core.ClientSdk.Multicase.Models.Paymentterm.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("Discount", Discount);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Paymentterm>("PaymentTerm", PaymentTerm);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
