using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Ordersordercustomerdeliveryaddress : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AddressLine1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddressLine1 { get; set; }
#nullable restore
#else
        public string AddressLine1 { get; set; }
#endif
        /// <summary>The AddressLine2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddressLine2 { get; set; }
#nullable restore
#else
        public string AddressLine2 { get; set; }
#endif
        /// <summary>The AddressLine3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddressLine3 { get; set; }
#nullable restore
#else
        public string AddressLine3 { get; set; }
#endif
        /// <summary>The City property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>The Country property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
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
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The Phone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>The Zip property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Zip { get; set; }
#nullable restore
#else
        public string Zip { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ordersordercustomerdeliveryaddress and sets the default values.
        /// </summary>
        public Ordersordercustomerdeliveryaddress() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Ordersordercustomerdeliveryaddress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Ordersordercustomerdeliveryaddress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AddressLine1", n => { AddressLine1 = n.GetStringValue(); } },
                {"AddressLine2", n => { AddressLine2 = n.GetStringValue(); } },
                {"AddressLine3", n => { AddressLine3 = n.GetStringValue(); } },
                {"City", n => { City = n.GetStringValue(); } },
                {"Country", n => { Country = n.GetStringValue(); } },
                {"Email", n => { Email = n.GetStringValue(); } },
                {"Fax", n => { Fax = n.GetStringValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"Phone", n => { Phone = n.GetStringValue(); } },
                {"Zip", n => { Zip = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("AddressLine1", AddressLine1);
            writer.WriteStringValue("AddressLine2", AddressLine2);
            writer.WriteStringValue("AddressLine3", AddressLine3);
            writer.WriteStringValue("City", City);
            writer.WriteStringValue("Country", Country);
            writer.WriteStringValue("Email", Email);
            writer.WriteStringValue("Fax", Fax);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("Phone", Phone);
            writer.WriteStringValue("Zip", Zip);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
