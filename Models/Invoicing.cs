using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Invoicing : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CreditNoteFormat property</summary>
        public Invoiceformatenum? CreditNoteFormat { get; set; }
        /// <summary>The FactoringUsed property</summary>
        public bool? FactoringUsed { get; set; }
        /// <summary>The InvoiceFormat property</summary>
        public Invoiceformatenum? InvoiceFormat { get; set; }
        /// <summary>The MonthlyCombinedInvoicing property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Monthlycombinedinvoicing? MonthlyCombinedInvoicing { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Monthlycombinedinvoicing MonthlyCombinedInvoicing { get; set; }
#endif
        /// <summary>The ScheduleType property</summary>
        public Invoicescheduletypeenum? ScheduleType { get; set; }
        /// <summary>The WeeklyCombinedInvoicing property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Weeklycombinedinvoicing? WeeklyCombinedInvoicing { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Weeklycombinedinvoicing WeeklyCombinedInvoicing { get; set; }
#endif
        /// <summary>
        /// Instantiates a new invoicing and sets the default values.
        /// </summary>
        public Invoicing() {
            AdditionalData = new Dictionary<string, object>();
            ScheduleType = Invoicescheduletypeenum.Continuous;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Invoicing CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Invoicing();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CreditNoteFormat", n => { CreditNoteFormat = n.GetEnumValue<Invoiceformatenum>(); } },
                {"FactoringUsed", n => { FactoringUsed = n.GetBoolValue(); } },
                {"InvoiceFormat", n => { InvoiceFormat = n.GetEnumValue<Invoiceformatenum>(); } },
                {"MonthlyCombinedInvoicing", n => { MonthlyCombinedInvoicing = n.GetObjectValue<Qwips.Core.MultiCase.Models.Monthlycombinedinvoicing>(Qwips.Core.MultiCase.Models.Monthlycombinedinvoicing.CreateFromDiscriminatorValue); } },
                {"ScheduleType", n => { ScheduleType = n.GetEnumValue<Invoicescheduletypeenum>(); } },
                {"WeeklyCombinedInvoicing", n => { WeeklyCombinedInvoicing = n.GetObjectValue<Qwips.Core.MultiCase.Models.Weeklycombinedinvoicing>(Qwips.Core.MultiCase.Models.Weeklycombinedinvoicing.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Invoiceformatenum>("CreditNoteFormat", CreditNoteFormat);
            writer.WriteBoolValue("FactoringUsed", FactoringUsed);
            writer.WriteEnumValue<Invoiceformatenum>("InvoiceFormat", InvoiceFormat);
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Monthlycombinedinvoicing>("MonthlyCombinedInvoicing", MonthlyCombinedInvoicing);
            writer.WriteEnumValue<Invoicescheduletypeenum>("ScheduleType", ScheduleType);
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Weeklycombinedinvoicing>("WeeklyCombinedInvoicing", WeeklyCombinedInvoicing);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
