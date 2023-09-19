using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.Core.MultiCase.Models {
    public class Customerproduct : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CustomerGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Customergroups? CustomerGroups { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Customergroups CustomerGroups { get; set; }
#endif
        /// <summary>The CustomersAdd property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Customersadd? CustomersAdd { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Customersadd CustomersAdd { get; set; }
#endif
        /// <summary>The CustomersDelete property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.Core.MultiCase.Models.Customersdelete? CustomersDelete { get; set; }
#nullable restore
#else
        public Qwips.Core.MultiCase.Models.Customersdelete CustomersDelete { get; set; }
#endif
        /// <summary>The Product property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Linkproduct? Product { get; set; }
#nullable restore
#else
        public Linkproduct Product { get; set; }
#endif
        /// <summary>
        /// Instantiates a new customerproduct and sets the default values.
        /// </summary>
        public Customerproduct() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Customerproduct CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Customerproduct();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CustomerGroups", n => { CustomerGroups = n.GetObjectValue<Qwips.Core.MultiCase.Models.Customergroups>(Qwips.Core.MultiCase.Models.Customergroups.CreateFromDiscriminatorValue); } },
                {"CustomersAdd", n => { CustomersAdd = n.GetObjectValue<Qwips.Core.MultiCase.Models.Customersadd>(Qwips.Core.MultiCase.Models.Customersadd.CreateFromDiscriminatorValue); } },
                {"CustomersDelete", n => { CustomersDelete = n.GetObjectValue<Qwips.Core.MultiCase.Models.Customersdelete>(Qwips.Core.MultiCase.Models.Customersdelete.CreateFromDiscriminatorValue); } },
                {"Product", n => { Product = n.GetObjectValue<Linkproduct>(Linkproduct.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Customergroups>("CustomerGroups", CustomerGroups);
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Customersadd>("CustomersAdd", CustomersAdd);
            writer.WriteObjectValue<Qwips.Core.MultiCase.Models.Customersdelete>("CustomersDelete", CustomersDelete);
            writer.WriteObjectValue<Linkproduct>("Product", Product);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
