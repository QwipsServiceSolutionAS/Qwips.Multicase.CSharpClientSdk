using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Giftcard.GetGiftcardTransactionListByCartID {
    /// <summary>
    /// Builds and executes requests for operations under \Giftcard\GetGiftcardTransactionListByCartID
    /// </summary>
    public class GetGiftcardTransactionListByCartIDRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new GetGiftcardTransactionListByCartIDRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetGiftcardTransactionListByCartIDRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/GetGiftcardTransactionListByCartID{?CartID*,ValutaHistoryID*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new GetGiftcardTransactionListByCartIDRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetGiftcardTransactionListByCartIDRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/GetGiftcardTransactionListByCartID{?CartID*,ValutaHistoryID*}", rawUrl) {
        }
        /// <summary>
        /// Get list of all giftcard transactions by Cart ID in the currency provided by ValutaHistoryID if provided, otherwise original currency is shown.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Giftcardtransaction>?> GetAsync(Action<GetGiftcardTransactionListByCartIDRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<Giftcardtransaction>> GetAsync(Action<GetGiftcardTransactionListByCartIDRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<Giftcardtransaction>(requestInfo, Giftcardtransaction.CreateFromDiscriminatorValue, MulticaseErrorHandler.GenericErrorResponse, cancellationToken);
            return collectionResult?.ToList();
        }
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<GetGiftcardTransactionListByCartIDRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<GetGiftcardTransactionListByCartIDRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new GetGiftcardTransactionListByCartIDRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get list of all giftcard transactions by Cart ID in the currency provided by ValutaHistoryID if provided, otherwise original currency is shown.
        /// </summary>
        public class GetGiftcardTransactionListByCartIDRequestBuilderGetQueryParameters {
            [QueryParameter("CartID")]
			public int? CartID { get; set; }
            [QueryParameter("ValutaHistoryID")]
			public int? ValutaHistoryID { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GetGiftcardTransactionListByCartIDRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public GetGiftcardTransactionListByCartIDRequestBuilderGetQueryParameters QueryParameters { get; set; } = new GetGiftcardTransactionListByCartIDRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new GetGiftcardTransactionListByCartIDRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetGiftcardTransactionListByCartIDRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
