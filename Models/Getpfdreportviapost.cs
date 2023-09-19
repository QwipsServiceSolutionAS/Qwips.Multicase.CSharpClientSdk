using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Getpfdreportviapost : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ControlParams property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Pdfparameters? ControlParams { get; set; }
#nullable restore
#else
        public Pdfparameters ControlParams { get; set; }
#endif
        /// <summary>The ReportFormat property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReportFormat { get; set; }
#nullable restore
#else
        public string ReportFormat { get; set; }
#endif
        /// <summary>The ReportParams property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Reportparameters? ReportParams { get; set; }
#nullable restore
#else
        public Reportparameters ReportParams { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Getpfdreportviapost and sets the default values.
        /// </summary>
        public Getpfdreportviapost() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Getpfdreportviapost CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Getpfdreportviapost();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ControlParams", n => { ControlParams = n.GetObjectValue<Pdfparameters>(Pdfparameters.CreateFromDiscriminatorValue); } },
                {"ReportFormat", n => { ReportFormat = n.GetStringValue(); } },
                {"ReportParams", n => { ReportParams = n.GetObjectValue<Reportparameters>(Reportparameters.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Pdfparameters>("ControlParams", ControlParams);
            writer.WriteStringValue("ReportFormat", ReportFormat);
            writer.WriteObjectValue<Reportparameters>("ReportParams", ReportParams);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}