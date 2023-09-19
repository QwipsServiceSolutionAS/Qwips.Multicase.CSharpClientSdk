using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Documentdeliverytype : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Copies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Documentdelivery>? Copies { get; set; }
#nullable restore
#else
        public List<Documentdelivery> Copies { get; set; }
#endif
        /// <summary>The Original property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Documentdelivery? Original { get; set; }
#nullable restore
#else
        public Documentdelivery Original { get; set; }
#endif
        /// <summary>The ReportType property</summary>
        public Reporttypeenum? ReportType { get; set; }
        /// <summary>The SendCopyToContact property</summary>
        public bool? SendCopyToContact { get; set; }
        /// <summary>
        /// Instantiates a new documentdeliverytype and sets the default values.
        /// </summary>
        public Documentdeliverytype() {
            AdditionalData = new Dictionary<string, object>();
            ReportType = Reporttypeenum.None;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Documentdeliverytype CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Documentdeliverytype();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Copies", n => { Copies = n.GetCollectionOfObjectValues<Documentdelivery>(Documentdelivery.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Original", n => { Original = n.GetObjectValue<Documentdelivery>(Documentdelivery.CreateFromDiscriminatorValue); } },
                {"ReportType", n => { ReportType = n.GetEnumValue<Reporttypeenum>(); } },
                {"SendCopyToContact", n => { SendCopyToContact = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Documentdelivery>("Copies", Copies);
            writer.WriteObjectValue<Documentdelivery>("Original", Original);
            writer.WriteEnumValue<Reporttypeenum>("ReportType", ReportType);
            writer.WriteBoolValue("SendCopyToContact", SendCopyToContact);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
