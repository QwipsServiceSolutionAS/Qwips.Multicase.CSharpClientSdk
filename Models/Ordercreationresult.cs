using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Ordercreationresult :  IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Errors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Ordererror>? Errors { get; set; }
#nullable restore
#else
        public List<Ordererror> Errors { get; set; }
#endif
        /// <summary>The InsertedOrders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Insertedorder>? InsertedOrders { get; set; }
#nullable restore
#else
        public List<Insertedorder> InsertedOrders { get; set; }
#endif
        /// <summary>The Ok property</summary>
        public bool? Ok { get; set; }
        /// <summary>
        /// Instantiates a new Ordercreationresult and sets the default values.
        /// </summary>
        public Ordercreationresult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Ordercreationresult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Ordercreationresult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Errors", n => { Errors = n.GetCollectionOfObjectValues<Ordererror>(Ordererror.CreateFromDiscriminatorValue)?.ToList(); } },
                {"InsertedOrders", n => { InsertedOrders = n.GetCollectionOfObjectValues<Insertedorder>(Insertedorder.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Ok", n => { Ok = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Ordererror>("Errors", Errors);
            writer.WriteCollectionOfObjectValues<Insertedorder>("InsertedOrders", InsertedOrders);
            writer.WriteBoolValue("Ok", Ok);
            writer.WriteAdditionalData(AdditionalData);
        }
    }

    public class Ordercreationresulterror : Exception, IAdditionalDataHolder, IParsable
    {
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Errors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Ordererror>? Errors { get; set; }
#nullable restore
#else
        public List<Ordererror> Errors { get; set; }
#endif
        /// <summary>The InsertedOrders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Insertedorder>? InsertedOrders { get; set; }
#nullable restore
#else
        public List<Insertedorder> InsertedOrders { get; set; }
#endif
        /// <summary>The Ok property</summary>
        public bool? Ok { get; set; }
        /// <summary>
        /// Instantiates a new Ordercreationresult and sets the default values.
        /// </summary>
        public Ordercreationresulterror()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Ordercreationresulterror CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Ordercreationresulterror();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>> {
                {"Errors", n => { Errors = n.GetCollectionOfObjectValues<Ordererror>(Ordererror.CreateFromDiscriminatorValue)?.ToList(); } },
                {"InsertedOrders", n => { InsertedOrders = n.GetCollectionOfObjectValues<Insertedorder>(Insertedorder.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Ok", n => { Ok = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Ordererror>("Errors", Errors);
            writer.WriteCollectionOfObjectValues<Insertedorder>("InsertedOrders", InsertedOrders);
            writer.WriteBoolValue("Ok", Ok);
            writer.WriteAdditionalData(AdditionalData);
        }

    }
}
