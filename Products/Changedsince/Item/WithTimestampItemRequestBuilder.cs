using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Products.Changedsince.Item {
    /// <summary>
    /// Builds and executes requests for operations under \products\changedsince\{Timestamp}
    /// </summary>
    public class WithTimestampItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WithTimestampItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTimestampItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products/changedsince/{Timestamp}{?Id*,LanguageId*,SenderId*,PageSize*,PageNumber*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithTimestampItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTimestampItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products/changedsince/{Timestamp}{?Id*,LanguageId*,SenderId*,PageSize*,PageNumber*}", rawUrl) {
        }
        /// <summary>
        /// Get added or updated products since given time
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Productslist?> GetAsync(Action<WithTimestampItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Productslist> GetAsync(Action<WithTimestampItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<Productslist>(requestInfo, Productslist.CreateFromDiscriminatorValue, MulticaseErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <summary>
        /// Get added or updated products since given time
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WithTimestampItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WithTimestampItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new WithTimestampItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get added or updated products since given time
        /// </summary>
        public class WithTimestampItemRequestBuilderGetQueryParameters {
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
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithTimestampItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WithTimestampItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new WithTimestampItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new WithTimestampItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WithTimestampItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
