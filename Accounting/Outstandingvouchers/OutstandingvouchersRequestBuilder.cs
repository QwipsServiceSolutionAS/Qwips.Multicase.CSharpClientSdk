using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Accounting.Outstandingvouchers.Insert;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Accounting.Outstandingvouchers {
    /// <summary>
    /// Builds and executes requests for operations under \accounting\outstandingvouchers
    /// </summary>
    public class OutstandingvouchersRequestBuilder : BaseRequestBuilder {
        /// <summary>The insert property</summary>
        public InsertRequestBuilder Insert { get =>
            new InsertRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new OutstandingvouchersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OutstandingvouchersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounting/outstandingvouchers", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new OutstandingvouchersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OutstandingvouchersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounting/outstandingvouchers", rawUrl) {
        }
    }
}
