using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Customerresponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Contacts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Contactresponse>? Contacts { get; set; }
#nullable restore
#else
        public List<Contactresponse> Contacts { get; set; }
#endif
        /// <summary>The Country property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>The CustomerGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CustomerGroups { get; set; }
#nullable restore
#else
        public List<string> CustomerGroups { get; set; }
#endif
        /// <summary>The CustomerNumber property</summary>
        public int? CustomerNumber { get; set; }
        /// <summary>The EDIPrefix property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EDIPrefix { get; set; }
#nullable restore
#else
        public string EDIPrefix { get; set; }
#endif
        /// <summary>The Email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The Fax property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fax { get; set; }
#nullable restore
#else
        public string Fax { get; set; }
#endif
        /// <summary>The Id property</summary>
        public int? Id { get; set; }
        /// <summary>The LastModified property</summary>
        public DateTimeOffset? LastModified { get; set; }
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The OrganizationNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationNumber { get; set; }
#nullable restore
#else
        public string OrganizationNumber { get; set; }
#endif
        /// <summary>The OurContact property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OurContact { get; set; }
#nullable restore
#else
        public string OurContact { get; set; }
#endif
        /// <summary>The Phone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>The SalesRegion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SalesRegion { get; set; }
#nullable restore
#else
        public string SalesRegion { get; set; }
#endif
        /// <summary>The SupplierNumber property</summary>
        public int? SupplierNumber { get; set; }
        /// <summary>The Website property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Website { get; set; }
#nullable restore
#else
        public string Website { get; set; }
#endif
        /// <summary>
        /// Instantiates a new customerresponse and sets the default values.
        /// </summary>
        public Customerresponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Customerresponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Customerresponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Contacts", n => { Contacts = n.GetCollectionOfObjectValues<Contactresponse>(Contactresponse.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Country", n => { Country = n.GetStringValue(); } },
                {"CustomerGroups", n => { CustomerGroups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"CustomerNumber", n => { CustomerNumber = n.GetIntValue(); } },
                {"EDIPrefix", n => { EDIPrefix = n.GetStringValue(); } },
                {"Email", n => { Email = n.GetStringValue(); } },
                {"Fax", n => { Fax = n.GetStringValue(); } },
                {"Id", n => { Id = n.GetIntValue(); } },
                {"LastModified", n => { LastModified = n.GetDateTimeOffsetValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"OrganizationNumber", n => { OrganizationNumber = n.GetStringValue(); } },
                {"OurContact", n => { OurContact = n.GetStringValue(); } },
                {"Phone", n => { Phone = n.GetStringValue(); } },
                {"SalesRegion", n => { SalesRegion = n.GetStringValue(); } },
                {"SupplierNumber", n => { SupplierNumber = n.GetIntValue(); } },
                {"Website", n => { Website = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Contactresponse>("Contacts", Contacts);
            writer.WriteStringValue("Country", Country);
            writer.WriteCollectionOfPrimitiveValues<string>("CustomerGroups", CustomerGroups);
            writer.WriteIntValue("CustomerNumber", CustomerNumber);
            writer.WriteStringValue("EDIPrefix", EDIPrefix);
            writer.WriteStringValue("Email", Email);
            writer.WriteStringValue("Fax", Fax);
            writer.WriteIntValue("Id", Id);
            writer.WriteDateTimeOffsetValue("LastModified", LastModified);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("OrganizationNumber", OrganizationNumber);
            writer.WriteStringValue("OurContact", OurContact);
            writer.WriteStringValue("Phone", Phone);
            writer.WriteStringValue("SalesRegion", SalesRegion);
            writer.WriteIntValue("SupplierNumber", SupplierNumber);
            writer.WriteStringValue("Website", Website);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
