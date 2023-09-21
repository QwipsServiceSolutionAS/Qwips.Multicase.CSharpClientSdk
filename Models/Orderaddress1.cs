using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Orderaddress1 : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The InvoiceReceiver property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Invoicereceiver1? InvoiceReceiver { get; set; }
#nullable restore
#else
        public Invoicereceiver1 InvoiceReceiver { get; set; }
#endif
        /// <summary>The PackageReceiver property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Packagereceiver1? PackageReceiver { get; set; }
#nullable restore
#else
        public Packagereceiver1 PackageReceiver { get; set; }
#endif
        /// <summary>
        /// Instantiates a new orderaddress1 and sets the default values.
        /// </summary>
        public Orderaddress1() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderaddress1 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderaddress1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"InvoiceReceiver", n => { InvoiceReceiver = n.GetObjectValue<Invoicereceiver1>(Invoicereceiver1.CreateFromDiscriminatorValue); } },
                {"PackageReceiver", n => { PackageReceiver = n.GetObjectValue<Packagereceiver1>(Packagereceiver1.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Invoicereceiver1>("InvoiceReceiver", InvoiceReceiver);
            writer.WriteObjectValue<Packagereceiver1>("PackageReceiver", PackageReceiver);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
