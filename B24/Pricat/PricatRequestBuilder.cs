using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.B24.Pricat.Export;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.B24.Pricat {
    /// <summary>
    /// Builds and executes requests for operations under \B24\Pricat
    /// </summary>
    public class PricatRequestBuilder : BaseRequestBuilder {
        /// <summary>The Export property</summary>
        public ExportRequestBuilder Export { get =>
            new ExportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new PricatRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PricatRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/B24/Pricat", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new PricatRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PricatRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/B24/Pricat", rawUrl) {
        }
    }
}
