using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Purchaseorders.Create;
using Qwips.Core.MultiCase.Purchaseorders.Createhistoryitem;
using Qwips.Core.MultiCase.Purchaseorders.Item;
using Qwips.Core.MultiCase.Purchaseorders.Receive;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.MultiCase.Purchaseorders {
    /// <summary>
    /// Builds and executes requests for operations under \purchaseorders
    /// </summary>
    public class PurchaseordersRequestBuilder : BaseRequestBuilder {
        /// <summary>The create property</summary>
        public CreateRequestBuilder Create { get =>
            new CreateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The createhistoryitem property</summary>
        public CreatehistoryitemRequestBuilder Createhistoryitem { get =>
            new CreatehistoryitemRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The receive property</summary>
        public ReceiveRequestBuilder Receive { get =>
            new ReceiveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Qwips.Core.MultiCase.purchaseorders.item collection</summary>
        public WithGuItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("Guid", position);
            return new WithGuItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new PurchaseordersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PurchaseordersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/purchaseorders", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new PurchaseordersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PurchaseordersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/purchaseorders", rawUrl) {
        }
    }
}
