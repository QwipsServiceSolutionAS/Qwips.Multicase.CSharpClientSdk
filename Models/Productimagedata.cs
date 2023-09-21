using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Productimagedata : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The DisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The FileAdded property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileAdded { get; set; }
#nullable restore
#else
        public string FileAdded { get; set; }
#endif
        /// <summary>The FileAddedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileAddedBy { get; set; }
#nullable restore
#else
        public string FileAddedBy { get; set; }
#endif
        /// <summary>The FileDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileDate { get; set; }
#nullable restore
#else
        public string FileDate { get; set; }
#endif
        /// <summary>The FileName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName { get; set; }
#nullable restore
#else
        public string FileName { get; set; }
#endif
        /// <summary>The FileSize property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileSize { get; set; }
#nullable restore
#else
        public string FileSize { get; set; }
#endif
        /// <summary>The Flags property</summary>
        public Imageflagsenum? Flags { get; set; }
        /// <summary>The Height property</summary>
        public int? Height { get; set; }
        /// <summary>The ImageGuid property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageGuid { get; set; }
#nullable restore
#else
        public string ImageGuid { get; set; }
#endif
        /// <summary>The ImageId property</summary>
        public int? ImageId { get; set; }
        /// <summary>The ImageSize property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageSize { get; set; }
#nullable restore
#else
        public string ImageSize { get; set; }
#endif
        /// <summary>The IsLocked property</summary>
        public bool? IsLocked { get; set; }
        /// <summary>The LastUpdatedBy property</summary>
        public int? LastUpdatedBy { get; set; }
        /// <summary>The MasterImageId property</summary>
        public int? MasterImageId { get; set; }
        /// <summary>The OriginalPath property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalPath { get; set; }
#nullable restore
#else
        public string OriginalPath { get; set; }
#endif
        /// <summary>The ProductId property</summary>
        public int? ProductId { get; set; }
        /// <summary>The Resolution property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Resolution { get; set; }
#nullable restore
#else
        public string Resolution { get; set; }
#endif
        /// <summary>The SortOrder property</summary>
        public int? SortOrder { get; set; }
        /// <summary>The Url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>The Warnings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Warnings { get; set; }
#nullable restore
#else
        public List<string> Warnings { get; set; }
#endif
        /// <summary>The Width property</summary>
        public int? Width { get; set; }
        /// <summary>
        /// Instantiates a new Productimagedata and sets the default values.
        /// </summary>
        public Productimagedata() {
            AdditionalData = new Dictionary<string, object>();
            Flags = Imageflagsenum.None;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Productimagedata CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Productimagedata();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"DisplayName", n => { DisplayName = n.GetStringValue(); } },
                {"FileAdded", n => { FileAdded = n.GetStringValue(); } },
                {"FileAddedBy", n => { FileAddedBy = n.GetStringValue(); } },
                {"FileDate", n => { FileDate = n.GetStringValue(); } },
                {"FileName", n => { FileName = n.GetStringValue(); } },
                {"FileSize", n => { FileSize = n.GetStringValue(); } },
                {"Flags", n => { Flags = n.GetEnumValue<Imageflagsenum>(); } },
                {"Height", n => { Height = n.GetIntValue(); } },
                {"ImageGuid", n => { ImageGuid = n.GetStringValue(); } },
                {"ImageId", n => { ImageId = n.GetIntValue(); } },
                {"ImageSize", n => { ImageSize = n.GetStringValue(); } },
                {"IsLocked", n => { IsLocked = n.GetBoolValue(); } },
                {"LastUpdatedBy", n => { LastUpdatedBy = n.GetIntValue(); } },
                {"MasterImageId", n => { MasterImageId = n.GetIntValue(); } },
                {"OriginalPath", n => { OriginalPath = n.GetStringValue(); } },
                {"ProductId", n => { ProductId = n.GetIntValue(); } },
                {"Resolution", n => { Resolution = n.GetStringValue(); } },
                {"SortOrder", n => { SortOrder = n.GetIntValue(); } },
                {"Url", n => { Url = n.GetStringValue(); } },
                {"Warnings", n => { Warnings = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"Width", n => { Width = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("DisplayName", DisplayName);
            writer.WriteStringValue("FileAdded", FileAdded);
            writer.WriteStringValue("FileAddedBy", FileAddedBy);
            writer.WriteStringValue("FileDate", FileDate);
            writer.WriteStringValue("FileName", FileName);
            writer.WriteStringValue("FileSize", FileSize);
            writer.WriteEnumValue<Imageflagsenum>("Flags", Flags);
            writer.WriteIntValue("Height", Height);
            writer.WriteStringValue("ImageGuid", ImageGuid);
            writer.WriteIntValue("ImageId", ImageId);
            writer.WriteStringValue("ImageSize", ImageSize);
            writer.WriteBoolValue("IsLocked", IsLocked);
            writer.WriteIntValue("LastUpdatedBy", LastUpdatedBy);
            writer.WriteIntValue("MasterImageId", MasterImageId);
            writer.WriteStringValue("OriginalPath", OriginalPath);
            writer.WriteIntValue("ProductId", ProductId);
            writer.WriteStringValue("Resolution", Resolution);
            writer.WriteIntValue("SortOrder", SortOrder);
            writer.WriteStringValue("Url", Url);
            writer.WriteCollectionOfPrimitiveValues<string>("Warnings", Warnings);
            writer.WriteIntValue("Width", Width);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
