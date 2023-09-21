using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Specialfreightterm : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The FixedShippingCharges property</summary>
        public double? FixedShippingCharges { get; set; }
        /// <summary>The Freight property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Freight? Freight { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Freight Freight { get; set; }
#endif
        /// <summary>The FreightPaid property</summary>
        public bool? FreightPaid { get; set; }
        /// <summary>The FreightPercentOfValue property</summary>
        public double? FreightPercentOfValue { get; set; }
        /// <summary>The MinOrderAmount property</summary>
        public double? MinOrderAmount { get; set; }
        /// <summary>The ValidFrom property</summary>
        public DateTimeOffset? ValidFrom { get; set; }
        /// <summary>The ValidTo property</summary>
        public DateTimeOffset? ValidTo { get; set; }
        /// <summary>
        /// Instantiates a new specialfreightterm and sets the default values.
        /// </summary>
        public Specialfreightterm() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Specialfreightterm CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Specialfreightterm();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"FixedShippingCharges", n => { FixedShippingCharges = n.GetDoubleValue(); } },
                {"Freight", n => { Freight = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Freight>(Qwips.Core.ClientSdk.Multicase.Models.Freight.CreateFromDiscriminatorValue); } },
                {"FreightPaid", n => { FreightPaid = n.GetBoolValue(); } },
                {"FreightPercentOfValue", n => { FreightPercentOfValue = n.GetDoubleValue(); } },
                {"MinOrderAmount", n => { MinOrderAmount = n.GetDoubleValue(); } },
                {"ValidFrom", n => { ValidFrom = n.GetDateTimeOffsetValue(); } },
                {"ValidTo", n => { ValidTo = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("FixedShippingCharges", FixedShippingCharges);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Freight>("Freight", Freight);
            writer.WriteBoolValue("FreightPaid", FreightPaid);
            writer.WriteDoubleValue("FreightPercentOfValue", FreightPercentOfValue);
            writer.WriteDoubleValue("MinOrderAmount", MinOrderAmount);
            writer.WriteDateTimeOffsetValue("ValidFrom", ValidFrom);
            writer.WriteDateTimeOffsetValue("ValidTo", ValidTo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
