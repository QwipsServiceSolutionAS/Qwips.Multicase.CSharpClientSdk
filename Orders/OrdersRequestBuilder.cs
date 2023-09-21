using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Orders.Create;
using Qwips.Core.ClientSdk.Multicase.Orders.Delete;
using Qwips.Core.ClientSdk.Multicase.Orders.Get;
using Qwips.Core.ClientSdk.Multicase.Orders.Orderdetailswiftcourt;
using Qwips.Core.ClientSdk.Multicase.Orders.Orderstatus;
using Qwips.Core.ClientSdk.Multicase.Orders.Update;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Orders {
    /// <summary>
    /// Builds and executes requests for operations under \orders
    /// </summary>
    public class OrdersRequestBuilder : BaseRequestBuilder {
        /// <summary>The create property</summary>
        public CreateRequestBuilder Create { get =>
            new CreateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deletePath property</summary>
        public DeleteRequestBuilder DeletePath { get =>
            new DeleteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getPath property</summary>
        public GetRequestBuilder GetPath { get =>
            new GetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The orderdetailswiftcourt property</summary>
        public OrderdetailswiftcourtRequestBuilder Orderdetailswiftcourt { get =>
            new OrderdetailswiftcourtRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The orders property</summary>
        public OrdersRequestBuilder Orders { get =>
            new OrdersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The orderstatus property</summary>
        public OrderstatusRequestBuilder Orderstatus { get =>
            new OrderstatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The update property</summary>
        public UpdateRequestBuilder Update { get =>
            new UpdateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new OrdersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrdersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orders", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new OrdersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrdersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orders", rawUrl) {
        }
    }
}
