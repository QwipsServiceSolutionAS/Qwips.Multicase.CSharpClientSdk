using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Productrma : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Cause property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Cause { get; set; }
#nullable restore
#else
        public string Cause { get; set; }
#endif
        /// <summary>The Handling property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Handling { get; set; }
#nullable restore
#else
        public string Handling { get; set; }
#endif
        /// <summary>The InvoiceNumber property</summary>
        public int? InvoiceNumber { get; set; }
        /// <summary>The Position property</summary>
        public int? Position { get; set; }
        /// <summary>The ProductNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductNumber { get; set; }
#nullable restore
#else
        public string ProductNumber { get; set; }
#endif
        /// <summary>The Quantity property</summary>
        public double? Quantity { get; set; }
        /// <summary>
        /// Instantiates a new Productrma and sets the default values.
        /// </summary>
        public Productrma() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Productrma CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Productrma();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Cause", n => { Cause = n.GetStringValue(); } },
                {"Handling", n => { Handling = n.GetStringValue(); } },
                {"InvoiceNumber", n => { InvoiceNumber = n.GetIntValue(); } },
                {"Position", n => { Position = n.GetIntValue(); } },
                {"ProductNumber", n => { ProductNumber = n.GetStringValue(); } },
                {"Quantity", n => { Quantity = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Cause", Cause);
            writer.WriteStringValue("Handling", Handling);
            writer.WriteIntValue("InvoiceNumber", InvoiceNumber);
            writer.WriteIntValue("Position", Position);
            writer.WriteStringValue("ProductNumber", ProductNumber);
            writer.WriteDoubleValue("Quantity", Quantity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
