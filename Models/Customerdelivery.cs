using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Customerdelivery : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The DaysBeforeDelivery property</summary>
        public int? DaysBeforeDelivery { get; set; }
        /// <summary>The Options property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Deliveryoptions? Options { get; set; }
#nullable restore
#else
        public Deliveryoptions Options { get; set; }
#endif
        /// <summary>The PackingListPriceGroup property</summary>
        public int? PackingListPriceGroup { get; set; }
        /// <summary>The PreferredDeliveryDays property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Deliverydays? PreferredDeliveryDays { get; set; }
#nullable restore
#else
        public Deliverydays PreferredDeliveryDays { get; set; }
#endif
        /// <summary>The PreferredDeliveryWeek property</summary>
        public Deliveryweekenum? PreferredDeliveryWeek { get; set; }
        /// <summary>The ShowPriceOnPackingList property</summary>
        public Priceonpackinglistenum? ShowPriceOnPackingList { get; set; }
        /// <summary>The SpecialFreightTerms property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Specialfreightterm>? SpecialFreightTerms { get; set; }
#nullable restore
#else
        public List<Specialfreightterm> SpecialFreightTerms { get; set; }
#endif
        /// <summary>
        /// Instantiates a new customerdelivery and sets the default values.
        /// </summary>
        public Customerdelivery() {
            AdditionalData = new Dictionary<string, object>();
            PreferredDeliveryWeek = Deliveryweekenum.AllWeeks;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Customerdelivery CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Customerdelivery();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"DaysBeforeDelivery", n => { DaysBeforeDelivery = n.GetIntValue(); } },
                {"Options", n => { Options = n.GetObjectValue<Deliveryoptions>(Deliveryoptions.CreateFromDiscriminatorValue); } },
                {"PackingListPriceGroup", n => { PackingListPriceGroup = n.GetIntValue(); } },
                {"PreferredDeliveryDays", n => { PreferredDeliveryDays = n.GetObjectValue<Deliverydays>(Deliverydays.CreateFromDiscriminatorValue); } },
                {"PreferredDeliveryWeek", n => { PreferredDeliveryWeek = n.GetEnumValue<Deliveryweekenum>(); } },
                {"ShowPriceOnPackingList", n => { ShowPriceOnPackingList = n.GetEnumValue<Priceonpackinglistenum>(); } },
                {"SpecialFreightTerms", n => { SpecialFreightTerms = n.GetCollectionOfObjectValues<Specialfreightterm>(Specialfreightterm.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("DaysBeforeDelivery", DaysBeforeDelivery);
            writer.WriteObjectValue<Deliveryoptions>("Options", Options);
            writer.WriteIntValue("PackingListPriceGroup", PackingListPriceGroup);
            writer.WriteObjectValue<Deliverydays>("PreferredDeliveryDays", PreferredDeliveryDays);
            writer.WriteEnumValue<Deliveryweekenum>("PreferredDeliveryWeek", PreferredDeliveryWeek);
            writer.WriteEnumValue<Priceonpackinglistenum>("ShowPriceOnPackingList", ShowPriceOnPackingList);
            writer.WriteCollectionOfObjectValues<Specialfreightterm>("SpecialFreightTerms", SpecialFreightTerms);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
