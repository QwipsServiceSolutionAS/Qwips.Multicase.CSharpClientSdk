using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Warehouses.Item.Stocklevels.Item;
using Qwips.Core.ClientSdk.Multicase.Warehouses.Item.Stocklevels.Search;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Warehouses.Item.Stocklevels {
    /// <summary>
    /// Builds and executes requests for operations under \warehouses\{WarehouseId}\stocklevels
    /// </summary>
    public class StocklevelsRequestBuilder : BaseRequestBuilder {
        /// <summary>The search property</summary>
        public SearchRequestBuilder Search { get =>
            new SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Qwips.Core.ClientSdk.Multicase.warehouses.item.stocklevels.item collection</summary>
        public WithProductItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("ProductId", position);
            return new WithProductItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new StocklevelsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StocklevelsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/warehouses/{WarehouseId}/stocklevels", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new StocklevelsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StocklevelsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/warehouses/{WarehouseId}/stocklevels", rawUrl) {
        }
    }
}
