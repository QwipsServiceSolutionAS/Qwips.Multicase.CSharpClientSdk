using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Currency : IAdditionalDataHolder, IParsable {
        /// <summary>The Active property</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CultureName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CultureName { get; set; }
#nullable restore
#else
        public string CultureName { get; set; }
#endif
        /// <summary>The CurrencyCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>The CurrencyDate property</summary>
        public DateTimeOffset? CurrencyDate { get; set; }
        /// <summary>The CurrencyID property</summary>
        public int? CurrencyID { get; set; }
        /// <summary>The ExchangeRate property</summary>
        public double? ExchangeRate { get; set; }
        /// <summary>The ExchangeUnit property</summary>
        public double? ExchangeUnit { get; set; }
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The PrefixSymbol property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrefixSymbol { get; set; }
#nullable restore
#else
        public string PrefixSymbol { get; set; }
#endif
        /// <summary>The PurchaseRate property</summary>
        public double? PurchaseRate { get; set; }
        /// <summary>The TallKode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TallKode { get; set; }
#nullable restore
#else
        public string TallKode { get; set; }
#endif
        /// <summary>The TallKode1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TallKode1 { get; set; }
#nullable restore
#else
        public string TallKode1 { get; set; }
#endif
        /// <summary>The TallKode2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TallKode2 { get; set; }
#nullable restore
#else
        public string TallKode2 { get; set; }
#endif
        /// <summary>The TallKode3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TallKode3 { get; set; }
#nullable restore
#else
        public string TallKode3 { get; set; }
#endif
        /// <summary>The UsedInSales property</summary>
        public bool? UsedInSales { get; set; }
        /// <summary>
        /// Instantiates a new currency and sets the default values.
        /// </summary>
        public Currency() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Currency CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Currency();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Active", n => { Active = n.GetBoolValue(); } },
                {"CultureName", n => { CultureName = n.GetStringValue(); } },
                {"CurrencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"CurrencyDate", n => { CurrencyDate = n.GetDateTimeOffsetValue(); } },
                {"CurrencyID", n => { CurrencyID = n.GetIntValue(); } },
                {"ExchangeRate", n => { ExchangeRate = n.GetDoubleValue(); } },
                {"ExchangeUnit", n => { ExchangeUnit = n.GetDoubleValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"PrefixSymbol", n => { PrefixSymbol = n.GetStringValue(); } },
                {"PurchaseRate", n => { PurchaseRate = n.GetDoubleValue(); } },
                {"TallKode", n => { TallKode = n.GetStringValue(); } },
                {"TallKode1", n => { TallKode1 = n.GetStringValue(); } },
                {"TallKode2", n => { TallKode2 = n.GetStringValue(); } },
                {"TallKode3", n => { TallKode3 = n.GetStringValue(); } },
                {"UsedInSales", n => { UsedInSales = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("Active", Active);
            writer.WriteStringValue("CultureName", CultureName);
            writer.WriteStringValue("CurrencyCode", CurrencyCode);
            writer.WriteDateTimeOffsetValue("CurrencyDate", CurrencyDate);
            writer.WriteIntValue("CurrencyID", CurrencyID);
            writer.WriteDoubleValue("ExchangeRate", ExchangeRate);
            writer.WriteDoubleValue("ExchangeUnit", ExchangeUnit);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("PrefixSymbol", PrefixSymbol);
            writer.WriteDoubleValue("PurchaseRate", PurchaseRate);
            writer.WriteStringValue("TallKode", TallKode);
            writer.WriteStringValue("TallKode1", TallKode1);
            writer.WriteStringValue("TallKode2", TallKode2);
            writer.WriteStringValue("TallKode3", TallKode3);
            writer.WriteBoolValue("UsedInSales", UsedInSales);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
