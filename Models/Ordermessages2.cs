using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Ordermessages2 : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CarrierInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CarrierInfo { get; set; }
#nullable restore
#else
        public string CarrierInfo { get; set; }
#endif
        /// <summary>The InternalMessage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternalMessage { get; set; }
#nullable restore
#else
        public string InternalMessage { get; set; }
#endif
        /// <summary>The Invoice property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Invoice { get; set; }
#nullable restore
#else
        public string Invoice { get; set; }
#endif
        /// <summary>The OrderConfirmation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderConfirmation { get; set; }
#nullable restore
#else
        public string OrderConfirmation { get; set; }
#endif
        /// <summary>The PackingSlip property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackingSlip { get; set; }
#nullable restore
#else
        public string PackingSlip { get; set; }
#endif
        /// <summary>The PickingList property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PickingList { get; set; }
#nullable restore
#else
        public string PickingList { get; set; }
#endif
        /// <summary>The SalesInformation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SalesInformation { get; set; }
#nullable restore
#else
        public string SalesInformation { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ordermessages2 and sets the default values.
        /// </summary>
        public Ordermessages2() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Ordermessages2 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Ordermessages2();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CarrierInfo", n => { CarrierInfo = n.GetStringValue(); } },
                {"InternalMessage", n => { InternalMessage = n.GetStringValue(); } },
                {"Invoice", n => { Invoice = n.GetStringValue(); } },
                {"OrderConfirmation", n => { OrderConfirmation = n.GetStringValue(); } },
                {"PackingSlip", n => { PackingSlip = n.GetStringValue(); } },
                {"PickingList", n => { PickingList = n.GetStringValue(); } },
                {"SalesInformation", n => { SalesInformation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("CarrierInfo", CarrierInfo);
            writer.WriteStringValue("InternalMessage", InternalMessage);
            writer.WriteStringValue("Invoice", Invoice);
            writer.WriteStringValue("OrderConfirmation", OrderConfirmation);
            writer.WriteStringValue("PackingSlip", PackingSlip);
            writer.WriteStringValue("PickingList", PickingList);
            writer.WriteStringValue("SalesInformation", SalesInformation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
