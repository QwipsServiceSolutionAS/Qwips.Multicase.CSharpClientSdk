using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Deliveryoptions : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CompleteDelivery property</summary>
        public bool? CompleteDelivery { get; set; }
        /// <summary>The PreferredFreightMethod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Deliveryoptions_PreferredFreightMethod? PreferredFreightMethod { get; set; }
#nullable restore
#else
        public Deliveryoptions_PreferredFreightMethod PreferredFreightMethod { get; set; }
#endif
        /// <summary>The PreferredStorageArea property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Storagearea? PreferredStorageArea { get; set; }
#nullable restore
#else
        public Storagearea PreferredStorageArea { get; set; }
#endif
        /// <summary>The PrintPackingList property</summary>
        public bool? PrintPackingList { get; set; }
        /// <summary>The ShowRemainingOnPackingList property</summary>
        public bool? ShowRemainingOnPackingList { get; set; }
        /// <summary>The ShowSerialNumbersOnDeliveryConfirmation property</summary>
        public bool? ShowSerialNumbersOnDeliveryConfirmation { get; set; }
        /// <summary>
        /// Instantiates a new deliveryoptions and sets the default values.
        /// </summary>
        public Deliveryoptions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Deliveryoptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Deliveryoptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CompleteDelivery", n => { CompleteDelivery = n.GetBoolValue(); } },
                {"PreferredFreightMethod", n => { PreferredFreightMethod = n.GetObjectValue<Deliveryoptions_PreferredFreightMethod>(Deliveryoptions_PreferredFreightMethod.CreateFromDiscriminatorValue); } },
                {"PreferredStorageArea", n => { PreferredStorageArea = n.GetObjectValue<Storagearea>(Storagearea.CreateFromDiscriminatorValue); } },
                {"PrintPackingList", n => { PrintPackingList = n.GetBoolValue(); } },
                {"ShowRemainingOnPackingList", n => { ShowRemainingOnPackingList = n.GetBoolValue(); } },
                {"ShowSerialNumbersOnDeliveryConfirmation", n => { ShowSerialNumbersOnDeliveryConfirmation = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("CompleteDelivery", CompleteDelivery);
            writer.WriteObjectValue<Deliveryoptions_PreferredFreightMethod>("PreferredFreightMethod", PreferredFreightMethod);
            writer.WriteObjectValue<Storagearea>("PreferredStorageArea", PreferredStorageArea);
            writer.WriteBoolValue("PrintPackingList", PrintPackingList);
            writer.WriteBoolValue("ShowRemainingOnPackingList", ShowRemainingOnPackingList);
            writer.WriteBoolValue("ShowSerialNumbersOnDeliveryConfirmation", ShowSerialNumbersOnDeliveryConfirmation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
