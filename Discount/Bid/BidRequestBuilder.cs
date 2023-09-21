using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Discount.Bid.Get;
using Qwips.Core.ClientSdk.Multicase.Discount.Bid.List;
using Qwips.Core.ClientSdk.Multicase.Discount.Bid.Update;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Discount.Bid {
    /// <summary>
    /// Builds and executes requests for operations under \discount\bid
    /// </summary>
    public class BidRequestBuilder : BaseRequestBuilder {
        /// <summary>The getPath property</summary>
        public GetRequestBuilder GetPath { get =>
            new GetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The list property</summary>
        public ListRequestBuilder List { get =>
            new ListRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The update property</summary>
        public UpdateRequestBuilder Update { get =>
            new UpdateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new BidRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BidRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/discount/bid", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new BidRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BidRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/discount/bid", rawUrl) {
        }
    }
}
