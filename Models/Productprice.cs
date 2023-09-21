using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Productprice : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The BidListPriceID property</summary>
        public int? BidListPriceID { get; set; }
        /// <summary>The BidNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BidNumber { get; set; }
#nullable restore
#else
        public string BidNumber { get; set; }
#endif
        /// <summary>The InPrice property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Inprice? InPrice { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Inprice InPrice { get; set; }
#endif
        /// <summary>The Note property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>The OutPrice property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Outprice? OutPrice { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Outprice OutPrice { get; set; }
#endif
        /// <summary>The Product property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Product? Product { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Product Product { get; set; }
#endif
        /// <summary>The Quantity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Quantity { get; set; }
#nullable restore
#else
        public string Quantity { get; set; }
#endif
        /// <summary>
        /// Instantiates a new productprice and sets the default values.
        /// </summary>
        public Productprice() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Productprice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Productprice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"BidListPriceID", n => { BidListPriceID = n.GetIntValue(); } },
                {"BidNumber", n => { BidNumber = n.GetStringValue(); } },
                {"InPrice", n => { InPrice = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Inprice>(Qwips.Core.ClientSdk.Multicase.Models.Inprice.CreateFromDiscriminatorValue); } },
                {"Note", n => { Note = n.GetStringValue(); } },
                {"OutPrice", n => { OutPrice = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Outprice>(Qwips.Core.ClientSdk.Multicase.Models.Outprice.CreateFromDiscriminatorValue); } },
                {"Product", n => { Product = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Product>(Qwips.Core.ClientSdk.Multicase.Models.Product.CreateFromDiscriminatorValue); } },
                {"Quantity", n => { Quantity = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("BidListPriceID", BidListPriceID);
            writer.WriteStringValue("BidNumber", BidNumber);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Inprice>("InPrice", InPrice);
            writer.WriteStringValue("Note", Note);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Outprice>("OutPrice", OutPrice);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Product>("Product", Product);
            writer.WriteStringValue("Quantity", Quantity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
