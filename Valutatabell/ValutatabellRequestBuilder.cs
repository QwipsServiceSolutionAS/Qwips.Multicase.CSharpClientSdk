using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Valutatabell.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Valutatabell {
    /// <summary>
    /// Builds and executes requests for operations under \valutatabell
    /// </summary>
    public class ValutatabellRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Qwips.Core.ClientSdk.Multicase.valutatabell.item collection</summary>
        public WithAvsAdresseItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("AvsAdresseId", position);
            return new WithAvsAdresseItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ValutatabellRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ValutatabellRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/valutatabell", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ValutatabellRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ValutatabellRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/valutatabell", rawUrl) {
        }
    }
}
