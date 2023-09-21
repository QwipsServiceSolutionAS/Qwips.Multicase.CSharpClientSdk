using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Orders.Orderdetailswiftcourt {
    /// <summary>
    /// Builds and executes requests for operations under \orders\orderdetailswiftcourt
    /// </summary>
    public class OrderdetailswiftcourtRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new OrderdetailswiftcourtRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrderdetailswiftcourtRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orders/orderdetailswiftcourt{?OrderNumber*,CustomerNumber*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new OrderdetailswiftcourtRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrderdetailswiftcourtRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orders/orderdetailswiftcourt{?OrderNumber*,CustomerNumber*}", rawUrl) {
        }
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Ordersdetailsswfitcourtresponse?> GetAsync(Action<OrderdetailswiftcourtRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Ordersdetailsswfitcourtresponse> GetAsync(Action<OrderdetailswiftcourtRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<Ordersdetailsswfitcourtresponse>(requestInfo, Ordersdetailsswfitcourtresponse.CreateFromDiscriminatorValue, MulticaseErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<OrderdetailswiftcourtRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<OrderdetailswiftcourtRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new OrderdetailswiftcourtRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        public class OrderdetailswiftcourtRequestBuilderGetQueryParameters {
            /// <summary>Customer number</summary>
            [QueryParameter("CustomerNumber")]
			public int? CustomerNumber { get; set; }
            /// <summary>Order number</summary>
            [QueryParameter("OrderNumber")]
			public int? OrderNumber { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class OrderdetailswiftcourtRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public OrderdetailswiftcourtRequestBuilderGetQueryParameters QueryParameters { get; set; } = new OrderdetailswiftcourtRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new orderdetailswiftcourtRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public OrderdetailswiftcourtRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
