using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Orderstatusresponse_deletedorder : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The DateOfAction property</summary>
        public DateTimeOffset? DateOfAction { get; set; }
        /// <summary>The DeletedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeletedBy { get; set; }
#nullable restore
#else
        public string DeletedBy { get; set; }
#endif
        /// <summary>The DeletionConfirmed property</summary>
        public bool? DeletionConfirmed { get; set; }
        /// <summary>The HostName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HostName { get; set; }
#nullable restore
#else
        public string HostName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new orderstatusresponse_deletedorder and sets the default values.
        /// </summary>
        public Orderstatusresponse_deletedorder() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderstatusresponse_deletedorder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderstatusresponse_deletedorder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"DateOfAction", n => { DateOfAction = n.GetDateTimeOffsetValue(); } },
                {"DeletedBy", n => { DeletedBy = n.GetStringValue(); } },
                {"DeletionConfirmed", n => { DeletionConfirmed = n.GetBoolValue(); } },
                {"HostName", n => { HostName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("DateOfAction", DateOfAction);
            writer.WriteStringValue("DeletedBy", DeletedBy);
            writer.WriteBoolValue("DeletionConfirmed", DeletionConfirmed);
            writer.WriteStringValue("HostName", HostName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
