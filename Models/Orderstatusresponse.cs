using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Orderstatusresponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderstatusresponse_customer? Customer { get; set; }
#nullable restore
#else
        public Orderstatusresponse_customer Customer { get; set; }
#endif
        /// <summary>The Deleted property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderstatusresponse_deletedorder? Deleted { get; set; }
#nullable restore
#else
        public Orderstatusresponse_deletedorder Deleted { get; set; }
#endif
        /// <summary>The ExternalOrderNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalOrderNumber { get; set; }
#nullable restore
#else
        public string ExternalOrderNumber { get; set; }
#endif
        /// <summary>The OrderHoldStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderstatusresponse_orderholdstatus? OrderHoldStatus { get; set; }
#nullable restore
#else
        public Orderstatusresponse_orderholdstatus OrderHoldStatus { get; set; }
#endif
        /// <summary>The OrderId property</summary>
        public int? OrderId { get; set; }
        /// <summary>The OrderLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Orderstatusresponse_orderline>? OrderLines { get; set; }
#nullable restore
#else
        public List<Orderstatusresponse_orderline> OrderLines { get; set; }
#endif
        /// <summary>The OrderNumber property</summary>
        public int? OrderNumber { get; set; }
        /// <summary>The OrderStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderstatusresponse_orderstatus? OrderStatus { get; set; }
#nullable restore
#else
        public Orderstatusresponse_orderstatus OrderStatus { get; set; }
#endif
        /// <summary>The Recipient property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderstatusresponse_recipient? Recipient { get; set; }
#nullable restore
#else
        public Orderstatusresponse_recipient Recipient { get; set; }
#endif
        /// <summary>The RefPerson property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RefPerson { get; set; }
#nullable restore
#else
        public string RefPerson { get; set; }
#endif
        /// <summary>The SenderName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderName { get; set; }
#nullable restore
#else
        public string SenderName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new orderstatusresponse and sets the default values.
        /// </summary>
        public Orderstatusresponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderstatusresponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderstatusresponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Customer", n => { Customer = n.GetObjectValue<Orderstatusresponse_customer>(Orderstatusresponse_customer.CreateFromDiscriminatorValue); } },
                {"Deleted", n => { Deleted = n.GetObjectValue<Orderstatusresponse_deletedorder>(Orderstatusresponse_deletedorder.CreateFromDiscriminatorValue); } },
                {"ExternalOrderNumber", n => { ExternalOrderNumber = n.GetStringValue(); } },
                {"OrderHoldStatus", n => { OrderHoldStatus = n.GetObjectValue<Orderstatusresponse_orderholdstatus>(Orderstatusresponse_orderholdstatus.CreateFromDiscriminatorValue); } },
                {"OrderId", n => { OrderId = n.GetIntValue(); } },
                {"OrderLines", n => { OrderLines = n.GetCollectionOfObjectValues<Orderstatusresponse_orderline>(Orderstatusresponse_orderline.CreateFromDiscriminatorValue)?.ToList(); } },
                {"OrderNumber", n => { OrderNumber = n.GetIntValue(); } },
                {"OrderStatus", n => { OrderStatus = n.GetObjectValue<Orderstatusresponse_orderstatus>(Orderstatusresponse_orderstatus.CreateFromDiscriminatorValue); } },
                {"Recipient", n => { Recipient = n.GetObjectValue<Orderstatusresponse_recipient>(Orderstatusresponse_recipient.CreateFromDiscriminatorValue); } },
                {"RefPerson", n => { RefPerson = n.GetStringValue(); } },
                {"SenderName", n => { SenderName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Orderstatusresponse_customer>("Customer", Customer);
            writer.WriteObjectValue<Orderstatusresponse_deletedorder>("Deleted", Deleted);
            writer.WriteStringValue("ExternalOrderNumber", ExternalOrderNumber);
            writer.WriteObjectValue<Orderstatusresponse_orderholdstatus>("OrderHoldStatus", OrderHoldStatus);
            writer.WriteIntValue("OrderId", OrderId);
            writer.WriteCollectionOfObjectValues<Orderstatusresponse_orderline>("OrderLines", OrderLines);
            writer.WriteIntValue("OrderNumber", OrderNumber);
            writer.WriteObjectValue<Orderstatusresponse_orderstatus>("OrderStatus", OrderStatus);
            writer.WriteObjectValue<Orderstatusresponse_recipient>("Recipient", Recipient);
            writer.WriteStringValue("RefPerson", RefPerson);
            writer.WriteStringValue("SenderName", SenderName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
