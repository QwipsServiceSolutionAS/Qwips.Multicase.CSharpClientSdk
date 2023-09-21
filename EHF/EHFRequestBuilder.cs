using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.EHF.ProductCatalog;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.EHF {
    /// <summary>
    /// Builds and executes requests for operations under \EHF
    /// </summary>
    public class EHFRequestBuilder : BaseRequestBuilder {
        /// <summary>The ProductCatalog property</summary>
        public ProductCatalogRequestBuilder ProductCatalog { get =>
            new ProductCatalogRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new EHFRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EHFRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/EHF", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new EHFRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EHFRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/EHF", rawUrl) {
        }
    }
}
