using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Purchaseorderreceivedpartly : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The InvoiceNumber property</summary>
        public int? InvoiceNumber { get; set; }
        /// <summary>The Lines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Purchaselines? Lines { get; set; }
#nullable restore
#else
        public Purchaselines Lines { get; set; }
#endif
        /// <summary>The PackingNr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackingNr { get; set; }
#nullable restore
#else
        public string PackingNr { get; set; }
#endif
        /// <summary>The PackingReference property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackingReference { get; set; }
#nullable restore
#else
        public string PackingReference { get; set; }
#endif
        /// <summary>The PurchaseOrderNumber property</summary>
        public int? PurchaseOrderNumber { get; set; }
        /// <summary>The SenderIdent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderIdent { get; set; }
#nullable restore
#else
        public string SenderIdent { get; set; }
#endif
        /// <summary>The TrackingURL property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TrackingURL { get; set; }
#nullable restore
#else
        public string TrackingURL { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Purchaseorderreceivedpartly and sets the default values.
        /// </summary>
        public Purchaseorderreceivedpartly() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Purchaseorderreceivedpartly CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Purchaseorderreceivedpartly();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"InvoiceNumber", n => { InvoiceNumber = n.GetIntValue(); } },
                {"Lines", n => { Lines = n.GetObjectValue<Purchaselines>(Purchaselines.CreateFromDiscriminatorValue); } },
                {"PackingNr", n => { PackingNr = n.GetStringValue(); } },
                {"PackingReference", n => { PackingReference = n.GetStringValue(); } },
                {"PurchaseOrderNumber", n => { PurchaseOrderNumber = n.GetIntValue(); } },
                {"SenderIdent", n => { SenderIdent = n.GetStringValue(); } },
                {"TrackingURL", n => { TrackingURL = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("InvoiceNumber", InvoiceNumber);
            writer.WriteObjectValue<Purchaselines>("Lines", Lines);
            writer.WriteStringValue("PackingNr", PackingNr);
            writer.WriteStringValue("PackingReference", PackingReference);
            writer.WriteIntValue("PurchaseOrderNumber", PurchaseOrderNumber);
            writer.WriteStringValue("SenderIdent", SenderIdent);
            writer.WriteStringValue("TrackingURL", TrackingURL);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
