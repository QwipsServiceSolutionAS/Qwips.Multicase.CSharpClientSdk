using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Createorder : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Address? Address { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Address Address { get; set; }
#endif
        /// <summary>The CardPayment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Cardpayment? CardPayment { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Cardpayment CardPayment { get; set; }
#endif
        /// <summary>The ContactID property</summary>
        public int? ContactID { get; set; }
        /// <summary>The CurrencyID property</summary>
        public int? CurrencyID { get; set; }
        /// <summary>The CustomerEAN property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerEAN { get; set; }
#nullable restore
#else
        public string CustomerEAN { get; set; }
#endif
        /// <summary>The CustomerID property</summary>
        public int? CustomerID { get; set; }
        /// <summary>The CustomerNumber property</summary>
        public int? CustomerNumber { get; set; }
        /// <summary>The DeliveryConfirmation property</summary>
        public bool? DeliveryConfirmation { get; set; }
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
        public string? ExtraInfoXML { get; set; }
#nullable restore
#else
        public string ExtraInfoXML { get; set; }
#endif
        /// <summary>The Freight property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Freight1? Freight { get; set; }
#nullable restore
#else
        public Freight1 Freight { get; set; }
#endif
        /// <summary>The HoldStatusID property</summary>
        public int? HoldStatusID { get; set; }
        /// <summary>The Lines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Orderline>? Lines { get; set; }
#nullable restore
#else
        public List<Orderline> Lines { get; set; }
#endif
        /// <summary>The Messages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Ordermessages? Messages { get; set; }
#nullable restore
#else
        public Ordermessages Messages { get; set; }
#endif
        /// <summary>The OkoProsjektNokkel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OkoProsjektNokkel { get; set; }
#nullable restore
#else
        public string OkoProsjektNokkel { get; set; }
#endif
        /// <summary>The OrderReference property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderReference { get; set; }
#nullable restore
#else
        public string OrderReference { get; set; }
#endif
        /// <summary>The OrderTypeID property</summary>
        public int? OrderTypeID { get; set; }
        /// <summary>The PaymentTermID property</summary>
        public int? PaymentTermID { get; set; }
        /// <summary>The ReferencePerson property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReferencePerson { get; set; }
#nullable restore
#else
        public string ReferencePerson { get; set; }
#endif
        /// <summary>The ReservedOrderCustomerID property</summary>
        public int? ReservedOrderCustomerID { get; set; }
        /// <summary>The SenderID property</summary>
        public int? SenderID { get; set; }
        /// <summary>The ShipTogether property</summary>
        public bool? ShipTogether { get; set; }
        /// <summary>The StockCheckMode property</summary>
        public Stockcheckmodeenum? StockCheckMode { get; set; }
        /// <summary>The UseMCPrice property</summary>
        public bool? UseMCPrice { get; set; }
        /// <summary>The UserID property</summary>
        public int? UserID { get; set; }
        /// <summary>The WarehouseID property</summary>
        public int? WarehouseID { get; set; }
        /// <summary>The WebServiceID property</summary>
        public int? WebServiceID { get; set; }
        /// <summary>
        /// Instantiates a new Createorder and sets the default values.
        /// </summary>
        public Createorder() {
            AdditionalData = new Dictionary<string, object>();
            StockCheckMode = Stockcheckmodeenum.PlaceOrderAsIs;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Createorder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Createorder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Address", n => { Address = n.GetObjectValue<Qwips.Core.MultiCase.Models.Address>(Qwips.Core.MultiCase.Models.Address.CreateFromDiscriminatorValue); } },
                {"CardPayment", n => { CardPayment = n.GetObjectValue<Qwips.Core.MultiCase.Models.Cardpayment>(Qwips.Core.MultiCase.Models.Cardpayment.CreateFromDiscriminatorValue); } },
                {"ContactID", n => { ContactID = n.GetIntValue(); } },
                {"CurrencyID", n => { CurrencyID = n.GetIntValue(); } },
                {"CustomerEAN", n => { CustomerEAN = n.GetStringValue(); } },
                {"CustomerID", n => { CustomerID = n.GetIntValue(); } },
                {"CustomerNumber", n => { CustomerNumber = n.GetIntValue(); } },
                {"DeliveryConfirmation", n => { DeliveryConfirmation = n.GetBoolValue(); } },
                {"ExternalOrderNumber", n => { ExternalOrderNumber = n.GetStringValue(); } },
                {"ExtraInfoXML", n => { ExtraInfoXML = n.GetStringValue(); } },
                {"Freight", n => { Freight = n.GetObjectValue<Freight1>(Freight1.CreateFromDiscriminatorValue); } },
                {"HoldStatusID", n => { HoldStatusID = n.GetIntValue(); } },
                {"Lines", n => { Lines = n.GetCollectionOfObjectValues<Orderline>(Orderline.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Messages", n => { Messages = n.GetObjectValue<Ordermessages>(Ordermessages.CreateFromDiscriminatorValue); } },
                {"OkoProsjektNokkel", n => { OkoProsjektNokkel = n.GetStringValue(); } },
                {"OrderReference", n => { OrderReference = n.GetStringValue(); } },
                {"OrderTypeID", n => { OrderTypeID = n.GetIntValue(); } },
                {"PaymentTermID", n => { PaymentTermID = n.GetIntValue(); } },
                {"ReferencePerson", n => { ReferencePerson = n.GetStringValue(); } },
                {"ReservedOrderCustomerID", n => { ReservedOrderCustomerID = n.GetIntValue(); } },
                {"SenderID", n => { SenderID = n.GetIntValue(); } },
                {"ShipTogether", n => { ShipTogether = n.GetBoolValue(); } },
                {"StockCheckMode", n => { StockCheckMode = n.GetEnumValue<Stockcheckmodeenum>(); } },
                {"UseMCPrice", n => { UseMCPrice = n.GetBoolValue(); } },
                {"UserID", n => { UserID = n.GetIntValue(); } },
                {"WarehouseID", n => { WarehouseID = n.GetIntValue(); } },
                {"WebServiceID", n => { WebServiceID = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Address>("Address", Address);
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Cardpayment>("CardPayment", CardPayment);
            writer.WriteIntValue("ContactID", ContactID);
            writer.WriteIntValue("CurrencyID", CurrencyID);
            writer.WriteStringValue("CustomerEAN", CustomerEAN);
            writer.WriteIntValue("CustomerID", CustomerID);
            writer.WriteIntValue("CustomerNumber", CustomerNumber);
            writer.WriteBoolValue("DeliveryConfirmation", DeliveryConfirmation);
            writer.WriteStringValue("ExternalOrderNumber", ExternalOrderNumber);
            writer.WriteStringValue("ExtraInfoXML", ExtraInfoXML);
            writer.WriteObjectValue<Freight1>("Freight", Freight);
            writer.WriteIntValue("HoldStatusID", HoldStatusID);
            writer.WriteCollectionOfObjectValues<Orderline>("Lines", Lines);
            writer.WriteObjectValue<Ordermessages>("Messages", Messages);
            writer.WriteStringValue("OkoProsjektNokkel", OkoProsjektNokkel);
            writer.WriteStringValue("OrderReference", OrderReference);
            writer.WriteIntValue("OrderTypeID", OrderTypeID);
            writer.WriteIntValue("PaymentTermID", PaymentTermID);
            writer.WriteStringValue("ReferencePerson", ReferencePerson);
            writer.WriteIntValue("ReservedOrderCustomerID", ReservedOrderCustomerID);
            writer.WriteIntValue("SenderID", SenderID);
            writer.WriteBoolValue("ShipTogether", ShipTogether);
            writer.WriteEnumValue<Stockcheckmodeenum>("StockCheckMode", StockCheckMode);
            writer.WriteBoolValue("UseMCPrice", UseMCPrice);
            writer.WriteIntValue("UserID", UserID);
            writer.WriteIntValue("WarehouseID", WarehouseID);
            writer.WriteIntValue("WebServiceID", WebServiceID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
