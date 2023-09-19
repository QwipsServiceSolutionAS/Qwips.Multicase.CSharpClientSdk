using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Webuser : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CreateModifyContent property</summary>
        public bool? CreateModifyContent { get; set; }
        /// <summary>The IsAdmin property</summary>
        public bool? IsAdmin { get; set; }
        /// <summary>The LastLogin property</summary>
        public DateTimeOffset? LastLogin { get; set; }
        /// <summary>The Password property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Password { get; set; }
#nullable restore
#else
        public string Password { get; set; }
#endif
        /// <summary>The PasswordExpired property</summary>
        public bool? PasswordExpired { get; set; }
        /// <summary>The Username property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Username { get; set; }
#nullable restore
#else
        public string Username { get; set; }
#endif
        /// <summary>The ValidateContent property</summary>
        public bool? ValidateContent { get; set; }
        /// <summary>
        /// Instantiates a new webuser and sets the default values.
        /// </summary>
        public Webuser() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Webuser CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Webuser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CreateModifyContent", n => { CreateModifyContent = n.GetBoolValue(); } },
                {"IsAdmin", n => { IsAdmin = n.GetBoolValue(); } },
                {"LastLogin", n => { LastLogin = n.GetDateTimeOffsetValue(); } },
                {"Password", n => { Password = n.GetStringValue(); } },
                {"PasswordExpired", n => { PasswordExpired = n.GetBoolValue(); } },
                {"Username", n => { Username = n.GetStringValue(); } },
                {"ValidateContent", n => { ValidateContent = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("CreateModifyContent", CreateModifyContent);
            writer.WriteBoolValue("IsAdmin", IsAdmin);
            writer.WriteDateTimeOffsetValue("LastLogin", LastLogin);
            writer.WriteStringValue("Password", Password);
            writer.WriteBoolValue("PasswordExpired", PasswordExpired);
            writer.WriteStringValue("Username", Username);
            writer.WriteBoolValue("ValidateContent", ValidateContent);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
