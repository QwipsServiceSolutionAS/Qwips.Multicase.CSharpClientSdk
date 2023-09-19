using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Models;
using Qwips.Core.MultiCase.Products.Search.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.MultiCase.Products.Search {
    /// <summary>
    /// Builds and executes requests for operations under \products\search
    /// </summary>
    public class SearchRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Qwips.Core.MultiCase.products.search.item collection</summary>
        public WithProductNrItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("ProductNr", position);
            return new WithProductNrItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new SearchRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products/search{?ProductNr*,Term*,LanguageId*,SenderId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SearchRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products/search{?ProductNr*,Term*,LanguageId*,SenderId*}", rawUrl) {
        }
        /// <summary>
        /// Search products by description (in any language), EAN or EAN text
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Productslist?> GetAsync(Action<SearchRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Productslist> GetAsync(Action<SearchRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<Productslist>(requestInfo, Productslist.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Search products by description (in any language), EAN or EAN text
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<SearchRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<SearchRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new SearchRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Search products by description (in any language), EAN or EAN text
        /// </summary>
        public class SearchRequestBuilderGetQueryParameters {
            /// <summary>Language id to use for descriptions, etc. 1 = Norwegian, default, 2 = English, 5 = Swedish</summary>
            [QueryParameter("LanguageId")]
			public int? LanguageId { get; set; }
            /// <summary>Product number(s) to search</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? ProductNr { get; set; }
#nullable restore
#else
            [QueryParameter("ProductNr")]
			public string[] ProductNr { get; set; }
#endif
            /// <summary>Sender id. Level groups depend on it. Default is 1.</summary>
            [QueryParameter("SenderId")]
			public int? SenderId { get; set; }
            /// <summary>Search term (min. 3 symbols) to search in description(in any language), EAN or EAN text</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("Term")]
			public string? Term { get; set; }
#nullable restore
#else
            [QueryParameter("Term")]
			public string Term { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class SearchRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public SearchRequestBuilderGetQueryParameters QueryParameters { get; set; } = new SearchRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new searchRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public SearchRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
