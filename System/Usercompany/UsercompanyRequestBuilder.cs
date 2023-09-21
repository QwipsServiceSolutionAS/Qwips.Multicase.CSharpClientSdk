using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.MSystem.Usercompany.Departments;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.MSystem.Usercompany {
    /// <summary>
    /// Builds and executes requests for operations under \system\usercompany
    /// </summary>
    public class UsercompanyRequestBuilder : BaseRequestBuilder {
        /// <summary>The departments property</summary>
        public DepartmentsRequestBuilder Departments { get =>
            new DepartmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new UsercompanyRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsercompanyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/system/usercompany", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UsercompanyRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsercompanyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/system/usercompany", rawUrl) {
        }
    }
}
