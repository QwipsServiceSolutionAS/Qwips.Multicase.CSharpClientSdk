using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Paymentterm3 : IAdditionalDataHolder, IParsable {
        /// <summary>The Active property</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CarrierID property</summary>
        public int? CarrierID { get; set; }
        /// <summary>The CountryID property</summary>
        public int? CountryID { get; set; }
        /// <summary>The ExternalFreightName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalFreightName { get; set; }
#nullable restore
#else
        public string ExternalFreightName { get; set; }
#endif
        /// <summary>The FreightID property</summary>
        public int? FreightID { get; set; }
        /// <summary>The FreightPrice property</summary>
        public double? FreightPrice { get; set; }
        /// <summary>The FreightPriority property</summary>
        public int? FreightPriority { get; set; }
        /// <summary>The MaxWeight property</summary>
        public double? MaxWeight { get; set; }
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The ShortName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShortName { get; set; }
#nullable restore
#else
        public string ShortName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Paymentterm3 and sets the default values.
        /// </summary>
        public Paymentterm3() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Paymentterm3 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Paymentterm3();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Active", n => { Active = n.GetBoolValue(); } },
                {"CarrierID", n => { CarrierID = n.GetIntValue(); } },
                {"CountryID", n => { CountryID = n.GetIntValue(); } },
                {"ExternalFreightName", n => { ExternalFreightName = n.GetStringValue(); } },
                {"FreightID", n => { FreightID = n.GetIntValue(); } },
                {"FreightPrice", n => { FreightPrice = n.GetDoubleValue(); } },
                {"FreightPriority", n => { FreightPriority = n.GetIntValue(); } },
                {"MaxWeight", n => { MaxWeight = n.GetDoubleValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"ShortName", n => { ShortName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("Active", Active);
            writer.WriteIntValue("CarrierID", CarrierID);
            writer.WriteIntValue("CountryID", CountryID);
            writer.WriteStringValue("ExternalFreightName", ExternalFreightName);
            writer.WriteIntValue("FreightID", FreightID);
            writer.WriteDoubleValue("FreightPrice", FreightPrice);
            writer.WriteIntValue("FreightPriority", FreightPriority);
            writer.WriteDoubleValue("MaxWeight", MaxWeight);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("ShortName", ShortName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
