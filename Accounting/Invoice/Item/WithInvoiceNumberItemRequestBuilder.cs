using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.MultiCase.Accounting.Invoice.Item {
    /// <summary>
    /// Builds and executes requests for operations under \accounting\invoice\{InvoiceNumber}
    /// </summary>
    public class WithInvoiceNumberItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WithInvoiceNumberItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithInvoiceNumberItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounting/invoice/{InvoiceNumber}{?SenderId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithInvoiceNumberItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithInvoiceNumberItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounting/invoice/{InvoiceNumber}{?SenderId*}", rawUrl) {
        }
        /// <summary>
        /// Get the specified invoice
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Qwips.Core.MultiCase.Models.Invoice?> GetAsync(Action<WithInvoiceNumberItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Qwips.Core.MultiCase.Models.Invoice> GetAsync(Action<WithInvoiceNumberItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<Qwips.Core.MultiCase.Models.Invoice>(requestInfo, Qwips.Core.MultiCase.Models.Invoice.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Get the specified invoice
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WithInvoiceNumberItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WithInvoiceNumberItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new WithInvoiceNumberItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get the specified invoice
        /// </summary>
        public class WithInvoiceNumberItemRequestBuilderGetQueryParameters {
            /// <summary>Sender Id</summary>
            [QueryParameter("SenderId")]
			public int? SenderId { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithInvoiceNumberItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WithInvoiceNumberItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new WithInvoiceNumberItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new WithInvoiceNumberItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WithInvoiceNumberItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}