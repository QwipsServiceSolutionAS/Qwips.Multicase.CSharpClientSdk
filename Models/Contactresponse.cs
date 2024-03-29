using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Contactresponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ContactId property</summary>
        public int? ContactId { get; set; }
        /// <summary>The CustomerId property</summary>
        public int? CustomerId { get; set; }
        /// <summary>The CustomerNumber property</summary>
        public int? CustomerNumber { get; set; }
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
        /// <summary>The FirstName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>The Functions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Functions { get; set; }
#nullable restore
#else
        public List<string> Functions { get; set; }
#endif
        /// <summary>The Information property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Information { get; set; }
#nullable restore
#else
        public string Information { get; set; }
#endif
        /// <summary>The Interests property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Interests { get; set; }
#nullable restore
#else
        public List<string> Interests { get; set; }
#endif
        /// <summary>The KommId property</summary>
        public int? KommId { get; set; }
        /// <summary>The LastModified property</summary>
        public DateTimeOffset? LastModified { get; set; }
        /// <summary>The LastName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>The Mobile property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mobile { get; set; }
#nullable restore
#else
        public string Mobile { get; set; }
#endif
        /// <summary>The Phone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>The Title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Contactresponse and sets the default values.
        /// </summary>
        public Contactresponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Contactresponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Contactresponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ContactId", n => { ContactId = n.GetIntValue(); } },
                {"CustomerId", n => { CustomerId = n.GetIntValue(); } },
                {"CustomerNumber", n => { CustomerNumber = n.GetIntValue(); } },
                {"Email", n => { Email = n.GetStringValue(); } },
                {"Fax", n => { Fax = n.GetStringValue(); } },
                {"FirstName", n => { FirstName = n.GetStringValue(); } },
                {"Functions", n => { Functions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"Information", n => { Information = n.GetStringValue(); } },
                {"Interests", n => { Interests = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"KommId", n => { KommId = n.GetIntValue(); } },
                {"LastModified", n => { LastModified = n.GetDateTimeOffsetValue(); } },
                {"LastName", n => { LastName = n.GetStringValue(); } },
                {"Mobile", n => { Mobile = n.GetStringValue(); } },
                {"Phone", n => { Phone = n.GetStringValue(); } },
                {"Title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("ContactId", ContactId);
            writer.WriteIntValue("CustomerId", CustomerId);
            writer.WriteIntValue("CustomerNumber", CustomerNumber);
            writer.WriteStringValue("Email", Email);
            writer.WriteStringValue("Fax", Fax);
            writer.WriteStringValue("FirstName", FirstName);
            writer.WriteCollectionOfPrimitiveValues<string>("Functions", Functions);
            writer.WriteStringValue("Information", Information);
            writer.WriteCollectionOfPrimitiveValues<string>("Interests", Interests);
            writer.WriteIntValue("KommId", KommId);
            writer.WriteDateTimeOffsetValue("LastModified", LastModified);
            writer.WriteStringValue("LastName", LastName);
            writer.WriteStringValue("Mobile", Mobile);
            writer.WriteStringValue("Phone", Phone);
            writer.WriteStringValue("Title", Title);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
