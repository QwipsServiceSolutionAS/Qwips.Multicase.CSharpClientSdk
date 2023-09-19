using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Request.CustomerContactCreate;
using Qwips.Core.MultiCase.Request.CustomerContactGet;
using Qwips.Core.MultiCase.Request.CustomerContactUpdate;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.MultiCase.Request {
    /// <summary>
    /// Builds and executes requests for operations under \request
    /// </summary>
    public class RequestRequestBuilder : BaseRequestBuilder {
        /// <summary>The CustomerContactCreate property</summary>
        public CustomerContactCreateRequestBuilder CustomerContactCreate { get =>
            new CustomerContactCreateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CustomerContactGet property</summary>
        public CustomerContactGetRequestBuilder CustomerContactGet { get =>
            new CustomerContactGetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CustomerContactUpdate property</summary>
        public CustomerContactUpdateRequestBuilder CustomerContactUpdate { get =>
            new CustomerContactUpdateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new RequestRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RequestRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/request", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new RequestRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RequestRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/request", rawUrl) {
        }
    }
}
