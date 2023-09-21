using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Invoicereceiver1 : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CombinedInvoice property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Combinedinvoice1? CombinedInvoice { get; set; }
#nullable restore
#else
        public Combinedinvoice1 CombinedInvoice { get; set; }
#endif
        /// <summary>The Customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Customer3? Customer { get; set; }
#nullable restore
#else
        public Customer3 Customer { get; set; }
#endif
        /// <summary>The ImmediateInvoice property</summary>
        public bool? ImmediateInvoice { get; set; }
        /// <summary>
        /// Instantiates a new invoicereceiver1 and sets the default values.
        /// </summary>
        public Invoicereceiver1() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Invoicereceiver1 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Invoicereceiver1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CombinedInvoice", n => { CombinedInvoice = n.GetObjectValue<Combinedinvoice1>(Combinedinvoice1.CreateFromDiscriminatorValue); } },
                {"Customer", n => { Customer = n.GetObjectValue<Customer3>(Customer3.CreateFromDiscriminatorValue); } },
                {"ImmediateInvoice", n => { ImmediateInvoice = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Combinedinvoice1>("CombinedInvoice", CombinedInvoice);
            writer.WriteObjectValue<Customer3>("Customer", Customer);
            writer.WriteBoolValue("ImmediateInvoice", ImmediateInvoice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
