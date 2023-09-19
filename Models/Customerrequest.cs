using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Customerrequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
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
        /// <summary>The Phone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>The Website property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Website { get; set; }
#nullable restore
#else
        public string Website { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Customerrequest and sets the default values.
        /// </summary>
        public Customerrequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Customerrequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Customerrequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"EDIPrefix", n => { EDIPrefix = n.GetStringValue(); } },
                {"Email", n => { Email = n.GetStringValue(); } },
                {"Fax", n => { Fax = n.GetStringValue(); } },
                {"Id", n => { Id = n.GetIntValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"OrganizationNumber", n => { OrganizationNumber = n.GetStringValue(); } },
                {"Phone", n => { Phone = n.GetStringValue(); } },
                {"Website", n => { Website = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("EDIPrefix", EDIPrefix);
            writer.WriteStringValue("Email", Email);
            writer.WriteStringValue("Fax", Fax);
            writer.WriteIntValue("Id", Id);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("OrganizationNumber", OrganizationNumber);
            writer.WriteStringValue("Phone", Phone);
            writer.WriteStringValue("Website", Website);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
