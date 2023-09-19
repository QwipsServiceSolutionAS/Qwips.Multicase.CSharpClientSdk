using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Discount.Bid;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.MultiCase.Discount {
    /// <summary>
    /// Builds and executes requests for operations under \discount
    /// </summary>
    public class DiscountRequestBuilder : BaseRequestBuilder {
        /// <summary>The bid property</summary>
        public BidRequestBuilder Bid { get =>
            new BidRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DiscountRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DiscountRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/discount", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DiscountRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DiscountRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/discount", rawUrl) {
        }
    }
}
