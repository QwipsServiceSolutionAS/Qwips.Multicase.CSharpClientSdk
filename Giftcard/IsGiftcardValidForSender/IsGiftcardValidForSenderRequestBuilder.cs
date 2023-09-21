using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Giftcard.IsGiftcardValidForSender {
    /// <summary>
    /// Builds and executes requests for operations under \Giftcard\IsGiftcardValidForSender
    /// </summary>
    public class IsGiftcardValidForSenderRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new IsGiftcardValidForSenderRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IsGiftcardValidForSenderRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/IsGiftcardValidForSender{?GUID*,AvsAdresseID*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new IsGiftcardValidForSenderRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IsGiftcardValidForSenderRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/IsGiftcardValidForSender{?GUID*,AvsAdresseID*}", rawUrl) {
        }
        /// <summary>
        /// Check if a giftcard with GUID is valid for use at the provided sender.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<bool?> GetAsync(Action<IsGiftcardValidForSenderRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<bool?> GetAsync(Action<IsGiftcardValidForSenderRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<bool?>(requestInfo, MulticaseErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<IsGiftcardValidForSenderRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<IsGiftcardValidForSenderRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new IsGiftcardValidForSenderRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Check if a giftcard with GUID is valid for use at the provided sender.
        /// </summary>
        public class IsGiftcardValidForSenderRequestBuilderGetQueryParameters {
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
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class IsGiftcardValidForSenderRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public IsGiftcardValidForSenderRequestBuilderGetQueryParameters QueryParameters { get; set; } = new IsGiftcardValidForSenderRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new IsGiftcardValidForSenderRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public IsGiftcardValidForSenderRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
