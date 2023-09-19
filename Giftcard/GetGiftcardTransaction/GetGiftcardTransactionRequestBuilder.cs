using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.MultiCase.Giftcard.GetGiftcardTransaction {
    /// <summary>
    /// Builds and executes requests for operations under \Giftcard\GetGiftcardTransaction
    /// </summary>
    public class GetGiftcardTransactionRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new GetGiftcardTransactionRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetGiftcardTransactionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/GetGiftcardTransaction{?GavekortTransID*,ValutaHistoryID*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new GetGiftcardTransactionRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetGiftcardTransactionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/GetGiftcardTransaction{?GavekortTransID*,ValutaHistoryID*}", rawUrl) {
        }
        /// <summary>
        /// Get giftcard transaction by GavekortTransID in the currency provided by ValutaHistoryID if provided, otherwise original currency is shown.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Giftcardtransaction?> GetAsync(Action<GetGiftcardTransactionRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Giftcardtransaction> GetAsync(Action<GetGiftcardTransactionRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<Giftcardtransaction>(requestInfo, Giftcardtransaction.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<GetGiftcardTransactionRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<GetGiftcardTransactionRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new GetGiftcardTransactionRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get giftcard transaction by GavekortTransID in the currency provided by ValutaHistoryID if provided, otherwise original currency is shown.
        /// </summary>
        public class GetGiftcardTransactionRequestBuilderGetQueryParameters {
            [QueryParameter("GavekortTransID")]
			public int? GavekortTransID { get; set; }
            [QueryParameter("ValutaHistoryID")]
			public int? ValutaHistoryID { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GetGiftcardTransactionRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public GetGiftcardTransactionRequestBuilderGetQueryParameters QueryParameters { get; set; } = new GetGiftcardTransactionRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new GetGiftcardTransactionRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetGiftcardTransactionRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
