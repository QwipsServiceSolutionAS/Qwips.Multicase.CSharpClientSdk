using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Models {
    public class Customercontact : IAdditionalDataHolder, IParsable {
        /// <summary>The Active property</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AddressLine1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddressLine1 { get; set; }
#nullable restore
#else
        public string AddressLine1 { get; set; }
#endif
        /// <summary>The AddressLine2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddressLine2 { get; set; }
#nullable restore
#else
        public string AddressLine2 { get; set; }
#endif
        /// <summary>The AlternativeContactMethods property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Alternativecontactmethod>? AlternativeContactMethods { get; set; }
#nullable restore
#else
        public List<Alternativecontactmethod> AlternativeContactMethods { get; set; }
#endif
        /// <summary>The CellPhone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CellPhone { get; set; }
#nullable restore
#else
        public string CellPhone { get; set; }
#endif
        /// <summary>The DateOfBirth property</summary>
        public DateTimeOffset? DateOfBirth { get; set; }
        /// <summary>The DecisionMaker property</summary>
        public bool? DecisionMaker { get; set; }
        /// <summary>The DirectFax property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DirectFax { get; set; }
#nullable restore
#else
        public string DirectFax { get; set; }
#endif
        /// <summary>The DirectPhone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DirectPhone { get; set; }
#nullable restore
#else
        public string DirectPhone { get; set; }
#endif
        /// <summary>The EMailAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EMailAddress { get; set; }
#nullable restore
#else
        public string EMailAddress { get; set; }
#endif
        /// <summary>The FirstName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>The Gender property</summary>
        public Genderenum? Gender { get; set; }
        /// <summary>The ID property</summary>
        public int? ID { get; set; }
        /// <summary>The JobInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobInfo { get; set; }
#nullable restore
#else
        public string JobInfo { get; set; }
#endif
        /// <summary>The LastName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>The MessageFormat property</summary>
        public Messageformatenum? MessageFormat { get; set; }
        /// <summary>The OrderPermission property</summary>
        public bool? OrderPermission { get; set; }
        /// <summary>The OtherInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OtherInfo { get; set; }
#nullable restore
#else
        public string OtherInfo { get; set; }
#endif
        /// <summary>The Postal property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Postalarea? Postal { get; set; }
#nullable restore
#else
        public Postalarea Postal { get; set; }
#endif
        /// <summary>The PrimaryCommunicationType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryCommunicationType { get; set; }
#nullable restore
#else
        public string PrimaryCommunicationType { get; set; }
#endif
        /// <summary>The PrivatePhone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrivatePhone { get; set; }
#nullable restore
#else
        public string PrivatePhone { get; set; }
#endif
        /// <summary>The SMSNotification property</summary>
        public bool? SMSNotification { get; set; }
        /// <summary>The Title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The WebUser property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.ClientSdk.Multicase.Models.Webuser? WebUser { get; set; }
#nullable restore
#else
        public Qwips.Core.ClientSdk.Multicase.Models.Webuser WebUser { get; set; }
#endif
        /// <summary>
        /// Instantiates a new customercontact and sets the default values.
        /// </summary>
        public Customercontact() {
            AdditionalData = new Dictionary<string, object>();
            Gender = Genderenum.Unknown;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Customercontact CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Customercontact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Active", n => { Active = n.GetBoolValue(); } },
                {"AddressLine1", n => { AddressLine1 = n.GetStringValue(); } },
                {"AddressLine2", n => { AddressLine2 = n.GetStringValue(); } },
                {"AlternativeContactMethods", n => { AlternativeContactMethods = n.GetCollectionOfObjectValues<Alternativecontactmethod>(Alternativecontactmethod.CreateFromDiscriminatorValue)?.ToList(); } },
                {"CellPhone", n => { CellPhone = n.GetStringValue(); } },
                {"DateOfBirth", n => { DateOfBirth = n.GetDateTimeOffsetValue(); } },
                {"DecisionMaker", n => { DecisionMaker = n.GetBoolValue(); } },
                {"DirectFax", n => { DirectFax = n.GetStringValue(); } },
                {"DirectPhone", n => { DirectPhone = n.GetStringValue(); } },
                {"EMailAddress", n => { EMailAddress = n.GetStringValue(); } },
                {"FirstName", n => { FirstName = n.GetStringValue(); } },
                {"Gender", n => { Gender = n.GetEnumValue<Genderenum>(); } },
                {"ID", n => { ID = n.GetIntValue(); } },
                {"JobInfo", n => { JobInfo = n.GetStringValue(); } },
                {"LastName", n => { LastName = n.GetStringValue(); } },
                {"MessageFormat", n => { MessageFormat = n.GetEnumValue<Messageformatenum>(); } },
                {"OrderPermission", n => { OrderPermission = n.GetBoolValue(); } },
                {"OtherInfo", n => { OtherInfo = n.GetStringValue(); } },
                {"Postal", n => { Postal = n.GetObjectValue<Postalarea>(Postalarea.CreateFromDiscriminatorValue); } },
                {"PrimaryCommunicationType", n => { PrimaryCommunicationType = n.GetStringValue(); } },
                {"PrivatePhone", n => { PrivatePhone = n.GetStringValue(); } },
                {"SMSNotification", n => { SMSNotification = n.GetBoolValue(); } },
                {"Title", n => { Title = n.GetStringValue(); } },
                {"WebUser", n => { WebUser = n.GetObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Webuser>(Qwips.Core.ClientSdk.Multicase.Models.Webuser.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("Active", Active);
            writer.WriteStringValue("AddressLine1", AddressLine1);
            writer.WriteStringValue("AddressLine2", AddressLine2);
            writer.WriteCollectionOfObjectValues<Alternativecontactmethod>("AlternativeContactMethods", AlternativeContactMethods);
            writer.WriteStringValue("CellPhone", CellPhone);
            writer.WriteDateTimeOffsetValue("DateOfBirth", DateOfBirth);
            writer.WriteBoolValue("DecisionMaker", DecisionMaker);
            writer.WriteStringValue("DirectFax", DirectFax);
            writer.WriteStringValue("DirectPhone", DirectPhone);
            writer.WriteStringValue("EMailAddress", EMailAddress);
            writer.WriteStringValue("FirstName", FirstName);
            writer.WriteEnumValue<Genderenum>("Gender", Gender);
            writer.WriteIntValue("ID", ID);
            writer.WriteStringValue("JobInfo", JobInfo);
            writer.WriteStringValue("LastName", LastName);
            writer.WriteEnumValue<Messageformatenum>("MessageFormat", MessageFormat);
            writer.WriteBoolValue("OrderPermission", OrderPermission);
            writer.WriteStringValue("OtherInfo", OtherInfo);
            writer.WriteObjectValue<Postalarea>("Postal", Postal);
            writer.WriteStringValue("PrimaryCommunicationType", PrimaryCommunicationType);
            writer.WriteStringValue("PrivatePhone", PrivatePhone);
            writer.WriteBoolValue("SMSNotification", SMSNotification);
            writer.WriteStringValue("Title", Title);
            writer.WriteObjectValue<Qwips.Core.ClientSdk.Multicase.Models.Webuser>("WebUser", WebUser);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
