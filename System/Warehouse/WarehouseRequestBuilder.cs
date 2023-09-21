using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.MSystem.Warehouse.Freights;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.MSystem.Warehouse {
    /// <summary>
    /// Builds and executes requests for operations under \system\warehouse
    /// </summary>
    public class WarehouseRequestBuilder : BaseRequestBuilder {
        /// <summary>The freights property</summary>
        public FreightsRequestBuilder Freights { get =>
            new FreightsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WarehouseRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WarehouseRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/system/warehouse", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WarehouseRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WarehouseRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/system/warehouse", rawUrl) {
        }
    }
}
