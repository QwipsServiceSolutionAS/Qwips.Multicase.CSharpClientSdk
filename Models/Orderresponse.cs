using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Orderresponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Head property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderhead? Head { get; set; }
#nullable restore
#else
        public Orderhead Head { get; set; }
#endif
        /// <summary>The Messages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Ordermessages1? Messages { get; set; }
#nullable restore
#else
        public Ordermessages1 Messages { get; set; }
#endif
        /// <summary>The OrderLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderlinescontainer? OrderLines { get; set; }
#nullable restore
#else
        public Orderlinescontainer OrderLines { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Orderresponse and sets the default values.
        /// </summary>
        public Orderresponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderresponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderresponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Head", n => { Head = n.GetObjectValue<Orderhead>(Orderhead.CreateFromDiscriminatorValue); } },
                {"Messages", n => { Messages = n.GetObjectValue<Ordermessages1>(Ordermessages1.CreateFromDiscriminatorValue); } },
                {"OrderLines", n => { OrderLines = n.GetObjectValue<Orderlinescontainer>(Orderlinescontainer.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Orderhead>("Head", Head);
            writer.WriteObjectValue<Ordermessages1>("Messages", Messages);
            writer.WriteObjectValue<Orderlinescontainer>("OrderLines", OrderLines);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
