using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Orderlinedelivery : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Carrier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Carrier { get; set; }
#nullable restore
#else
        public string Carrier { get; set; }
#endif
        /// <summary>The CarrierID property</summary>
        public int? CarrierID { get; set; }
        /// <summary>The CarrierWebAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CarrierWebAddress { get; set; }
#nullable restore
#else
        public string CarrierWebAddress { get; set; }
#endif
        /// <summary>The DateOfAction property</summary>
        public DateTimeOffset? DateOfAction { get; set; }
        /// <summary>The InvoicedQuantity property</summary>
        public double? InvoicedQuantity { get; set; }
        /// <summary>The InvoiceNumber property</summary>
        public int? InvoiceNumber { get; set; }
        /// <summary>The PackageLines property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Orderstatusresponse_packageline>? PackageLines { get; set; }
#nullable restore
#else
        public List<Orderstatusresponse_packageline> PackageLines { get; set; }
#endif
        /// <summary>The PackageReference property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackageReference { get; set; }
#nullable restore
#else
        public string PackageReference { get; set; }
#endif
        /// <summary>The PackingSlipID property</summary>
        public int? PackingSlipID { get; set; }
        /// <summary>The PackingSlipNumber property</summary>
        public int? PackingSlipNumber { get; set; }
        /// <summary>The PickingListID property</summary>
        public int? PickingListID { get; set; }
        /// <summary>The Position property</summary>
        public int? Position { get; set; }
        /// <summary>The SerialNumbers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Orderstatusresponse_orderlineserialnumber>? SerialNumbers { get; set; }
#nullable restore
#else
        public List<Orderstatusresponse_orderlineserialnumber> SerialNumbers { get; set; }
#endif
        /// <summary>The TaxPercent property</summary>
        public double? TaxPercent { get; set; }
        /// <summary>The TrackingUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TrackingUrl { get; set; }
#nullable restore
#else
        public string TrackingUrl { get; set; }
#endif
        /// <summary>The UnitPrice property</summary>
        public double? UnitPrice { get; set; }
        /// <summary>The UnitPriceTax property</summary>
        public double? UnitPriceTax { get; set; }
        /// <summary>
        /// Instantiates a new orderlinedelivery and sets the default values.
        /// </summary>
        public Orderlinedelivery() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderlinedelivery CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderlinedelivery();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Carrier", n => { Carrier = n.GetStringValue(); } },
                {"CarrierID", n => { CarrierID = n.GetIntValue(); } },
                {"CarrierWebAddress", n => { CarrierWebAddress = n.GetStringValue(); } },
                {"DateOfAction", n => { DateOfAction = n.GetDateTimeOffsetValue(); } },
                {"InvoicedQuantity", n => { InvoicedQuantity = n.GetDoubleValue(); } },
                {"InvoiceNumber", n => { InvoiceNumber = n.GetIntValue(); } },
                {"PackageLines", n => { PackageLines = n.GetCollectionOfObjectValues<Orderstatusresponse_packageline>(Orderstatusresponse_packageline.CreateFromDiscriminatorValue)?.ToList(); } },
                {"PackageReference", n => { PackageReference = n.GetStringValue(); } },
                {"PackingSlipID", n => { PackingSlipID = n.GetIntValue(); } },
                {"PackingSlipNumber", n => { PackingSlipNumber = n.GetIntValue(); } },
                {"PickingListID", n => { PickingListID = n.GetIntValue(); } },
                {"Position", n => { Position = n.GetIntValue(); } },
                {"SerialNumbers", n => { SerialNumbers = n.GetCollectionOfObjectValues<Orderstatusresponse_orderlineserialnumber>(Orderstatusresponse_orderlineserialnumber.CreateFromDiscriminatorValue)?.ToList(); } },
                {"TaxPercent", n => { TaxPercent = n.GetDoubleValue(); } },
                {"TrackingUrl", n => { TrackingUrl = n.GetStringValue(); } },
                {"UnitPrice", n => { UnitPrice = n.GetDoubleValue(); } },
                {"UnitPriceTax", n => { UnitPriceTax = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Carrier", Carrier);
            writer.WriteIntValue("CarrierID", CarrierID);
            writer.WriteStringValue("CarrierWebAddress", CarrierWebAddress);
            writer.WriteDateTimeOffsetValue("DateOfAction", DateOfAction);
            writer.WriteDoubleValue("InvoicedQuantity", InvoicedQuantity);
            writer.WriteIntValue("InvoiceNumber", InvoiceNumber);
            writer.WriteCollectionOfObjectValues<Orderstatusresponse_packageline>("PackageLines", PackageLines);
            writer.WriteStringValue("PackageReference", PackageReference);
            writer.WriteIntValue("PackingSlipID", PackingSlipID);
            writer.WriteIntValue("PackingSlipNumber", PackingSlipNumber);
            writer.WriteIntValue("PickingListID", PickingListID);
            writer.WriteIntValue("Position", Position);
            writer.WriteCollectionOfObjectValues<Orderstatusresponse_orderlineserialnumber>("SerialNumbers", SerialNumbers);
            writer.WriteDoubleValue("TaxPercent", TaxPercent);
            writer.WriteStringValue("TrackingUrl", TrackingUrl);
            writer.WriteDoubleValue("UnitPrice", UnitPrice);
            writer.WriteDoubleValue("UnitPriceTax", UnitPriceTax);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
