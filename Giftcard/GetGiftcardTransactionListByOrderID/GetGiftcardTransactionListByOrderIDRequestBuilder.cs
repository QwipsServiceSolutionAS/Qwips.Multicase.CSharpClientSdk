using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.MultiCase.Giftcard.GetGiftcardTransactionListByOrderID {
    /// <summary>
    /// Builds and executes requests for operations under \Giftcard\GetGiftcardTransactionListByOrderID
    /// </summary>
    public class GetGiftcardTransactionListByOrderIDRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new GetGiftcardTransactionListByOrderIDRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetGiftcardTransactionListByOrderIDRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/GetGiftcardTransactionListByOrderID{?OrderID*,ValutaHistoryID*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new GetGiftcardTransactionListByOrderIDRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetGiftcardTransactionListByOrderIDRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/GetGiftcardTransactionListByOrderID{?OrderID*,ValutaHistoryID*}", rawUrl) {
        }
        /// <summary>
        /// Get list of all giftcard transactions by Order ID in the currency provided by ValutaHistoryID if provided, otherwise original currency is shown.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Giftcardtransaction>?> GetAsync(Action<GetGiftcardTransactionListByOrderIDRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<Giftcardtransaction>> GetAsync(Action<GetGiftcardTransactionListByOrderIDRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<Giftcardtransaction>(requestInfo, Giftcardtransaction.CreateFromDiscriminatorValue, default, cancellationToken);
            return collectionResult?.ToList();
        }
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<GetGiftcardTransactionListByOrderIDRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<GetGiftcardTransactionListByOrderIDRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new GetGiftcardTransactionListByOrderIDRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get list of all giftcard transactions by Order ID in the currency provided by ValutaHistoryID if provided, otherwise original currency is shown.
        /// </summary>
        public class GetGiftcardTransactionListByOrderIDRequestBuilderGetQueryParameters {
            [QueryParameter("OrderID")]
			public int? OrderID { get; set; }
            [QueryParameter("ValutaHistoryID")]
			public int? ValutaHistoryID { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GetGiftcardTransactionListByOrderIDRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public GetGiftcardTransactionListByOrderIDRequestBuilderGetQueryParameters QueryParameters { get; set; } = new GetGiftcardTransactionListByOrderIDRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new GetGiftcardTransactionListByOrderIDRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetGiftcardTransactionListByOrderIDRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
