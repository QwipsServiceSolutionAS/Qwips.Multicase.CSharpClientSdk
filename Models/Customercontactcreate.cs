using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Customercontactcreate : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CustomerID property</summary>
        public int? CustomerID { get; set; }
        /// <summary>The EMail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EMail { get; set; }
#nullable restore
#else
        public string EMail { get; set; }
#endif
        /// <summary>The FirstName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>The Information property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Information { get; set; }
#nullable restore
#else
        public string Information { get; set; }
#endif
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
        /// Instantiates a new Customercontactcreate and sets the default values.
        /// </summary>
        public Customercontactcreate() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Customercontactcreate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Customercontactcreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CustomerID", n => { CustomerID = n.GetIntValue(); } },
                {"EMail", n => { EMail = n.GetStringValue(); } },
                {"FirstName", n => { FirstName = n.GetStringValue(); } },
                {"Information", n => { Information = n.GetStringValue(); } },
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
            writer.WriteIntValue("CustomerID", CustomerID);
            writer.WriteStringValue("EMail", EMail);
            writer.WriteStringValue("FirstName", FirstName);
            writer.WriteStringValue("Information", Information);
            writer.WriteStringValue("LastName", LastName);
            writer.WriteStringValue("Mobile", Mobile);
            writer.WriteStringValue("Phone", Phone);
            writer.WriteStringValue("Title", Title);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
