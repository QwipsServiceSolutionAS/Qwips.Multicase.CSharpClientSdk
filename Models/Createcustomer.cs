using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Createcustomer : IAdditionalDataHolder, IParsable {
        /// <summary>The Accounting property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Customeraccounting? Accounting { get; set; }
#nullable restore
#else
        public Customeraccounting Accounting { get; set; }
#endif
        /// <summary>The Active property</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Addresses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Customeraddresses? Addresses { get; set; }
#nullable restore
#else
        public Customeraddresses Addresses { get; set; }
#endif
        /// <summary>The Agreements property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Customeragreements? Agreements { get; set; }
#nullable restore
#else
        public Customeragreements Agreements { get; set; }
#endif
        /// <summary>The Communication property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Communication? Communication { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Communication Communication { get; set; }
#endif
        /// <summary>The CompanyNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyNumber { get; set; }
#nullable restore
#else
        public string CompanyNumber { get; set; }
#endif
        /// <summary>The Contacts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Customercontact>? Contacts { get; set; }
#nullable restore
#else
        public List<Customercontact> Contacts { get; set; }
#endif
        /// <summary>The Country property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Country? Country { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Country Country { get; set; }
#endif
        /// <summary>The CustomerGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Customergroup>? CustomerGroups { get; set; }
#nullable restore
#else
        public List<Customergroup> CustomerGroups { get; set; }
#endif
        /// <summary>The CustomerNumber property</summary>
        public int? CustomerNumber { get; set; }
        /// <summary>The Delivery property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Customerdelivery? Delivery { get; set; }
#nullable restore
#else
        public Customerdelivery Delivery { get; set; }
#endif
        /// <summary>The GLN property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GLN { get; set; }
#nullable restore
#else
        public string GLN { get; set; }
#endif
        /// <summary>The Id property</summary>
        public int? Id { get; set; }
        /// <summary>The InvoiceReceiver property</summary>
        public int? InvoiceReceiver { get; set; }
        /// <summary>The IsCompany property</summary>
        public bool? IsCompany { get; set; }
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The Notes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Customernotes? Notes { get; set; }
#nullable restore
#else
        public Customernotes Notes { get; set; }
#endif
        /// <summary>The PriceGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Pricelistgroup>? PriceGroups { get; set; }
#nullable restore
#else
        public List<Pricelistgroup> PriceGroups { get; set; }
#endif
        /// <summary>The Region property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region { get; set; }
#nullable restore
#else
        public string Region { get; set; }
#endif
        /// <summary>The RegisteredBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Createcustomer_RegisteredBy? RegisteredBy { get; set; }
#nullable restore
#else
        public Createcustomer_RegisteredBy RegisteredBy { get; set; }
#endif
        /// <summary>The RegisteredDate property</summary>
        public DateTimeOffset? RegisteredDate { get; set; }
        /// <summary>The Responsible1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Createcustomer_Responsible1? Responsible1 { get; set; }
#nullable restore
#else
        public Createcustomer_Responsible1 Responsible1 { get; set; }
#endif
        /// <summary>The Responsible2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Createcustomer_Responsible2? Responsible2 { get; set; }
#nullable restore
#else
        public Createcustomer_Responsible2 Responsible2 { get; set; }
#endif
        /// <summary>The Sender property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Createcustomer_Sender? Sender { get; set; }
#nullable restore
#else
        public Createcustomer_Sender Sender { get; set; }
#endif
        /// <summary>The Shortname property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Shortname { get; set; }
#nullable restore
#else
        public string Shortname { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Createcustomer and sets the default values.
        /// </summary>
        public Createcustomer() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Createcustomer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Createcustomer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Accounting", n => { Accounting = n.GetObjectValue<Customeraccounting>(Customeraccounting.CreateFromDiscriminatorValue); } },
                {"Active", n => { Active = n.GetBoolValue(); } },
                {"Addresses", n => { Addresses = n.GetObjectValue<Customeraddresses>(Customeraddresses.CreateFromDiscriminatorValue); } },
                {"Agreements", n => { Agreements = n.GetObjectValue<Customeragreements>(Customeragreements.CreateFromDiscriminatorValue); } },
                {"Communication", n => { Communication = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Communication>(Qwips.Core.ClientSdk.Multicase.Models.Communication.CreateFromDiscriminatorValue); } },
                {"CompanyNumber", n => { CompanyNumber = n.GetStringValue(); } },
                {"Contacts", n => { Contacts = n.GetCollectionOfObjectValues<Customercontact>(Customercontact.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Country", n => { Country = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Country>(Qwips.Core.ClientSdk.Multicase.Models.Country.CreateFromDiscriminatorValue); } },
                {"CustomerGroups", n => { CustomerGroups = n.GetCollectionOfObjectValues<Customergroup>(Customergroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"CustomerNumber", n => { CustomerNumber = n.GetIntValue(); } },
                {"Delivery", n => { Delivery = n.GetObjectValue<Customerdelivery>(Customerdelivery.CreateFromDiscriminatorValue); } },
                {"GLN", n => { GLN = n.GetStringValue(); } },
                {"Id", n => { Id = n.GetIntValue(); } },
                {"InvoiceReceiver", n => { InvoiceReceiver = n.GetIntValue(); } },
                {"IsCompany", n => { IsCompany = n.GetBoolValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"Notes", n => { Notes = n.GetObjectValue<Customernotes>(Customernotes.CreateFromDiscriminatorValue); } },
                {"PriceGroups", n => { PriceGroups = n.GetCollectionOfObjectValues<Pricelistgroup>(Pricelistgroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Region", n => { Region = n.GetStringValue(); } },
                {"RegisteredBy", n => { RegisteredBy = n.GetObjectValue<Createcustomer_RegisteredBy>(Createcustomer_RegisteredBy.CreateFromDiscriminatorValue); } },
                {"RegisteredDate", n => { RegisteredDate = n.GetDateTimeOffsetValue(); } },
                {"Responsible1", n => { Responsible1 = n.GetObjectValue<Createcustomer_Responsible1>(Createcustomer_Responsible1.CreateFromDiscriminatorValue); } },
                {"Responsible2", n => { Responsible2 = n.GetObjectValue<Createcustomer_Responsible2>(Createcustomer_Responsible2.CreateFromDiscriminatorValue); } },
                {"Sender", n => { Sender = n.GetObjectValue<Createcustomer_Sender>(Createcustomer_Sender.CreateFromDiscriminatorValue); } },
                {"Shortname", n => { Shortname = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Customeraccounting>("Accounting", Accounting);
            writer.WriteBoolValue("Active", Active);
            writer.WriteObjectValue<Customeraddresses>("Addresses", Addresses);
            writer.WriteObjectValue<Customeragreements>("Agreements", Agreements);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Communication>("Communication", Communication);
            writer.WriteStringValue("CompanyNumber", CompanyNumber);
            writer.WriteCollectionOfObjectValues<Customercontact>("Contacts", Contacts);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Country>("Country", Country);
            writer.WriteCollectionOfObjectValues<Customergroup>("CustomerGroups", CustomerGroups);
            writer.WriteIntValue("CustomerNumber", CustomerNumber);
            writer.WriteObjectValue<Customerdelivery>("Delivery", Delivery);
            writer.WriteStringValue("GLN", GLN);
            writer.WriteIntValue("Id", Id);
            writer.WriteIntValue("InvoiceReceiver", InvoiceReceiver);
            writer.WriteBoolValue("IsCompany", IsCompany);
            writer.WriteStringValue("Name", Name);
            writer.WriteObjectValue<Customernotes>("Notes", Notes);
            writer.WriteCollectionOfObjectValues<Pricelistgroup>("PriceGroups", PriceGroups);
            writer.WriteStringValue("Region", Region);
            writer.WriteObjectValue<Createcustomer_RegisteredBy>("RegisteredBy", RegisteredBy);
            writer.WriteDateTimeOffsetValue("RegisteredDate", RegisteredDate);
            writer.WriteObjectValue<Createcustomer_Responsible1>("Responsible1", Responsible1);
            writer.WriteObjectValue<Createcustomer_Responsible2>("Responsible2", Responsible2);
            writer.WriteObjectValue<Createcustomer_Sender>("Sender", Sender);
            writer.WriteStringValue("Shortname", Shortname);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
