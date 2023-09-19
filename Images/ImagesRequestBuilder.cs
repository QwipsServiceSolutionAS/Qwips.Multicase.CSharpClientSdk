using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.Images.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.MultiCase.Images {
    /// <summary>
    /// Builds and executes requests for operations under \images
    /// </summary>
    public class ImagesRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Qwips.Core.MultiCase.images.item collection</summary>
        public WithImageItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("ImageId", position);
            return new WithImageItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ImagesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ImagesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/images", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ImagesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ImagesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/images", rawUrl) {
        }
    }
}
