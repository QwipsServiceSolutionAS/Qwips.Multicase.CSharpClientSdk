using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Orderstatusresponse_recipient : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Address1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address1 { get; set; }
#nullable restore
#else
        public string Address1 { get; set; }
#endif
        /// <summary>The Address2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address2 { get; set; }
#nullable restore
#else
        public string Address2 { get; set; }
#endif
        /// <summary>The Address3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address3 { get; set; }
#nullable restore
#else
        public string Address3 { get; set; }
#endif
        /// <summary>The Attention property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Attention { get; set; }
#nullable restore
#else
        public string Attention { get; set; }
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
        /// <summary>The CustomerNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerNumber { get; set; }
#nullable restore
#else
        public string CustomerNumber { get; set; }
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
        /// <summary>The GLN property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GLN { get; set; }
#nullable restore
#else
        public string GLN { get; set; }
#endif
        /// <summary>The MobilePhone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MobilePhone { get; set; }
#nullable restore
#else
        public string MobilePhone { get; set; }
#endif
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The PhoneNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber { get; set; }
#nullable restore
#else
        public string PhoneNumber { get; set; }
#endif
        /// <summary>The ZipCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ZipCode { get; set; }
#nullable restore
#else
        public string ZipCode { get; set; }
#endif
        /// <summary>
        /// Instantiates a new orderstatusresponse_recipient and sets the default values.
        /// </summary>
        public Orderstatusresponse_recipient() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderstatusresponse_recipient CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderstatusresponse_recipient();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Address1", n => { Address1 = n.GetStringValue(); } },
                {"Address2", n => { Address2 = n.GetStringValue(); } },
                {"Address3", n => { Address3 = n.GetStringValue(); } },
                {"Attention", n => { Attention = n.GetStringValue(); } },
                {"City", n => { City = n.GetStringValue(); } },
                {"Country", n => { Country = n.GetStringValue(); } },
                {"CustomerNumber", n => { CustomerNumber = n.GetStringValue(); } },
                {"Email", n => { Email = n.GetStringValue(); } },
                {"Fax", n => { Fax = n.GetStringValue(); } },
                {"GLN", n => { GLN = n.GetStringValue(); } },
                {"MobilePhone", n => { MobilePhone = n.GetStringValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"PhoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"ZipCode", n => { ZipCode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Address1", Address1);
            writer.WriteStringValue("Address2", Address2);
            writer.WriteStringValue("Address3", Address3);
            writer.WriteStringValue("Attention", Attention);
            writer.WriteStringValue("City", City);
            writer.WriteStringValue("Country", Country);
            writer.WriteStringValue("CustomerNumber", CustomerNumber);
            writer.WriteStringValue("Email", Email);
            writer.WriteStringValue("Fax", Fax);
            writer.WriteStringValue("GLN", GLN);
            writer.WriteStringValue("MobilePhone", MobilePhone);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("PhoneNumber", PhoneNumber);
            writer.WriteStringValue("ZipCode", ZipCode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
