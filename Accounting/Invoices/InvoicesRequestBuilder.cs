using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Accounting.Invoices {
    /// <summary>
    /// Builds and executes requests for operations under \accounting\invoices
    /// </summary>
    public class InvoicesRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new InvoicesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InvoicesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounting/invoices{?SenderId*,FromDate*,ToDate*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new InvoicesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InvoicesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounting/invoices{?SenderId*,FromDate*,ToDate*}", rawUrl) {
        }
        /// <summary>
        /// Get a list of invoices and creditnotes
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Qwips.Core.ClientSdk.Multicase.Models.Invoices?> GetAsync(Action<InvoicesRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Qwips.Core.ClientSdk.Multicase.Models.Invoices> GetAsync(Action<InvoicesRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<Qwips.Core.ClientSdk.Multicase.Models.Invoices>(requestInfo, Qwips.Core.ClientSdk.Multicase.Models.Invoices.CreateFromDiscriminatorValue, MulticaseErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <summary>
        /// Get a list of invoices and creditnotes
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<InvoicesRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<InvoicesRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new InvoicesRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get a list of invoices and creditnotes
        /// </summary>
        public class InvoicesRequestBuilderGetQueryParameters {
            /// <summary>Oldest date of invoices retrieved</summary>
            [QueryParameter("FromDate")]
			public DateTimeOffset? FromDate { get; set; }
            /// <summary>Sender Id</summary>
            [QueryParameter("SenderId")]
			public int? SenderId { get; set; }
            /// <summary>Newest date of invoices retrieved. If not specified, no upper limit will be used</summary>
            [QueryParameter("ToDate")]
			public DateTimeOffset? ToDate { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class InvoicesRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public InvoicesRequestBuilderGetQueryParameters QueryParameters { get; set; } = new InvoicesRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new invoicesRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public InvoicesRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
