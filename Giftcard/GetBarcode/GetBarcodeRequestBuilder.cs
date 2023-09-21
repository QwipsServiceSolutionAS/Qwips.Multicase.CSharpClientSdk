using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Giftcard.GetBarcode {
    /// <summary>
    /// Builds and executes requests for operations under \Giftcard\GetBarcode
    /// </summary>
    public class GetBarcodeRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new GetBarcodeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetBarcodeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/GetBarcode{?Symbology*,BarcodeValue*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new GetBarcodeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetBarcodeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Giftcard/GetBarcode{?Symbology*,BarcodeValue*}", rawUrl) {
        }
        /// <summary>
        /// Returns a PNG file in a stream with the barcode of the selected type and value.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<int?>?> GetAsync(Action<GetBarcodeRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<int?>> GetAsync(Action<GetBarcodeRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendPrimitiveCollectionAsync<int?>(requestInfo, MulticaseErrorHandler.GenericErrorResponse, cancellationToken);
            return collectionResult?.ToList();
        }
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<GetBarcodeRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<GetBarcodeRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new GetBarcodeRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns a PNG file in a stream with the barcode of the selected type and value.
        /// </summary>
        public class GetBarcodeRequestBuilderGetQueryParameters {
            /// <summary>The text that the barcode image will represent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("BarcodeValue")]
			public string? BarcodeValue { get; set; }
#nullable restore
#else
            [QueryParameter("BarcodeValue")]
			public string BarcodeValue { get; set; }
#endif
            /// <summary>One of Codabar = 1,Industrial2of5 = 2,Interleaved2of5 = 3,Code39 = 4,Code39Extended = 5,Code93 = 6,Code93Extended = 7,Code128 = 8,Code11 = 9,CodeMSI = 10,PostNet = 11,EAN13 = 12,UPCA = 13,EAN8 = 14,EAN128 = 15,UPCSupplemental2 = 16,UPCSupplemental5 = 17,UPCE0 = 18,UPCE1 = 19,Matrix2of5 = 20,PDF417 = 21,DataMatrix = 22,QRCode = 23,IntelligentMail = 24,DataMatrixGS1 = 25,ITF14 = 26,DataBar = 27</summary>
            [QueryParameter("Symbology")]
			public int? Symbology { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GetBarcodeRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public GetBarcodeRequestBuilderGetQueryParameters QueryParameters { get; set; } = new GetBarcodeRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new GetBarcodeRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetBarcodeRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
