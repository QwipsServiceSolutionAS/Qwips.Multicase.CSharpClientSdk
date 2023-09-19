using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Product.Price.Item.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.MultiCase.Product.Price.Item {
    /// <summary>
    /// Builds and executes requests for operations under \product\price\{ProductId}
    /// </summary>
    public class WithProductItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Qwips.Core.MultiCase.product.price.item.item collection</summary>
        public WithCustomerItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("CustomerId", position);
            return new WithCustomerItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new WithProductItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithProductItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/product/price/{ProductId}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithProductItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithProductItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/product/price/{ProductId}", rawUrl) {
        }
    }
}
