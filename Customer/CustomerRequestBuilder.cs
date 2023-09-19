using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Customer.Create;
using Qwips.Core.MultiCase.Customer.Item;
using Qwips.Core.MultiCase.Customer.Search;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.MultiCase.Customer {
    /// <summary>
    /// Builds and executes requests for operations under \customer
    /// </summary>
    public class CustomerRequestBuilder : BaseRequestBuilder {
        /// <summary>The create property</summary>
        public CreateRequestBuilder Create { get =>
            new CreateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The search property</summary>
        public SearchRequestBuilder Search { get =>
            new SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Qwips.Core.MultiCase.customer.item collection</summary>
        public CustomerItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("Id", position);
            return new CustomerItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new CustomerRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomerRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/customer", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CustomerRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomerRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/customer", rawUrl) {
        }
    }
}
