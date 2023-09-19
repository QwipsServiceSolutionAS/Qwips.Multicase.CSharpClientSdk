using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Orderhead : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderaddress? Address { get; set; }
#nullable restore
#else
        public Orderaddress Address { get; set; }
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
        public Customer2? Customer { get; set; }
#nullable restore
#else
        public Customer2 Customer { get; set; }
#endif
        /// <summary>The Department property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Department1? Department { get; set; }
#nullable restore
#else
        public Department1 Department { get; set; }
#endif
        /// <summary>The ExternalOrderNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalOrderNumber { get; set; }
#nullable restore
#else
        public string ExternalOrderNumber { get; set; }
#endif
        /// <summary>The ExtraInfoXML property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderhead_ExtraInfoXML? ExtraInfoXML { get; set; }
#nullable restore
#else
        public Orderhead_ExtraInfoXML ExtraInfoXML { get; set; }
#endif
        /// <summary>The FollowUpDate property</summary>
        public DateTimeOffset? FollowUpDate { get; set; }
        /// <summary>The FreightMethod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Freightmethod? FreightMethod { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Freightmethod FreightMethod { get; set; }
#endif
        /// <summary>The OrderId property</summary>
        public int? OrderId { get; set; }
        /// <summary>The OrderNumber property</summary>
        public int? OrderNumber { get; set; }
        /// <summary>The OrderType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Ordertype? OrderType { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Ordertype OrderType { get; set; }
#endif
        /// <summary>The PaymentTerm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Paymentterm1? PaymentTerm { get; set; }
#nullable restore
#else
        public Paymentterm1 PaymentTerm { get; set; }
#endif
        /// <summary>The Project property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Project? Project { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Project Project { get; set; }
#endif
        /// <summary>The RefPerson property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RefPerson { get; set; }
#nullable restore
#else
        public string RefPerson { get; set; }
#endif
        /// <summary>The Seller property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Seller? Seller { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Seller Seller { get; set; }
#endif
        /// <summary>
        /// Instantiates a new orderhead and sets the default values.
        /// </summary>
        public Orderhead() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderhead CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderhead();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Address", n => { Address = n.GetObjectValue<Orderaddress>(Orderaddress.CreateFromDiscriminatorValue); } },
                {"BestRef", n => { BestRef = n.GetStringValue(); } },
                {"CombinedDelivery", n => { CombinedDelivery = n.GetBoolValue(); } },
                {"Customer", n => { Customer = n.GetObjectValue<Customer2>(Customer2.CreateFromDiscriminatorValue); } },
                {"Department", n => { Department = n.GetObjectValue<Department1>(Department1.CreateFromDiscriminatorValue); } },
                {"ExternalOrderNumber", n => { ExternalOrderNumber = n.GetStringValue(); } },
                {"ExtraInfoXML", n => { ExtraInfoXML = n.GetObjectValue<Orderhead_ExtraInfoXML>(Orderhead_ExtraInfoXML.CreateFromDiscriminatorValue); } },
                {"FollowUpDate", n => { FollowUpDate = n.GetDateTimeOffsetValue(); } },
                {"FreightMethod", n => { FreightMethod = n.GetObjectValue<Qwips.Core.MultiCase.Models.Freightmethod>(Qwips.Core.MultiCase.Models.Freightmethod.CreateFromDiscriminatorValue); } },
                {"OrderId", n => { OrderId = n.GetIntValue(); } },
                {"OrderNumber", n => { OrderNumber = n.GetIntValue(); } },
                {"OrderType", n => { OrderType = n.GetObjectValue<Qwips.Core.MultiCase.Models.Ordertype>(Qwips.Core.MultiCase.Models.Ordertype.CreateFromDiscriminatorValue); } },
                {"PaymentTerm", n => { PaymentTerm = n.GetObjectValue<Paymentterm1>(Paymentterm1.CreateFromDiscriminatorValue); } },
                {"Project", n => { Project = n.GetObjectValue<Qwips.Core.MultiCase.Models.Project>(Qwips.Core.MultiCase.Models.Project.CreateFromDiscriminatorValue); } },
                {"RefPerson", n => { RefPerson = n.GetStringValue(); } },
                {"Seller", n => { Seller = n.GetObjectValue<Qwips.Core.MultiCase.Models.Seller>(Qwips.Core.MultiCase.Models.Seller.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Orderaddress>("Address", Address);
            writer.WriteStringValue("BestRef", BestRef);
            writer.WriteBoolValue("CombinedDelivery", CombinedDelivery);
            writer.WriteObjectValue<Customer2>("Customer", Customer);
            writer.WriteObjectValue<Department1>("Department", Department);
            writer.WriteStringValue("ExternalOrderNumber", ExternalOrderNumber);
            writer.WriteObjectValue<Orderhead_ExtraInfoXML>("ExtraInfoXML", ExtraInfoXML);
            writer.WriteDateTimeOffsetValue("FollowUpDate", FollowUpDate);
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Freightmethod>("FreightMethod", FreightMethod);
            writer.WriteIntValue("OrderId", OrderId);
            writer.WriteIntValue("OrderNumber", OrderNumber);
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Ordertype>("OrderType", OrderType);
            writer.WriteObjectValue<Paymentterm1>("PaymentTerm", PaymentTerm);
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Project>("Project", Project);
            writer.WriteStringValue("RefPerson", RefPerson);
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Seller>("Seller", Seller);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
