using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Bidupsertresult : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Errors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Generalapierror>? Errors { get; set; }
#nullable restore
#else
        public List<Generalapierror> Errors { get; set; }
#endif
        /// <summary>The Ok property</summary>
        public bool? Ok { get; set; }
        /// <summary>The UpdatedBids property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Upsertedbid>? UpdatedBids { get; set; }
#nullable restore
#else
        public List<Upsertedbid> UpdatedBids { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Bidupsertresult and sets the default values.
        /// </summary>
        public Bidupsertresult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Bidupsertresult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Bidupsertresult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Errors", n => { Errors = n.GetCollectionOfObjectValues<Generalapierror>(Generalapierror.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Ok", n => { Ok = n.GetBoolValue(); } },
                {"UpdatedBids", n => { UpdatedBids = n.GetCollectionOfObjectValues<Upsertedbid>(Upsertedbid.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Generalapierror>("Errors", Errors);
            writer.WriteBoolValue("Ok", Ok);
            writer.WriteCollectionOfObjectValues<Upsertedbid>("UpdatedBids", UpdatedBids);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
