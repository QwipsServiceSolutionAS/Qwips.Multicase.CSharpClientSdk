using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.MSystem.Economy.Paymentterms;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.MultiCase.MSystem.Economy {
    /// <summary>
    /// Builds and executes requests for operations under \system\economy
    /// </summary>
    public class EconomyRequestBuilder : BaseRequestBuilder {
        /// <summary>The paymentterms property</summary>
        public PaymenttermsRequestBuilder Paymentterms { get =>
            new PaymenttermsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new EconomyRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EconomyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/system/economy", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new EconomyRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EconomyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/system/economy", rawUrl) {
        }
    }
}
