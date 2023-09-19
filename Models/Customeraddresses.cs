using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Customeraddresses : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Delivery property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Deliveryaddress? Delivery { get; set; }
#nullable restore
#else
        public Deliveryaddress Delivery { get; set; }
#endif
        /// <summary>The Invoice property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Invoiceaddress? Invoice { get; set; }
#nullable restore
#else
        public Invoiceaddress Invoice { get; set; }
#endif
        /// <summary>The Postal property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Postaladdress? Postal { get; set; }
#nullable restore
#else
        public Postaladdress Postal { get; set; }
#endif
        /// <summary>The Visit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Visitaddress? Visit { get; set; }
#nullable restore
#else
        public Visitaddress Visit { get; set; }
#endif
        /// <summary>
        /// Instantiates a new customeraddresses and sets the default values.
        /// </summary>
        public Customeraddresses() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Customeraddresses CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Customeraddresses();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Delivery", n => { Delivery = n.GetObjectValue<Deliveryaddress>(Deliveryaddress.CreateFromDiscriminatorValue); } },
                {"Invoice", n => { Invoice = n.GetObjectValue<Invoiceaddress>(Invoiceaddress.CreateFromDiscriminatorValue); } },
                {"Postal", n => { Postal = n.GetObjectValue<Postaladdress>(Postaladdress.CreateFromDiscriminatorValue); } },
                {"Visit", n => { Visit = n.GetObjectValue<Visitaddress>(Visitaddress.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Deliveryaddress>("Delivery", Delivery);
            writer.WriteObjectValue<Invoiceaddress>("Invoice", Invoice);
            writer.WriteObjectValue<Postaladdress>("Postal", Postal);
            writer.WriteObjectValue<Visitaddress>("Visit", Visit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
