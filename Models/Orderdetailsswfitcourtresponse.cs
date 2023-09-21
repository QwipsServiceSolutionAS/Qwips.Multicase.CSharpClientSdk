using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Orderdetailsswfitcourtresponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderdetailsswfitcourt_customer? Customer { get; set; }
#nullable restore
#else
        public Orderdetailsswfitcourt_customer Customer { get; set; }
#endif
        /// <summary>The ExciseDuty property</summary>
        public double? ExciseDuty { get; set; }
        /// <summary>The OrderMessage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderMessage { get; set; }
#nullable restore
#else
        public string OrderMessage { get; set; }
#endif
        /// <summary>The OrderNumber property</summary>
        public int? OrderNumber { get; set; }
        /// <summary>The Seller property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderdetailsswfitcourt_seller? Seller { get; set; }
#nullable restore
#else
        public Orderdetailsswfitcourt_seller Seller { get; set; }
#endif
        /// <summary>
        /// Instantiates a new orderdetailsswfitcourtresponse and sets the default values.
        /// </summary>
        public Orderdetailsswfitcourtresponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderdetailsswfitcourtresponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderdetailsswfitcourtresponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Customer", n => { Customer = n.GetObjectValue<Orderdetailsswfitcourt_customer>(Orderdetailsswfitcourt_customer.CreateFromDiscriminatorValue); } },
                {"ExciseDuty", n => { ExciseDuty = n.GetDoubleValue(); } },
                {"OrderMessage", n => { OrderMessage = n.GetStringValue(); } },
                {"OrderNumber", n => { OrderNumber = n.GetIntValue(); } },
                {"Seller", n => { Seller = n.GetObjectValue<Orderdetailsswfitcourt_seller>(Orderdetailsswfitcourt_seller.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Orderdetailsswfitcourt_customer>("Customer", Customer);
            writer.WriteDoubleValue("ExciseDuty", ExciseDuty);
            writer.WriteStringValue("OrderMessage", OrderMessage);
            writer.WriteIntValue("OrderNumber", OrderNumber);
            writer.WriteObjectValue<Orderdetailsswfitcourt_seller>("Seller", Seller);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
