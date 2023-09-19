using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.MultiCase.Giftcard.GetGiftcardTransactionList {
    /// <summary>
    /// Builds and executes requests for operations under \Giftcard\GetGiftcardTransactionList
    /// </summary>
    public class GetGiftcardTransactionListRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new GetGiftcardTransactionListRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetGiftcardTransactionListRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/GetGiftcardTransactionList{?GUID*,ValutaHistoryID*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new GetGiftcardTransactionListRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetGiftcardTransactionListRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/GetGiftcardTransactionList{?GUID*,ValutaHistoryID*}", rawUrl) {
        }
        /// <summary>
        /// Get list of all giftcard transactions by Giftcard GUID in the currency provided by ValutaHistoryID if provided, otherwise original currency is shown.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Giftcardtransaction>?> GetAsync(Action<GetGiftcardTransactionListRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<Giftcardtransaction>> GetAsync(Action<GetGiftcardTransactionListRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<Giftcardtransaction>(requestInfo, Giftcardtransaction.CreateFromDiscriminatorValue, default, cancellationToken);
            return collectionResult?.ToList();
        }
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<GetGiftcardTransactionListRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<GetGiftcardTransactionListRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new GetGiftcardTransactionListRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get list of all giftcard transactions by Giftcard GUID in the currency provided by ValutaHistoryID if provided, otherwise original currency is shown.
        /// </summary>
        public class GetGiftcardTransactionListRequestBuilderGetQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("GUID")]
			public string? GUID { get; set; }
#nullable restore
#else
            [QueryParameter("GUID")]
			public string GUID { get; set; }
#endif
            [QueryParameter("ValutaHistoryID")]
			public int? ValutaHistoryID { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GetGiftcardTransactionListRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public GetGiftcardTransactionListRequestBuilderGetQueryParameters QueryParameters { get; set; } = new GetGiftcardTransactionListRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new GetGiftcardTransactionListRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetGiftcardTransactionListRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
