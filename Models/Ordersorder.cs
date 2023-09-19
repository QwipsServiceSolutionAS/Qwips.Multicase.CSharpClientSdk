using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Ordersorder : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Currency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
#endif
        /// <summary>The Customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Ordersordercustomer? Customer { get; set; }
#nullable restore
#else
        public Ordersordercustomer Customer { get; set; }
#endif
        /// <summary>The Date property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Date { get; set; }
#nullable restore
#else
        public string Date { get; set; }
#endif
        /// <summary>The Deliveries property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Ordersorderdelivery>? Deliveries { get; set; }
#nullable restore
#else
        public List<Ordersorderdelivery> Deliveries { get; set; }
#endif
        /// <summary>The Freight property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Freight { get; set; }
#nullable restore
#else
        public string Freight { get; set; }
#endif
        /// <summary>The FreightVAT property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FreightVAT { get; set; }
#nullable restore
#else
        public string FreightVAT { get; set; }
#endif
        /// <summary>The OrderHeadID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderHeadID { get; set; }
#nullable restore
#else
        public string OrderHeadID { get; set; }
#endif
        /// <summary>The OrderLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Ordersorderorderline>? OrderLines { get; set; }
#nullable restore
#else
        public List<Ordersorderorderline> OrderLines { get; set; }
#endif
        /// <summary>The OrderNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderNumber { get; set; }
#nullable restore
#else
        public string OrderNumber { get; set; }
#endif
        /// <summary>The PaymentTermID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentTermID { get; set; }
#nullable restore
#else
        public string PaymentTermID { get; set; }
#endif
        /// <summary>The Status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The Total property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Total { get; set; }
#nullable restore
#else
        public string Total { get; set; }
#endif
        /// <summary>The VAT property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VAT { get; set; }
#nullable restore
#else
        public string VAT { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ordersorder and sets the default values.
        /// </summary>
        public Ordersorder() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Ordersorder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Ordersorder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Currency", n => { Currency = n.GetStringValue(); } },
                {"Customer", n => { Customer = n.GetObjectValue<Ordersordercustomer>(Ordersordercustomer.CreateFromDiscriminatorValue); } },
                {"Date", n => { Date = n.GetStringValue(); } },
                {"Deliveries", n => { Deliveries = n.GetCollectionOfObjectValues<Ordersorderdelivery>(Ordersorderdelivery.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Freight", n => { Freight = n.GetStringValue(); } },
                {"FreightVAT", n => { FreightVAT = n.GetStringValue(); } },
                {"OrderHeadID", n => { OrderHeadID = n.GetStringValue(); } },
                {"OrderLines", n => { OrderLines = n.GetCollectionOfObjectValues<Ordersorderorderline>(Ordersorderorderline.CreateFromDiscriminatorValue)?.ToList(); } },
                {"OrderNumber", n => { OrderNumber = n.GetStringValue(); } },
                {"PaymentTermID", n => { PaymentTermID = n.GetStringValue(); } },
                {"Status", n => { Status = n.GetStringValue(); } },
                {"Total", n => { Total = n.GetStringValue(); } },
                {"VAT", n => { VAT = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Currency", Currency);
            writer.WriteObjectValue<Ordersordercustomer>("Customer", Customer);
            writer.WriteStringValue("Date", Date);
            writer.WriteCollectionOfObjectValues<Ordersorderdelivery>("Deliveries", Deliveries);
            writer.WriteStringValue("Freight", Freight);
            writer.WriteStringValue("FreightVAT", FreightVAT);
            writer.WriteStringValue("OrderHeadID", OrderHeadID);
            writer.WriteCollectionOfObjectValues<Ordersorderorderline>("OrderLines", OrderLines);
            writer.WriteStringValue("OrderNumber", OrderNumber);
            writer.WriteStringValue("PaymentTermID", PaymentTermID);
            writer.WriteStringValue("Status", Status);
            writer.WriteStringValue("Total", Total);
            writer.WriteStringValue("VAT", VAT);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
