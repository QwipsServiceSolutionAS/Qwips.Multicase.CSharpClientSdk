using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Orderupdate : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Head property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderhead1? Head { get; set; }
#nullable restore
#else
        public Orderhead1 Head { get; set; }
#endif
        /// <summary>The Messages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Ordermessages2? Messages { get; set; }
#nullable restore
#else
        public Ordermessages2 Messages { get; set; }
#endif
        /// <summary>The OrderLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Orderlinescontainer1? OrderLines { get; set; }
#nullable restore
#else
        public Orderlinescontainer1 OrderLines { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Orderupdate and sets the default values.
        /// </summary>
        public Orderupdate() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderupdate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderupdate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Head", n => { Head = n.GetObjectValue<Orderhead1>(Orderhead1.CreateFromDiscriminatorValue); } },
                {"Messages", n => { Messages = n.GetObjectValue<Ordermessages2>(Ordermessages2.CreateFromDiscriminatorValue); } },
                {"OrderLines", n => { OrderLines = n.GetObjectValue<Orderlinescontainer1>(Orderlinescontainer1.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Orderhead1>("Head", Head);
            writer.WriteObjectValue<Ordermessages2>("Messages", Messages);
            writer.WriteObjectValue<Orderlinescontainer1>("OrderLines", OrderLines);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
