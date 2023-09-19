using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Postalarea : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The City property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>The Country property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>The CountyNo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountyNo { get; set; }
#nullable restore
#else
        public string CountyNo { get; set; }
#endif
        /// <summary>The MunicipalityNo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MunicipalityNo { get; set; }
#nullable restore
#else
        public string MunicipalityNo { get; set; }
#endif
        /// <summary>The PostalID property</summary>
        public int? PostalID { get; set; }
        /// <summary>The ZipCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ZipCode { get; set; }
#nullable restore
#else
        public string ZipCode { get; set; }
#endif
        /// <summary>
        /// Instantiates a new postalarea and sets the default values.
        /// </summary>
        public Postalarea() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Postalarea CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Postalarea();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"City", n => { City = n.GetStringValue(); } },
                {"Country", n => { Country = n.GetStringValue(); } },
                {"CountyNo", n => { CountyNo = n.GetStringValue(); } },
                {"MunicipalityNo", n => { MunicipalityNo = n.GetStringValue(); } },
                {"PostalID", n => { PostalID = n.GetIntValue(); } },
                {"ZipCode", n => { ZipCode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("City", City);
            writer.WriteStringValue("Country", Country);
            writer.WriteStringValue("CountyNo", CountyNo);
            writer.WriteStringValue("MunicipalityNo", MunicipalityNo);
            writer.WriteIntValue("PostalID", PostalID);
            writer.WriteStringValue("ZipCode", ZipCode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
