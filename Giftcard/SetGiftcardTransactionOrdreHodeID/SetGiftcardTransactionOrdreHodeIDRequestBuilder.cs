using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.MultiCase.Giftcard.SetGiftcardTransactionOrdreHodeID {
    /// <summary>
    /// Builds and executes requests for operations under \Giftcard\SetGiftcardTransactionOrdreHodeID
    /// </summary>
    public class SetGiftcardTransactionOrdreHodeIDRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new SetGiftcardTransactionOrdreHodeIDRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SetGiftcardTransactionOrdreHodeIDRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/SetGiftcardTransactionOrdreHodeID", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SetGiftcardTransactionOrdreHodeIDRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SetGiftcardTransactionOrdreHodeIDRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/SetGiftcardTransactionOrdreHodeID", rawUrl) {
        }
        /// <summary>
        /// Set the OrdreHodeID for the Giftcard transactions to reference the Order, for Transactions that have status locked and &apos;Lading&apos; =0
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<bool?> PostAsync(Qwips.Core.MultiCase.Models.Setgiftcardtransactionordrehodeid body, Action<SetGiftcardTransactionOrdreHodeIDRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<bool?> PostAsync(Qwips.Core.MultiCase.Models.Setgiftcardtransactionordrehodeid body, Action<SetGiftcardTransactionOrdreHodeIDRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<bool?>(requestInfo, default, cancellationToken);
        }
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Qwips.Core.MultiCase.Models.Setgiftcardtransactionordrehodeid body, Action<SetGiftcardTransactionOrdreHodeIDRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Qwips.Core.MultiCase.Models.Setgiftcardtransactionordrehodeid body, Action<SetGiftcardTransactionOrdreHodeIDRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new SetGiftcardTransactionOrdreHodeIDRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class SetGiftcardTransactionOrdreHodeIDRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new SetGiftcardTransactionOrdreHodeIDRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public SetGiftcardTransactionOrdreHodeIDRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}