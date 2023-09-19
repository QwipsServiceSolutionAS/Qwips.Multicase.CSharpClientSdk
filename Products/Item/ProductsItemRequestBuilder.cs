using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Models;
using Qwips.Core.MultiCase.Products.Item.Images;
using Qwips.Core.MultiCase.Products.Item.Listprice;
using Qwips.Core.MultiCase.Products.Item.Stocklevels;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.MultiCase.Products.Item {
    /// <summary>
    /// Builds and executes requests for operations under \products\{Id}
    /// </summary>
    public class ProductsItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The images property</summary>
        public ImagesRequestBuilder Images { get =>
            new ImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The listprice property</summary>
        public ListpriceRequestBuilder Listprice { get =>
            new ListpriceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The stocklevels property</summary>
        public StocklevelsRequestBuilder Stocklevels { get =>
            new StocklevelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ProductsItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProductsItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products/{Id}{?Timestamp*,LanguageId*,SenderId*,PageSize*,PageNumber*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ProductsItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProductsItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products/{Id}{?Timestamp*,LanguageId*,SenderId*,PageSize*,PageNumber*}", rawUrl) {
        }
        /// <summary>
        /// Get product(s) by id
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Productslist?> GetAsync(Action<ProductsItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Productslist> GetAsync(Action<ProductsItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<Productslist>(requestInfo, Productslist.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Get product(s) by id
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ProductsItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ProductsItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ProductsItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get product(s) by id
        /// </summary>
        public class ProductsItemRequestBuilderGetQueryParameters {
            /// <summary>Language id to use for descriptions, etc. 1 = Norwegian, default, 2 = English, 5 = Swedish</summary>
            [QueryParameter("LanguageId")]
			public int? LanguageId { get; set; }
            /// <summary>Use to retrive subsequent pages of records. Starts with 1, default is 1.</summary>
            [QueryParameter("PageNumber")]
			public int? PageNumber { get; set; }
            /// <summary>Number of records to retrive. Max is 1000, Default is 100.</summary>
            [QueryParameter("PageSize")]
			public int? PageSize { get; set; }
            /// <summary>Sender id. Level groups depend on it. Default is 1.</summary>
            [QueryParameter("SenderId")]
			public int? SenderId { get; set; }
            /// <summary>Timestamp, to retrieve only added or modified products</summary>
            [QueryParameter("Timestamp")]
			public long? Timestamp { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ProductsItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ProductsItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ProductsItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new ProductsItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ProductsItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
