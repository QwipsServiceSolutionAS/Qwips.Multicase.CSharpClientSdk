using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Products.Changedsince.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.MultiCase.Products.Changedsince {
    /// <summary>
    /// Builds and executes requests for operations under \products\changedsince
    /// </summary>
    public class ChangedsinceRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Qwips.Core.MultiCase.products.changedsince.item collection</summary>
        public WithTimestampItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("Timestamp", position);
            return new WithTimestampItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ChangedsinceRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChangedsinceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products/changedsince", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ChangedsinceRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChangedsinceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products/changedsince", rawUrl) {
        }
    }
}
