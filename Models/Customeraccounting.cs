using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Customeraccounting : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Banking property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Banking? Banking { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Banking Banking { get; set; }
#endif
        /// <summary>The CreditLimit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Amount? CreditLimit { get; set; }
#nullable restore
#else
        public Amount CreditLimit { get; set; }
#endif
        /// <summary>The Invoicing property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Invoicing? Invoicing { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Invoicing Invoicing { get; set; }
#endif
        /// <summary>The IsPurchaseAllowed property</summary>
        public bool? IsPurchaseAllowed { get; set; }
        /// <summary>The Payment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Payment? Payment { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Payment Payment { get; set; }
#endif
        /// <summary>The TransferToAccounting property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Transfertoaccounting? TransferToAccounting { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Transfertoaccounting TransferToAccounting { get; set; }
#endif
        /// <summary>
        /// Instantiates a new customeraccounting and sets the default values.
        /// </summary>
        public Customeraccounting() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Customeraccounting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Customeraccounting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Banking", n => { Banking = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Banking>(Qwips.Core.ClientSdk.Multicase.Models.Banking.CreateFromDiscriminatorValue); } },
                {"CreditLimit", n => { CreditLimit = n.GetObjectValue<Amount>(Amount.CreateFromDiscriminatorValue); } },
                {"Invoicing", n => { Invoicing = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Invoicing>(Qwips.Core.ClientSdk.Multicase.Models.Invoicing.CreateFromDiscriminatorValue); } },
                {"IsPurchaseAllowed", n => { IsPurchaseAllowed = n.GetBoolValue(); } },
                {"Payment", n => { Payment = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Payment>(Qwips.Core.ClientSdk.Multicase.Models.Payment.CreateFromDiscriminatorValue); } },
                {"TransferToAccounting", n => { TransferToAccounting = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Transfertoaccounting>(Qwips.Core.ClientSdk.Multicase.Models.Transfertoaccounting.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Banking>("Banking", Banking);
            writer.WriteObjectValue<Amount>("CreditLimit", CreditLimit);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Invoicing>("Invoicing", Invoicing);
            writer.WriteBoolValue("IsPurchaseAllowed", IsPurchaseAllowed);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Payment>("Payment", Payment);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Transfertoaccounting>("TransferToAccounting", TransferToAccounting);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
