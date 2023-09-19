using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.MultiCase.Giftcard.GetGiftcard {
    /// <summary>
    /// Builds and executes requests for operations under \Giftcard\GetGiftcard
    /// </summary>
    public class GetGiftcardRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new GetGiftcardRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetGiftcardRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/GetGiftcard{?GUID*,AvsAdresseID*,ValutaHistoryID*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new GetGiftcardRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetGiftcardRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/GetGiftcard{?GUID*,AvsAdresseID*,ValutaHistoryID*}", rawUrl) {
        }
        /// <summary>
        /// Get giftcard by GUID
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Qwips.Core.MultiCase.Models.Giftcard?> GetAsync(Action<GetGiftcardRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Qwips.Core.MultiCase.Models.Giftcard> GetAsync(Action<GetGiftcardRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<Qwips.Core.MultiCase.Models.Giftcard>(requestInfo, Qwips.Core.MultiCase.Models.Giftcard.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<GetGiftcardRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<GetGiftcardRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new GetGiftcardRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get giftcard by GUID
        /// </summary>
        public class GetGiftcardRequestBuilderGetQueryParameters {
            [QueryParameter("AvsAdresseID")]
			public int? AvsAdresseID { get; set; }
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
        public class GetGiftcardRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public GetGiftcardRequestBuilderGetQueryParameters QueryParameters { get; set; } = new GetGiftcardRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new GetGiftcardRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetGiftcardRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
