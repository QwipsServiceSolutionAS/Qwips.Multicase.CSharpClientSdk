using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Packagereceiver1 : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Address2? Address { get; set; }
#nullable restore
#else
        public Address2 Address { get; set; }
#endif
        /// <summary>The Attention property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Attention { get; set; }
#nullable restore
#else
        public string Attention { get; set; }
#endif
        /// <summary>The CellPhone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CellPhone { get; set; }
#nullable restore
#else
        public string CellPhone { get; set; }
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
        /// <summary>The GLN property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GLN { get; set; }
#nullable restore
#else
        public string GLN { get; set; }
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
        /// <summary>The PostalAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Postaladdress2? PostalAddress { get; set; }
#nullable restore
#else
        public Postaladdress2 PostalAddress { get; set; }
#endif
        /// <summary>The UseNeutralPackingslip property</summary>
        public bool? UseNeutralPackingslip { get; set; }
        /// <summary>
        /// Instantiates a new packagereceiver1 and sets the default values.
        /// </summary>
        public Packagereceiver1() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Packagereceiver1 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Packagereceiver1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Address", n => { Address = n.GetObjectValue<Address2>(Address2.CreateFromDiscriminatorValue); } },
                {"Attention", n => { Attention = n.GetStringValue(); } },
                {"CellPhone", n => { CellPhone = n.GetStringValue(); } },
                {"Country", n => { Country = n.GetStringValue(); } },
                {"Email", n => { Email = n.GetStringValue(); } },
                {"Fax", n => { Fax = n.GetStringValue(); } },
                {"GLN", n => { GLN = n.GetStringValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"Phone", n => { Phone = n.GetStringValue(); } },
                {"PostalAddress", n => { PostalAddress = n.GetObjectValue<Postaladdress2>(Postaladdress2.CreateFromDiscriminatorValue); } },
                {"UseNeutralPackingslip", n => { UseNeutralPackingslip = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Address2>("Address", Address);
            writer.WriteStringValue("Attention", Attention);
            writer.WriteStringValue("CellPhone", CellPhone);
            writer.WriteStringValue("Country", Country);
            writer.WriteStringValue("Email", Email);
            writer.WriteStringValue("Fax", Fax);
            writer.WriteStringValue("GLN", GLN);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("Phone", Phone);
            writer.WriteObjectValue<Postaladdress2>("PostalAddress", PostalAddress);
            writer.WriteBoolValue("UseNeutralPackingslip", UseNeutralPackingslip);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}