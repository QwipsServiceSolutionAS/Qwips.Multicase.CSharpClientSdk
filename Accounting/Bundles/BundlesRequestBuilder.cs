using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.MultiCase.Accounting.Bundles {
    /// <summary>
    /// Builds and executes requests for operations under \accounting\bundles
    /// </summary>
    public class BundlesRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new BundlesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BundlesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounting/bundles{?SenderId*,FromDate*,ToDate*,Processed*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new BundlesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BundlesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounting/bundles{?SenderId*,FromDate*,ToDate*,Processed*}", rawUrl) {
        }
        /// <summary>
        /// Retrieve a list of bundles
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Qwips.Core.MultiCase.Models.Bundles?> GetAsync(Action<BundlesRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Qwips.Core.MultiCase.Models.Bundles> GetAsync(Action<BundlesRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<Qwips.Core.MultiCase.Models.Bundles>(requestInfo, Qwips.Core.MultiCase.Models.Bundles.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Retrieve a list of bundles
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<BundlesRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<BundlesRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new BundlesRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Retrieve a list of bundles
        /// </summary>
        public class BundlesRequestBuilderGetQueryParameters {
            /// <summary>Oldest date of bundles retrieved</summary>
            [QueryParameter("FromDate")]
			public DateTimeOffset? FromDate { get; set; }
            /// <summary>Include bundles marked as processed</summary>
            [QueryParameter("Processed")]
			public bool? Processed { get; set; }
            /// <summary>Sender Id</summary>
            [QueryParameter("SenderId")]
			public int? SenderId { get; set; }
            /// <summary>Newest date of bundles retrieved. If not specified, no upper limit will be used</summary>
            [QueryParameter("ToDate")]
			public DateTimeOffset? ToDate { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class BundlesRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public BundlesRequestBuilderGetQueryParameters QueryParameters { get; set; } = new BundlesRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new bundlesRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public BundlesRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
