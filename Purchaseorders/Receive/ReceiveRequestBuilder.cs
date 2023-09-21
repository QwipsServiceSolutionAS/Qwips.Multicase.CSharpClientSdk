using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Purchaseorders.Receive.Full;
using Qwips.Core.ClientSdk.Multicase.Purchaseorders.Receive.Partly;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Purchaseorders.Receive {
    /// <summary>
    /// Builds and executes requests for operations under \purchaseorders\receive
    /// </summary>
    public class ReceiveRequestBuilder : BaseRequestBuilder {
        /// <summary>The full property</summary>
        public FullRequestBuilder Full { get =>
            new FullRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The partly property</summary>
        public PartlyRequestBuilder Partly { get =>
            new PartlyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ReceiveRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReceiveRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/purchaseorders/receive", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ReceiveRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReceiveRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/purchaseorders/receive", rawUrl) {
        }
    }
}
