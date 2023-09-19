using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Customeragreements : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Discount property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Customerdiscount? Discount { get; set; }
#nullable restore
#else
        public Customerdiscount Discount { get; set; }
#endif
        /// <summary>The ReferencedByCustomerID property</summary>
        public int? ReferencedByCustomerID { get; set; }
        /// <summary>The Requirements property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Customerrequirements? Requirements { get; set; }
#nullable restore
#else
        public Customerrequirements Requirements { get; set; }
#endif
        /// <summary>The SpecialFeeExcempt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Excemptspecialfee? SpecialFeeExcempt { get; set; }
#nullable restore
#else
        public Excemptspecialfee SpecialFeeExcempt { get; set; }
#endif
        /// <summary>
        /// Instantiates a new customeragreements and sets the default values.
        /// </summary>
        public Customeragreements() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Customeragreements CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Customeragreements();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Discount", n => { Discount = n.GetObjectValue<Customerdiscount>(Customerdiscount.CreateFromDiscriminatorValue); } },
                {"ReferencedByCustomerID", n => { ReferencedByCustomerID = n.GetIntValue(); } },
                {"Requirements", n => { Requirements = n.GetObjectValue<Customerrequirements>(Customerrequirements.CreateFromDiscriminatorValue); } },
                {"SpecialFeeExcempt", n => { SpecialFeeExcempt = n.GetObjectValue<Excemptspecialfee>(Excemptspecialfee.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Customerdiscount>("Discount", Discount);
            writer.WriteIntValue("ReferencedByCustomerID", ReferencedByCustomerID);
            writer.WriteObjectValue<Customerrequirements>("Requirements", Requirements);
            writer.WriteObjectValue<Excemptspecialfee>("SpecialFeeExcempt", SpecialFeeExcempt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
