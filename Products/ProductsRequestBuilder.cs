using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Models;
using Qwips.Core.MultiCase.Products.AddCustomerProductLink;
using Qwips.Core.MultiCase.Products.Changedsince;
using Qwips.Core.MultiCase.Products.Item;
using Qwips.Core.MultiCase.Products.Productcreate;
using Qwips.Core.MultiCase.Products.Returncreate;
using Qwips.Core.MultiCase.Products.Search;
using Qwips.Core.MultiCase.Products.Update;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.MultiCase.Products {
    /// <summary>
    /// Builds and executes requests for operations under \products
    /// </summary>
    public class ProductsRequestBuilder : BaseRequestBuilder {
        /// <summary>The addCustomerProductLink property</summary>
        public AddCustomerProductLinkRequestBuilder AddCustomerProductLink { get =>
            new AddCustomerProductLinkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The changedsince property</summary>
        public ChangedsinceRequestBuilder Changedsince { get =>
            new ChangedsinceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The productcreate property</summary>
        public ProductcreateRequestBuilder Productcreate { get =>
            new ProductcreateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The returncreate property</summary>
        public ReturncreateRequestBuilder Returncreate { get =>
            new ReturncreateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The search property</summary>
        public SearchRequestBuilder Search { get =>
            new SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The update property</summary>
        public UpdateRequestBuilder Update { get =>
            new UpdateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Qwips.Core.MultiCase.products.item collection</summary>
        public ProductsItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("Id", position);
            return new ProductsItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ProductsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProductsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products{?Id*,Timestamp*,LanguageId*,SenderId*,PageSize*,PageNumber*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ProductsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProductsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products{?Id*,Timestamp*,LanguageId*,SenderId*,PageSize*,PageNumber*}", rawUrl) {
        }
        /// <summary>
        /// Get list of all products
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Productslist?> GetAsync(Action<ProductsRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Productslist> GetAsync(Action<ProductsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<Productslist>(requestInfo, Productslist.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Get list of all products
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ProductsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ProductsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ProductsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get list of all products
        /// </summary>
        public class ProductsRequestBuilderGetQueryParameters {
            /// <summary>Product id (or list of ids), optional</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public int?[]? Id { get; set; }
#nullable restore
#else
            [QueryParameter("Id")]
			public int?[] Id { get; set; }
#endif
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
        public class ProductsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ProductsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ProductsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new productsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ProductsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
