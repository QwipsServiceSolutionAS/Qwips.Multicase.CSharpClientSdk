using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Product.Price;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.MultiCase.Product {
    /// <summary>
    /// Builds and executes requests for operations under \product
    /// </summary>
    public class ProductRequestBuilder : BaseRequestBuilder {
        /// <summary>The price property</summary>
        public PriceRequestBuilder Price { get =>
            new PriceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ProductRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProductRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/product", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ProductRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProductRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/product", rawUrl) {
        }
    }
}
