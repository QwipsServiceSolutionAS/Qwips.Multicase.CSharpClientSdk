using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Auth : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cnonce property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Cnonce { get; set; }
#nullable restore
#else
        public string Cnonce { get; set; }
#endif
        /// <summary>The Continue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Continue { get; set; }
#nullable restore
#else
        public string Continue { get; set; }
#endif
        /// <summary>The nc property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Nc { get; set; }
#nullable restore
#else
        public string Nc { get; set; }
#endif
        /// <summary>The nonce property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Nonce { get; set; }
#nullable restore
#else
        public string Nonce { get; set; }
#endif
        /// <summary>The oauth_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OauthToken { get; set; }
#nullable restore
#else
        public string OauthToken { get; set; }
#endif
        /// <summary>The oauth_verifier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OauthVerifier { get; set; }
#nullable restore
#else
        public string OauthVerifier { get; set; }
#endif
        /// <summary>The Password property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Password { get; set; }
#nullable restore
#else
        public string Password { get; set; }
#endif
        /// <summary>The provider property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Provider { get; set; }
#nullable restore
#else
        public string Provider { get; set; }
#endif
        /// <summary>The qop property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Qop { get; set; }
#nullable restore
#else
        public string Qop { get; set; }
#endif
        /// <summary>The RememberMe property</summary>
        public bool? RememberMe { get; set; }
        /// <summary>The response property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Response { get; set; }
#nullable restore
#else
        public string Response { get; set; }
#endif
        /// <summary>The State property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>The uri property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uri { get; set; }
#nullable restore
#else
        public string Uri { get; set; }
#endif
        /// <summary>The UserName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName { get; set; }
#nullable restore
#else
        public string UserName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Auth and sets the default values.
        /// </summary>
        public Auth() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Auth CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Auth();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cnonce", n => { Cnonce = n.GetStringValue(); } },
                {"Continue", n => { Continue = n.GetStringValue(); } },
                {"nc", n => { Nc = n.GetStringValue(); } },
                {"nonce", n => { Nonce = n.GetStringValue(); } },
                {"oauth_token", n => { OauthToken = n.GetStringValue(); } },
                {"oauth_verifier", n => { OauthVerifier = n.GetStringValue(); } },
                {"Password", n => { Password = n.GetStringValue(); } },
                {"provider", n => { Provider = n.GetStringValue(); } },
                {"qop", n => { Qop = n.GetStringValue(); } },
                {"RememberMe", n => { RememberMe = n.GetBoolValue(); } },
                {"response", n => { Response = n.GetStringValue(); } },
                {"State", n => { State = n.GetStringValue(); } },
                {"uri", n => { Uri = n.GetStringValue(); } },
                {"UserName", n => { UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("cnonce", Cnonce);
            writer.WriteStringValue("Continue", Continue);
            writer.WriteStringValue("nc", Nc);
            writer.WriteStringValue("nonce", Nonce);
            writer.WriteStringValue("oauth_token", OauthToken);
            writer.WriteStringValue("oauth_verifier", OauthVerifier);
            writer.WriteStringValue("Password", Password);
            writer.WriteStringValue("provider", Provider);
            writer.WriteStringValue("qop", Qop);
            writer.WriteBoolValue("RememberMe", RememberMe);
            writer.WriteStringValue("response", Response);
            writer.WriteStringValue("State", State);
            writer.WriteStringValue("uri", Uri);
            writer.WriteStringValue("UserName", UserName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
