using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Orderstatusresponse_packageline : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AutoProcess property</summary>
        public int? AutoProcess { get; set; }
        /// <summary>The CollectionFee property</summary>
        public double? CollectionFee { get; set; }
        /// <summary>The FreightCost property</summary>
        public double? FreightCost { get; set; }
        /// <summary>The Lopenr property</summary>
        public int? Lopenr { get; set; }
        /// <summary>The PackageNumber property</summary>
        public int? PackageNumber { get; set; }
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
        /// <summary>The Price property</summary>
        public double? Price { get; set; }
        /// <summary>The VolumeCost property</summary>
        public double? VolumeCost { get; set; }
        /// <summary>The Weight property</summary>
        public double? Weight { get; set; }
        /// <summary>
        /// Instantiates a new orderstatusresponse_packageline and sets the default values.
        /// </summary>
        public Orderstatusresponse_packageline() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Orderstatusresponse_packageline CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Orderstatusresponse_packageline();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AutoProcess", n => { AutoProcess = n.GetIntValue(); } },
                {"CollectionFee", n => { CollectionFee = n.GetDoubleValue(); } },
                {"FreightCost", n => { FreightCost = n.GetDoubleValue(); } },
                {"Lopenr", n => { Lopenr = n.GetIntValue(); } },
                {"PackageNumber", n => { PackageNumber = n.GetIntValue(); } },
                {"PackageReference", n => { PackageReference = n.GetStringValue(); } },
                {"PackingSlipID", n => { PackingSlipID = n.GetIntValue(); } },
                {"Price", n => { Price = n.GetDoubleValue(); } },
                {"VolumeCost", n => { VolumeCost = n.GetDoubleValue(); } },
                {"Weight", n => { Weight = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("AutoProcess", AutoProcess);
            writer.WriteDoubleValue("CollectionFee", CollectionFee);
            writer.WriteDoubleValue("FreightCost", FreightCost);
            writer.WriteIntValue("Lopenr", Lopenr);
            writer.WriteIntValue("PackageNumber", PackageNumber);
            writer.WriteStringValue("PackageReference", PackageReference);
            writer.WriteIntValue("PackingSlipID", PackingSlipID);
            writer.WriteDoubleValue("Price", Price);
            writer.WriteDoubleValue("VolumeCost", VolumeCost);
            writer.WriteDoubleValue("Weight", Weight);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
