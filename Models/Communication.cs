using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Communication : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The DocumentDeliveryTypes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Documentdeliverytype>? DocumentDeliveryTypes { get; set; }
#nullable restore
#else
        public List<Documentdeliverytype> DocumentDeliveryTypes { get; set; }
#endif
        /// <summary>The Email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The Fax1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fax1 { get; set; }
#nullable restore
#else
        public string Fax1 { get; set; }
#endif
        /// <summary>The Fax2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fax2 { get; set; }
#nullable restore
#else
        public string Fax2 { get; set; }
#endif
        /// <summary>The Internet property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Internet { get; set; }
#nullable restore
#else
        public string Internet { get; set; }
#endif
        /// <summary>The Language property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Communication_Language? Language { get; set; }
#nullable restore
#else
        public Communication_Language Language { get; set; }
#endif
        /// <summary>The Phone1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone1 { get; set; }
#nullable restore
#else
        public string Phone1 { get; set; }
#endif
        /// <summary>The Phone2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone2 { get; set; }
#nullable restore
#else
        public string Phone2 { get; set; }
#endif
        /// <summary>
        /// Instantiates a new communication and sets the default values.
        /// </summary>
        public Communication() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Communication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Communication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"DocumentDeliveryTypes", n => { DocumentDeliveryTypes = n.GetCollectionOfObjectValues<Documentdeliverytype>(Documentdeliverytype.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Email", n => { Email = n.GetStringValue(); } },
                {"Fax1", n => { Fax1 = n.GetStringValue(); } },
                {"Fax2", n => { Fax2 = n.GetStringValue(); } },
                {"Internet", n => { Internet = n.GetStringValue(); } },
                {"Language", n => { Language = n.GetObjectValue<Communication_Language>(Communication_Language.CreateFromDiscriminatorValue); } },
                {"Phone1", n => { Phone1 = n.GetStringValue(); } },
                {"Phone2", n => { Phone2 = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Documentdeliverytype>("DocumentDeliveryTypes", DocumentDeliveryTypes);
            writer.WriteStringValue("Email", Email);
            writer.WriteStringValue("Fax1", Fax1);
            writer.WriteStringValue("Fax2", Fax2);
            writer.WriteStringValue("Internet", Internet);
            writer.WriteObjectValue<Communication_Language>("Language", Language);
            writer.WriteStringValue("Phone1", Phone1);
            writer.WriteStringValue("Phone2", Phone2);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
