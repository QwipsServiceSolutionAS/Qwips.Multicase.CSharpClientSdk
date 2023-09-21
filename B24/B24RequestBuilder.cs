using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.B24.Pricat;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.B24 {
    /// <summary>
    /// Builds and executes requests for operations under \B24
    /// </summary>
    public class B24RequestBuilder : BaseRequestBuilder {
        /// <summary>The Pricat property</summary>
        public PricatRequestBuilder Pricat { get =>
            new PricatRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new B24RequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public B24RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/B24", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new B24RequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public B24RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/B24", rawUrl) {
        }
    }
}
