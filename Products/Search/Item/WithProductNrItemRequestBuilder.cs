using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.MultiCase.Products.Search.Item {
    /// <summary>
    /// Builds and executes requests for operations under \products\search\{ProductNr}
    /// </summary>
    public class WithProductNrItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WithProductNrItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithProductNrItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products/search/{ProductNr}{?Term*,LanguageId*,SenderId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithProductNrItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithProductNrItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products/search/{ProductNr}{?Term*,LanguageId*,SenderId*}", rawUrl) {
        }
        /// <summary>
        /// Get product(s) by product number
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Productslist?> GetAsync(Action<WithProductNrItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Productslist> GetAsync(Action<WithProductNrItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<Productslist>(requestInfo, Productslist.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Get product(s) by product number
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WithProductNrItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WithProductNrItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new WithProductNrItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get product(s) by product number
        /// </summary>
        public class WithProductNrItemRequestBuilderGetQueryParameters {
            /// <summary>Language id to use for descriptions, etc. 1 = Norwegian, default, 2 = English, 5 = Swedish</summary>
            [QueryParameter("LanguageId")]
			public int? LanguageId { get; set; }
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
        public class WithProductNrItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WithProductNrItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new WithProductNrItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new WithProductNrItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WithProductNrItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
