using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Orderhead1 : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderaddress1? Address { get; set; }
#nullable restore
#else
        public Orderaddress1 Address { get; set; }
#endif
        /// <summary>The BestRef property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BestRef { get; set; }
#nullable restore
#else
        public string BestRef { get; set; }
#endif
        /// <summary>The CombinedDelivery property</summary>
        public bool? CombinedDelivery { get; set; }
        /// <summary>The Customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Customer3? Customer { get; set; }
#nullable restore
#else
        public Customer3 Customer { get; set; }
#endif
        /// <summary>The ExtraInfoXML property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtraInfoXML { get; set; }
#nullable restore
#else
        public string ExtraInfoXML { get; set; }
#endif
        /// <summary>The OrderId property</summary>
        public int? OrderId { get; set; }
        /// <summary>The OrderNumber property</summary>
        public int? OrderNumber { get; set; }
        /// <summary>The PaymentTerm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Paymentterm2? PaymentTerm { get; set; }
#nullable restore
#else
        public Paymentterm2 PaymentTerm { get; set; }
#endif
        /// <summary>The RefPerson property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RefPerson { get; set; }
#nullable restore
#else
        public string RefPerson { get; set; }
#endif
        /// <summary>
        /// Instantiates a new orderhead1 and sets the default values.
        /// </summary>
        public Orderhead1() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderhead1 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderhead1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Address", n => { Address = n.GetObjectValue<Orderaddress1>(Orderaddress1.CreateFromDiscriminatorValue); } },
                {"BestRef", n => { BestRef = n.GetStringValue(); } },
                {"CombinedDelivery", n => { CombinedDelivery = n.GetBoolValue(); } },
                {"Customer", n => { Customer = n.GetObjectValue<Customer3>(Customer3.CreateFromDiscriminatorValue); } },
                {"ExtraInfoXML", n => { ExtraInfoXML = n.GetStringValue(); } },
                {"OrderId", n => { OrderId = n.GetIntValue(); } },
                {"OrderNumber", n => { OrderNumber = n.GetIntValue(); } },
                {"PaymentTerm", n => { PaymentTerm = n.GetObjectValue<Paymentterm2>(Paymentterm2.CreateFromDiscriminatorValue); } },
                {"RefPerson", n => { RefPerson = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Orderaddress1>("Address", Address);
            writer.WriteStringValue("BestRef", BestRef);
            writer.WriteBoolValue("CombinedDelivery", CombinedDelivery);
            writer.WriteObjectValue<Customer3>("Customer", Customer);
            writer.WriteStringValue("ExtraInfoXML", ExtraInfoXML);
            writer.WriteIntValue("OrderId", OrderId);
            writer.WriteIntValue("OrderNumber", OrderNumber);
            writer.WriteObjectValue<Paymentterm2>("PaymentTerm", PaymentTerm);
            writer.WriteStringValue("RefPerson", RefPerson);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
