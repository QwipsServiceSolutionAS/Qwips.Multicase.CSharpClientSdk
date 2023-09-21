using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Customerdiscount : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The FixedRate property</summary>
        public double? FixedRate { get; set; }
        /// <summary>The FromDate property</summary>
        public DateTimeOffset? FromDate { get; set; }
        /// <summary>The Payout property</summary>
        public Customerpayoutenum? Payout { get; set; }
        /// <summary>The ToDate property</summary>
        public DateTimeOffset? ToDate { get; set; }
        /// <summary>
        /// Instantiates a new customerdiscount and sets the default values.
        /// </summary>
        public Customerdiscount() {
            AdditionalData = new Dictionary<string, object>();
            Payout = Customerpayoutenum.None;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Customerdiscount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Customerdiscount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"FixedRate", n => { FixedRate = n.GetDoubleValue(); } },
                {"FromDate", n => { FromDate = n.GetDateTimeOffsetValue(); } },
                {"Payout", n => { Payout = n.GetEnumValue<Customerpayoutenum>(); } },
                {"ToDate", n => { ToDate = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("FixedRate", FixedRate);
            writer.WriteDateTimeOffsetValue("FromDate", FromDate);
            writer.WriteEnumValue<Customerpayoutenum>("Payout", Payout);
            writer.WriteDateTimeOffsetValue("ToDate", ToDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
