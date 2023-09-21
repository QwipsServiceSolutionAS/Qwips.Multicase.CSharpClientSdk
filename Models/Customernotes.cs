using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Customernotes : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CreditNote property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreditNote { get; set; }
#nullable restore
#else
        public string CreditNote { get; set; }
#endif
        /// <summary>The Economy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Economy { get; set; }
#nullable restore
#else
        public string Economy { get; set; }
#endif
        /// <summary>The Invoice property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Invoice { get; set; }
#nullable restore
#else
        public string Invoice { get; set; }
#endif
        /// <summary>The Note property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>The PickingList property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PickingList { get; set; }
#nullable restore
#else
        public string PickingList { get; set; }
#endif
        /// <summary>The Sales property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sales { get; set; }
#nullable restore
#else
        public string Sales { get; set; }
#endif
        /// <summary>
        /// Instantiates a new customernotes and sets the default values.
        /// </summary>
        public Customernotes() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Customernotes CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Customernotes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CreditNote", n => { CreditNote = n.GetStringValue(); } },
                {"Economy", n => { Economy = n.GetStringValue(); } },
                {"Invoice", n => { Invoice = n.GetStringValue(); } },
                {"Note", n => { Note = n.GetStringValue(); } },
                {"PickingList", n => { PickingList = n.GetStringValue(); } },
                {"Sales", n => { Sales = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("CreditNote", CreditNote);
            writer.WriteStringValue("Economy", Economy);
            writer.WriteStringValue("Invoice", Invoice);
            writer.WriteStringValue("Note", Note);
            writer.WriteStringValue("PickingList", PickingList);
            writer.WriteStringValue("Sales", Sales);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
