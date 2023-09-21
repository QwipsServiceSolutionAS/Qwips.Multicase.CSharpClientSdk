using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Purchaseorders.Create {
    /// <summary>
    /// Builds and executes requests for operations under \purchaseorders\create
    /// </summary>
    public class CreateRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new CreateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CreateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/purchaseorders/create", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CreateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CreateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/purchaseorders/create", rawUrl) {
        }
        /// <summary>
        /// &lt;span class=&apos;code&apos;&gt;WarehouseCode&lt;/span&gt;: WarehouseId or LagerGeoOmr.Kortnavn/LagerFunksjon.Kortnavn/LagerGeoNavn.Kortnavn f.ex. SFJ/SLG/HVD&lt;br/&gt;&lt;span class=&apos;code&apos;&gt;SenderId&lt;/span&gt;: Overrides avsender that would be found by warehouse. Use when specified warehouse belongs to different avsender&lt;br/&gt;&lt;span class=&apos;code&apos;&gt;UseMcSuppliersPrice&lt;/span&gt;: When true (default), eventual values for currency and price (on the line level) will be ignored, and supplier&apos;s price and supplier&apos;s                                                default currency will be used. When false, CurrencyCode and line prices have to be provided&lt;br/&gt;&lt;span class=&apos;code&apos;&gt;FreightId&lt;/span&gt;: If omitted, supplier&apos;s default freight is used&lt;br/&gt;&lt;span class=&apos;code&apos;&gt;Combined&lt;/span&gt;: True = deliver all products together, false = can be sent separately. Default is false&lt;br/&gt;&lt;span class=&apos;code&apos;&gt;&lt;/span&gt;&lt;br/&gt;&lt;span class=&apos;code&apos;&gt;&lt;/span&gt;&lt;br/&gt;
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Purchaseordercreationresult?> PostAsync(Createpurchaseorder body, Action<CreateRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Purchaseordercreationresult> PostAsync(Createpurchaseorder body, Action<CreateRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<Purchaseordercreationresult>(requestInfo, Purchaseordercreationresult.CreateFromDiscriminatorValue, MulticaseErrorHandler.GenericErrorResponse, cancellationToken);
        }
        /// <summary>
        /// &lt;span class=&apos;code&apos;&gt;WarehouseCode&lt;/span&gt;: WarehouseId or LagerGeoOmr.Kortnavn/LagerFunksjon.Kortnavn/LagerGeoNavn.Kortnavn f.ex. SFJ/SLG/HVD&lt;br/&gt;&lt;span class=&apos;code&apos;&gt;SenderId&lt;/span&gt;: Overrides avsender that would be found by warehouse. Use when specified warehouse belongs to different avsender&lt;br/&gt;&lt;span class=&apos;code&apos;&gt;UseMcSuppliersPrice&lt;/span&gt;: When true (default), eventual values for currency and price (on the line level) will be ignored, and supplier&apos;s price and supplier&apos;s                                                default currency will be used. When false, CurrencyCode and line prices have to be provided&lt;br/&gt;&lt;span class=&apos;code&apos;&gt;FreightId&lt;/span&gt;: If omitted, supplier&apos;s default freight is used&lt;br/&gt;&lt;span class=&apos;code&apos;&gt;Combined&lt;/span&gt;: True = deliver all products together, false = can be sent separately. Default is false&lt;br/&gt;&lt;span class=&apos;code&apos;&gt;&lt;/span&gt;&lt;br/&gt;&lt;span class=&apos;code&apos;&gt;&lt;/span&gt;&lt;br/&gt;
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Createpurchaseorder body, Action<CreateRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Createpurchaseorder body, Action<CreateRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new CreateRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CreateRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new createRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public CreateRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
