using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Ordersorderorderline : IAdditionalDataHolder, IParsable {
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
        /// <summary>The IsDeleted property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IsDeleted { get; set; }
#nullable restore
#else
        public string IsDeleted { get; set; }
#endif
        /// <summary>The LineStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LineStatus { get; set; }
#nullable restore
#else
        public string LineStatus { get; set; }
#endif
        /// <summary>The OrderedQty property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderedQty { get; set; }
#nullable restore
#else
        public string OrderedQty { get; set; }
#endif
        /// <summary>The OrderLineID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderLineID { get; set; }
#nullable restore
#else
        public string OrderLineID { get; set; }
#endif
        /// <summary>The ProductDesc1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductDesc1 { get; set; }
#nullable restore
#else
        public string ProductDesc1 { get; set; }
#endif
        /// <summary>The ProductDesc2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductDesc2 { get; set; }
#nullable restore
#else
        public string ProductDesc2 { get; set; }
#endif
        /// <summary>The ProductID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductID { get; set; }
#nullable restore
#else
        public string ProductID { get; set; }
#endif
        /// <summary>The ProductNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductNumber { get; set; }
#nullable restore
#else
        public string ProductNumber { get; set; }
#endif
        /// <summary>The RemainQty property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemainQty { get; set; }
#nullable restore
#else
        public string RemainQty { get; set; }
#endif
        /// <summary>The SentQty property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SentQty { get; set; }
#nullable restore
#else
        public string SentQty { get; set; }
#endif
        /// <summary>The StatusDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusDate { get; set; }
#nullable restore
#else
        public string StatusDate { get; set; }
#endif
        /// <summary>The Unit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Unit { get; set; }
#nullable restore
#else
        public string Unit { get; set; }
#endif
        /// <summary>The UnitPrice property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnitPrice { get; set; }
#nullable restore
#else
        public string UnitPrice { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ordersorderorderline and sets the default values.
        /// </summary>
        public Ordersorderorderline() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Ordersorderorderline CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Ordersorderorderline();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Currency", n => { Currency = n.GetStringValue(); } },
                {"IsDeleted", n => { IsDeleted = n.GetStringValue(); } },
                {"LineStatus", n => { LineStatus = n.GetStringValue(); } },
                {"OrderedQty", n => { OrderedQty = n.GetStringValue(); } },
                {"OrderLineID", n => { OrderLineID = n.GetStringValue(); } },
                {"ProductDesc1", n => { ProductDesc1 = n.GetStringValue(); } },
                {"ProductDesc2", n => { ProductDesc2 = n.GetStringValue(); } },
                {"ProductID", n => { ProductID = n.GetStringValue(); } },
                {"ProductNumber", n => { ProductNumber = n.GetStringValue(); } },
                {"RemainQty", n => { RemainQty = n.GetStringValue(); } },
                {"SentQty", n => { SentQty = n.GetStringValue(); } },
                {"StatusDate", n => { StatusDate = n.GetStringValue(); } },
                {"Unit", n => { Unit = n.GetStringValue(); } },
                {"UnitPrice", n => { UnitPrice = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Currency", Currency);
            writer.WriteStringValue("IsDeleted", IsDeleted);
            writer.WriteStringValue("LineStatus", LineStatus);
            writer.WriteStringValue("OrderedQty", OrderedQty);
            writer.WriteStringValue("OrderLineID", OrderLineID);
            writer.WriteStringValue("ProductDesc1", ProductDesc1);
            writer.WriteStringValue("ProductDesc2", ProductDesc2);
            writer.WriteStringValue("ProductID", ProductID);
            writer.WriteStringValue("ProductNumber", ProductNumber);
            writer.WriteStringValue("RemainQty", RemainQty);
            writer.WriteStringValue("SentQty", SentQty);
            writer.WriteStringValue("StatusDate", StatusDate);
            writer.WriteStringValue("Unit", Unit);
            writer.WriteStringValue("UnitPrice", UnitPrice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
