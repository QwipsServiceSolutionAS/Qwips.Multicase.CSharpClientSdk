using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Accounting.Creditnote.Item {
    /// <summary>
    /// Builds and executes requests for operations under \accounting\creditnote\{CreditNoteNumber}
    /// </summary>
    public class WithCreditNoteNumberItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WithCreditNoteNumberItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCreditNoteNumberItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounting/creditnote/{CreditNoteNumber}{?SenderId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithCreditNoteNumberItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCreditNoteNumberItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounting/creditnote/{CreditNoteNumber}{?SenderId*}", rawUrl) {
        }
        /// <summary>
        /// Get the specified creditnote
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Qwips.Core.ClientSdk.Multicase.Models.Creditnote?> GetAsync(Action<WithCreditNoteNumberItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Qwips.Core.ClientSdk.Multicase.Models.Creditnote> GetAsync(Action<WithCreditNoteNumberItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<Qwips.Core.ClientSdk.Multicase.Models.Creditnote>(requestInfo, Qwips.Core.ClientSdk.Multicase.Models.Creditnote.CreateFromDiscriminatorValue, MulticaseErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <summary>
        /// Get the specified creditnote
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WithCreditNoteNumberItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WithCreditNoteNumberItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new WithCreditNoteNumberItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get the specified creditnote
        /// </summary>
        public class WithCreditNoteNumberItemRequestBuilderGetQueryParameters {
            /// <summary>Sender Id</summary>
            [QueryParameter("SenderId")]
			public int? SenderId { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithCreditNoteNumberItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WithCreditNoteNumberItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new WithCreditNoteNumberItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new WithCreditNoteNumberItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WithCreditNoteNumberItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
