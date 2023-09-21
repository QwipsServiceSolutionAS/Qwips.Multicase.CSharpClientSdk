using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Purchasehistoryitem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Details property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Details { get; set; }
#nullable restore
#else
        public string Details { get; set; }
#endif
        /// <summary>The NewStatusForPurchase property</summary>
        public int? NewStatusForPurchase { get; set; }
        /// <summary>The PurchaseNumber property</summary>
        public int? PurchaseNumber { get; set; }
        /// <summary>The Source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source { get; set; }
#nullable restore
#else
        public string Source { get; set; }
#endif
        /// <summary>The Status property</summary>
        public int? Status { get; set; }
        /// <summary>The StatusMessage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusMessage { get; set; }
#nullable restore
#else
        public string StatusMessage { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Purchasehistoryitem and sets the default values.
        /// </summary>
        public Purchasehistoryitem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Purchasehistoryitem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Purchasehistoryitem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Details", n => { Details = n.GetStringValue(); } },
                {"NewStatusForPurchase", n => { NewStatusForPurchase = n.GetIntValue(); } },
                {"PurchaseNumber", n => { PurchaseNumber = n.GetIntValue(); } },
                {"Source", n => { Source = n.GetStringValue(); } },
                {"Status", n => { Status = n.GetIntValue(); } },
                {"StatusMessage", n => { StatusMessage = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Details", Details);
            writer.WriteIntValue("NewStatusForPurchase", NewStatusForPurchase);
            writer.WriteIntValue("PurchaseNumber", PurchaseNumber);
            writer.WriteStringValue("Source", Source);
            writer.WriteIntValue("Status", Status);
            writer.WriteStringValue("StatusMessage", StatusMessage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
