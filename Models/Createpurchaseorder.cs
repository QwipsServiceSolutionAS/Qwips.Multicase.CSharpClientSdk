using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Createpurchaseorder : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Combined property</summary>
        public bool? Combined { get; set; }
        /// <summary>The CombinedPurchaseOrderId property</summary>
        public int? CombinedPurchaseOrderId { get; set; }
        /// <summary>The DeliveryTxt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveryTxt { get; set; }
#nullable restore
#else
        public string DeliveryTxt { get; set; }
#endif
        /// <summary>The Extra1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Extra1 { get; set; }
#nullable restore
#else
        public string Extra1 { get; set; }
#endif
        /// <summary>The Extra2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Extra2 { get; set; }
#nullable restore
#else
        public string Extra2 { get; set; }
#endif
        /// <summary>The Extra3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Extra3 { get; set; }
#nullable restore
#else
        public string Extra3 { get; set; }
#endif
        /// <summary>The Extra4 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Extra4 { get; set; }
#nullable restore
#else
        public string Extra4 { get; set; }
#endif
        /// <summary>The FreightId property</summary>
        public int? FreightId { get; set; }
        /// <summary>The Lines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Purchaseorderline>? Lines { get; set; }
#nullable restore
#else
        public List<Purchaseorderline> Lines { get; set; }
#endif
        /// <summary>The MsgToSupplier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MsgToSupplier { get; set; }
#nullable restore
#else
        public string MsgToSupplier { get; set; }
#endif
        /// <summary>The OkoTxt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OkoTxt { get; set; }
#nullable restore
#else
        public string OkoTxt { get; set; }
#endif
        /// <summary>The OrderRef property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderRef { get; set; }
#nullable restore
#else
        public string OrderRef { get; set; }
#endif
        /// <summary>The PurchaseTxt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PurchaseTxt { get; set; }
#nullable restore
#else
        public string PurchaseTxt { get; set; }
#endif
        /// <summary>The RefPerson property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RefPerson { get; set; }
#nullable restore
#else
        public string RefPerson { get; set; }
#endif
        /// <summary>The SenderId property</summary>
        public int? SenderId { get; set; }
        /// <summary>The SupplierNumber property</summary>
        public int? SupplierNumber { get; set; }
        /// <summary>The UseMcSuppliersPrice property</summary>
        public bool? UseMcSuppliersPrice { get; set; }
        /// <summary>The UserId property</summary>
        public int? UserId { get; set; }
        /// <summary>The VarTxt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VarTxt { get; set; }
#nullable restore
#else
        public string VarTxt { get; set; }
#endif
        /// <summary>The WarehouseCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WarehouseCode { get; set; }
#nullable restore
#else
        public string WarehouseCode { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Createpurchaseorder and sets the default values.
        /// </summary>
        public Createpurchaseorder() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Createpurchaseorder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Createpurchaseorder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Combined", n => { Combined = n.GetBoolValue(); } },
                {"CombinedPurchaseOrderId", n => { CombinedPurchaseOrderId = n.GetIntValue(); } },
                {"DeliveryTxt", n => { DeliveryTxt = n.GetStringValue(); } },
                {"Extra1", n => { Extra1 = n.GetStringValue(); } },
                {"Extra2", n => { Extra2 = n.GetStringValue(); } },
                {"Extra3", n => { Extra3 = n.GetStringValue(); } },
                {"Extra4", n => { Extra4 = n.GetStringValue(); } },
                {"FreightId", n => { FreightId = n.GetIntValue(); } },
                {"Lines", n => { Lines = n.GetCollectionOfObjectValues<Purchaseorderline>(Purchaseorderline.CreateFromDiscriminatorValue)?.ToList(); } },
                {"MsgToSupplier", n => { MsgToSupplier = n.GetStringValue(); } },
                {"OkoTxt", n => { OkoTxt = n.GetStringValue(); } },
                {"OrderRef", n => { OrderRef = n.GetStringValue(); } },
                {"PurchaseTxt", n => { PurchaseTxt = n.GetStringValue(); } },
                {"RefPerson", n => { RefPerson = n.GetStringValue(); } },
                {"SenderId", n => { SenderId = n.GetIntValue(); } },
                {"SupplierNumber", n => { SupplierNumber = n.GetIntValue(); } },
                {"UseMcSuppliersPrice", n => { UseMcSuppliersPrice = n.GetBoolValue(); } },
                {"UserId", n => { UserId = n.GetIntValue(); } },
                {"VarTxt", n => { VarTxt = n.GetStringValue(); } },
                {"WarehouseCode", n => { WarehouseCode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("Combined", Combined);
            writer.WriteIntValue("CombinedPurchaseOrderId", CombinedPurchaseOrderId);
            writer.WriteStringValue("DeliveryTxt", DeliveryTxt);
            writer.WriteStringValue("Extra1", Extra1);
            writer.WriteStringValue("Extra2", Extra2);
            writer.WriteStringValue("Extra3", Extra3);
            writer.WriteStringValue("Extra4", Extra4);
            writer.WriteIntValue("FreightId", FreightId);
            writer.WriteCollectionOfObjectValues<Purchaseorderline>("Lines", Lines);
            writer.WriteStringValue("MsgToSupplier", MsgToSupplier);
            writer.WriteStringValue("OkoTxt", OkoTxt);
            writer.WriteStringValue("OrderRef", OrderRef);
            writer.WriteStringValue("PurchaseTxt", PurchaseTxt);
            writer.WriteStringValue("RefPerson", RefPerson);
            writer.WriteIntValue("SenderId", SenderId);
            writer.WriteIntValue("SupplierNumber", SupplierNumber);
            writer.WriteBoolValue("UseMcSuppliersPrice", UseMcSuppliersPrice);
            writer.WriteIntValue("UserId", UserId);
            writer.WriteStringValue("VarTxt", VarTxt);
            writer.WriteStringValue("WarehouseCode", WarehouseCode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
