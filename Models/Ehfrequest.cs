using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Ehfrequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ClientId property</summary>
        public int? ClientId { get; set; }
        /// <summary>The ContractClientNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContractClientNumber { get; set; }
#nullable restore
#else
        public string ContractClientNumber { get; set; }
#endif
        /// <summary>The ContractNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContractNumber { get; set; }
#nullable restore
#else
        public string ContractNumber { get; set; }
#endif
        /// <summary>The DocumentType property</summary>
        public Documenttypeenum? DocumentType { get; set; }
        /// <summary>The FilePath property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FilePath { get; set; }
#nullable restore
#else
        public string FilePath { get; set; }
#endif
        /// <summary>The FromDate property</summary>
        public DateTimeOffset? FromDate { get; set; }
        /// <summary>The SenderAdressId property</summary>
        public int? SenderAdressId { get; set; }
        /// <summary>The StorageId property</summary>
        public int? StorageId { get; set; }
        /// <summary>The ToDate property</summary>
        public DateTimeOffset? ToDate { get; set; }
        /// <summary>The WebDataId property</summary>
        public int? WebDataId { get; set; }
        /// <summary>
        /// Instantiates a new Ehfrequest and sets the default values.
        /// </summary>
        public Ehfrequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Ehfrequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Ehfrequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ClientId", n => { ClientId = n.GetIntValue(); } },
                {"ContractClientNumber", n => { ContractClientNumber = n.GetStringValue(); } },
                {"ContractNumber", n => { ContractNumber = n.GetStringValue(); } },
                {"DocumentType", n => { DocumentType = n.GetEnumValue<Documenttypeenum>(); } },
                {"FilePath", n => { FilePath = n.GetStringValue(); } },
                {"FromDate", n => { FromDate = n.GetDateTimeOffsetValue(); } },
                {"SenderAdressId", n => { SenderAdressId = n.GetIntValue(); } },
                {"StorageId", n => { StorageId = n.GetIntValue(); } },
                {"ToDate", n => { ToDate = n.GetDateTimeOffsetValue(); } },
                {"WebDataId", n => { WebDataId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("ClientId", ClientId);
            writer.WriteStringValue("ContractClientNumber", ContractClientNumber);
            writer.WriteStringValue("ContractNumber", ContractNumber);
            writer.WriteEnumValue<Documenttypeenum>("DocumentType", DocumentType);
            writer.WriteStringValue("FilePath", FilePath);
            writer.WriteDateTimeOffsetValue("FromDate", FromDate);
            writer.WriteIntValue("SenderAdressId", SenderAdressId);
            writer.WriteIntValue("StorageId", StorageId);
            writer.WriteDateTimeOffsetValue("ToDate", ToDate);
            writer.WriteIntValue("WebDataId", WebDataId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
