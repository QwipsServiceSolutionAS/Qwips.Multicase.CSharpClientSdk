using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Banking : IAdditionalDataHolder, IParsable {
        /// <summary>The Account property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Account { get; set; }
#nullable restore
#else
        public string Account { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AgencyCreditRating property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AgencyCreditRating { get; set; }
#nullable restore
#else
        public string AgencyCreditRating { get; set; }
#endif
        /// <summary>The Connection property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Connection { get; set; }
#nullable restore
#else
        public string Connection { get; set; }
#endif
        /// <summary>The CustomerStatus property</summary>
        public Customerstatusenum? CustomerStatus { get; set; }
        /// <summary>The EconomyDepartmentID property</summary>
        public int? EconomyDepartmentID { get; set; }
        /// <summary>The EDIFilenamePrefix property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Ediprefix? EDIFilenamePrefix { get; set; }
#nullable restore
#else
        public Ediprefix EDIFilenamePrefix { get; set; }
#endif
        /// <summary>The IsExcludedFromSpecialTaxes property</summary>
        public bool? IsExcludedFromSpecialTaxes { get; set; }
        /// <summary>The IsTaxRequired property</summary>
        public bool? IsTaxRequired { get; set; }
        /// <summary>The OwnCreditRating property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnCreditRating { get; set; }
#nullable restore
#else
        public string OwnCreditRating { get; set; }
#endif
        /// <summary>The PostalGiroNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalGiroNumber { get; set; }
#nullable restore
#else
        public string PostalGiroNumber { get; set; }
#endif
        /// <summary>The PriceGroup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Pricegroup? PriceGroup { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Pricegroup PriceGroup { get; set; }
#endif
        /// <summary>The SalesCurrency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Currency? SalesCurrency { get; set; }
#nullable restore
#else
        public Currency SalesCurrency { get; set; }
#endif
        /// <summary>The SwiftCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SwiftCode { get; set; }
#nullable restore
#else
        public string SwiftCode { get; set; }
#endif
        /// <summary>The TaxModel property</summary>
        public Taxmodelenum? TaxModel { get; set; }
        /// <summary>The VATNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VATNumber { get; set; }
#nullable restore
#else
        public string VATNumber { get; set; }
#endif
        /// <summary>
        /// Instantiates a new banking and sets the default values.
        /// </summary>
        public Banking() {
            AdditionalData = new Dictionary<string, object>();
            CustomerStatus = Customerstatusenum.None;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Banking CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Banking();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Account", n => { Account = n.GetStringValue(); } },
                {"AgencyCreditRating", n => { AgencyCreditRating = n.GetStringValue(); } },
                {"Connection", n => { Connection = n.GetStringValue(); } },
                {"CustomerStatus", n => { CustomerStatus = n.GetEnumValue<Customerstatusenum>(); } },
                {"EconomyDepartmentID", n => { EconomyDepartmentID = n.GetIntValue(); } },
                {"EDIFilenamePrefix", n => { EDIFilenamePrefix = n.GetObjectValue<Ediprefix>(Ediprefix.CreateFromDiscriminatorValue); } },
                {"IsExcludedFromSpecialTaxes", n => { IsExcludedFromSpecialTaxes = n.GetBoolValue(); } },
                {"IsTaxRequired", n => { IsTaxRequired = n.GetBoolValue(); } },
                {"OwnCreditRating", n => { OwnCreditRating = n.GetStringValue(); } },
                {"PostalGiroNumber", n => { PostalGiroNumber = n.GetStringValue(); } },
                {"PriceGroup", n => { PriceGroup = n.GetObjectValue<Qwips.Core.MultiCase.Models.Pricegroup>(Qwips.Core.MultiCase.Models.Pricegroup.CreateFromDiscriminatorValue); } },
                {"SalesCurrency", n => { SalesCurrency = n.GetObjectValue<Currency>(Currency.CreateFromDiscriminatorValue); } },
                {"SwiftCode", n => { SwiftCode = n.GetStringValue(); } },
                {"TaxModel", n => { TaxModel = n.GetEnumValue<Taxmodelenum>(); } },
                {"VATNumber", n => { VATNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Account", Account);
            writer.WriteStringValue("AgencyCreditRating", AgencyCreditRating);
            writer.WriteStringValue("Connection", Connection);
            writer.WriteEnumValue<Customerstatusenum>("CustomerStatus", CustomerStatus);
            writer.WriteIntValue("EconomyDepartmentID", EconomyDepartmentID);
            writer.WriteObjectValue<Ediprefix>("EDIFilenamePrefix", EDIFilenamePrefix);
            writer.WriteBoolValue("IsExcludedFromSpecialTaxes", IsExcludedFromSpecialTaxes);
            writer.WriteBoolValue("IsTaxRequired", IsTaxRequired);
            writer.WriteStringValue("OwnCreditRating", OwnCreditRating);
            writer.WriteStringValue("PostalGiroNumber", PostalGiroNumber);
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Pricegroup>("PriceGroup", PriceGroup);
            writer.WriteObjectValue<Currency>("SalesCurrency", SalesCurrency);
            writer.WriteStringValue("SwiftCode", SwiftCode);
            writer.WriteEnumValue<Taxmodelenum>("TaxModel", TaxModel);
            writer.WriteStringValue("VATNumber", VATNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
