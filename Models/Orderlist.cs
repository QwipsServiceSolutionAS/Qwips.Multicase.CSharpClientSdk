using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Orderlist : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CustomerID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? CustomerID { get; set; }
#nullable restore
#else
        public List<int?> CustomerID { get; set; }
#endif
        /// <summary>The CustomerNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? CustomerNumber { get; set; }
#nullable restore
#else
        public List<int?> CustomerNumber { get; set; }
#endif
        /// <summary>The DateFrom property</summary>
        public DateTimeOffset? DateFrom { get; set; }
        /// <summary>The DateTo property</summary>
        public DateTimeOffset? DateTo { get; set; }
        /// <summary>The OnlyOpen property</summary>
        public bool? OnlyOpen { get; set; }
        /// <summary>
        /// Instantiates a new Orderlist and sets the default values.
        /// </summary>
        public Orderlist() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderlist CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderlist();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CustomerID", n => { CustomerID = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                {"CustomerNumber", n => { CustomerNumber = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                {"DateFrom", n => { DateFrom = n.GetDateTimeOffsetValue(); } },
                {"DateTo", n => { DateTo = n.GetDateTimeOffsetValue(); } },
                {"OnlyOpen", n => { OnlyOpen = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<int?>("CustomerID", CustomerID);
            writer.WriteCollectionOfPrimitiveValues<int?>("CustomerNumber", CustomerNumber);
            writer.WriteDateTimeOffsetValue("DateFrom", DateFrom);
            writer.WriteDateTimeOffsetValue("DateTo", DateTo);
            writer.WriteBoolValue("OnlyOpen", OnlyOpen);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
