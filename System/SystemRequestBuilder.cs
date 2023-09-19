using Microsoft.Kiota.Abstractions;
using Qwips.Core.MultiCase.MSystem.Economy;
using Qwips.Core.MultiCase.MSystem.Usercompany;
using Qwips.Core.MultiCase.MSystem.Warehouse;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.MultiCase.MSystem {
    /// <summary>
    /// Builds and executes requests for operations under \system
    /// </summary>
    public class SystemRequestBuilder : BaseRequestBuilder {
        /// <summary>The economy property</summary>
        public EconomyRequestBuilder Economy { get =>
            new EconomyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The usercompany property</summary>
        public UsercompanyRequestBuilder Usercompany { get =>
            new UsercompanyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The warehouse property</summary>
        public WarehouseRequestBuilder Warehouse { get =>
            new WarehouseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new SystemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SystemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/system", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SystemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SystemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/system", rawUrl) {
        }
    }
}
