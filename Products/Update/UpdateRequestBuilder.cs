using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Products.Update.Listprice;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Products.Update {
    /// <summary>
    /// Builds and executes requests for operations under \products\update
    /// </summary>
    public class UpdateRequestBuilder : BaseRequestBuilder {
        /// <summary>The listprice property</summary>
        public ListpriceRequestBuilder Listprice { get =>
            new ListpriceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new UpdateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UpdateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products/update", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UpdateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UpdateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products/update", rawUrl) {
        }
    }
}
