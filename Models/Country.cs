using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Country : IAdditionalDataHolder, IParsable {
        /// <summary>The Active property</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AktivTollTariff property</summary>
        public bool? AktivTollTariff { get; set; }
        /// <summary>The AvgPliktSalg property</summary>
        public bool? AvgPliktSalg { get; set; }
        /// <summary>The CountryCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode { get; set; }
#nullable restore
#else
        public string CountryCode { get; set; }
#endif
        /// <summary>The CountryCode2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode2 { get; set; }
#nullable restore
#else
        public string CountryCode2 { get; set; }
#endif
        /// <summary>The CountryCode3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode3 { get; set; }
#nullable restore
#else
        public string CountryCode3 { get; set; }
#endif
        /// <summary>The EDICountryCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EDICountryCode { get; set; }
#nullable restore
#else
        public string EDICountryCode { get; set; }
#endif
        /// <summary>The Id property</summary>
        public int? Id { get; set; }
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The PhonePrefix property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhonePrefix { get; set; }
#nullable restore
#else
        public string PhonePrefix { get; set; }
#endif
        /// <summary>The TradeGroup property</summary>
        public int? TradeGroup { get; set; }
        /// <summary>
        /// Instantiates a new country and sets the default values.
        /// </summary>
        public Country() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Country CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Country();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Active", n => { Active = n.GetBoolValue(); } },
                {"AktivTollTariff", n => { AktivTollTariff = n.GetBoolValue(); } },
                {"AvgPliktSalg", n => { AvgPliktSalg = n.GetBoolValue(); } },
                {"CountryCode", n => { CountryCode = n.GetStringValue(); } },
                {"CountryCode2", n => { CountryCode2 = n.GetStringValue(); } },
                {"CountryCode3", n => { CountryCode3 = n.GetStringValue(); } },
                {"EDICountryCode", n => { EDICountryCode = n.GetStringValue(); } },
                {"Id", n => { Id = n.GetIntValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"PhonePrefix", n => { PhonePrefix = n.GetStringValue(); } },
                {"TradeGroup", n => { TradeGroup = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("Active", Active);
            writer.WriteBoolValue("AktivTollTariff", AktivTollTariff);
            writer.WriteBoolValue("AvgPliktSalg", AvgPliktSalg);
            writer.WriteStringValue("CountryCode", CountryCode);
            writer.WriteStringValue("CountryCode2", CountryCode2);
            writer.WriteStringValue("CountryCode3", CountryCode3);
            writer.WriteStringValue("EDICountryCode", EDICountryCode);
            writer.WriteIntValue("Id", Id);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("PhonePrefix", PhonePrefix);
            writer.WriteIntValue("TradeGroup", TradeGroup);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
