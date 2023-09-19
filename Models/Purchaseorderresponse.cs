using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Purchaseorderresponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CurrencyCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>The DataId property</summary>
        public int? DataId { get; set; }
        /// <summary>The Lines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Purchaseorderlineresponse>? Lines { get; set; }
#nullable restore
#else
        public List<Purchaseorderlineresponse> Lines { get; set; }
#endif
        /// <summary>The PurchaseOrderId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PurchaseOrderId { get; set; }
#nullable restore
#else
        public string PurchaseOrderId { get; set; }
#endif
        /// <summary>The PurchaseOrderNumber property</summary>
        public int? PurchaseOrderNumber { get; set; }
        /// <summary>The SupplierId property</summary>
        public int? SupplierId { get; set; }
        /// <summary>
        /// Instantiates a new Purchaseorderresponse and sets the default values.
        /// </summary>
        public Purchaseorderresponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Purchaseorderresponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Purchaseorderresponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CurrencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"DataId", n => { DataId = n.GetIntValue(); } },
                {"Lines", n => { Lines = n.GetCollectionOfObjectValues<Purchaseorderlineresponse>(Purchaseorderlineresponse.CreateFromDiscriminatorValue)?.ToList(); } },
                {"PurchaseOrderId", n => { PurchaseOrderId = n.GetStringValue(); } },
                {"PurchaseOrderNumber", n => { PurchaseOrderNumber = n.GetIntValue(); } },
                {"SupplierId", n => { SupplierId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("CurrencyCode", CurrencyCode);
            writer.WriteIntValue("DataId", DataId);
            writer.WriteCollectionOfObjectValues<Purchaseorderlineresponse>("Lines", Lines);
            writer.WriteStringValue("PurchaseOrderId", PurchaseOrderId);
            writer.WriteIntValue("PurchaseOrderNumber", PurchaseOrderNumber);
            writer.WriteIntValue("SupplierId", SupplierId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
