using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Bid : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Automatic property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Automatic { get; set; }
#nullable restore
#else
        public string Automatic { get; set; }
#endif
        /// <summary>The BidID property</summary>
        public int? BidID { get; set; }
        /// <summary>The FromDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromDate { get; set; }
#nullable restore
#else
        public string FromDate { get; set; }
#endif
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The Products property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Products? Products { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Products Products { get; set; }
#endif
        /// <summary>The Supplier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Supplier? Supplier { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Supplier Supplier { get; set; }
#endif
        /// <summary>The ToDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ToDate { get; set; }
#nullable restore
#else
        public string ToDate { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Bid and sets the default values.
        /// </summary>
        public Bid() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Bid CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Bid();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Automatic", n => { Automatic = n.GetStringValue(); } },
                {"BidID", n => { BidID = n.GetIntValue(); } },
                {"FromDate", n => { FromDate = n.GetStringValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"Products", n => { Products = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Products>(Qwips.Core.ClientSdk.Multicase.Models.Products.CreateFromDiscriminatorValue); } },
                {"Supplier", n => { Supplier = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Supplier>(Qwips.Core.ClientSdk.Multicase.Models.Supplier.CreateFromDiscriminatorValue); } },
                {"ToDate", n => { ToDate = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Automatic", Automatic);
            writer.WriteIntValue("BidID", BidID);
            writer.WriteStringValue("FromDate", FromDate);
            writer.WriteStringValue("Name", Name);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Products>("Products", Products);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Supplier>("Supplier", Supplier);
            writer.WriteStringValue("ToDate", ToDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
