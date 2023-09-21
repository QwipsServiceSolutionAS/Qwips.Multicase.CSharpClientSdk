using Microsoft.Kiota.Abstractions;
using Qwips.Core.ClientSdk.Multicase.Accounting.Bundles;
using Qwips.Core.ClientSdk.Multicase.Accounting.Creditnote;
using Qwips.Core.ClientSdk.Multicase.Accounting.Invoice;
using Qwips.Core.ClientSdk.Multicase.Accounting.Invoices;
using Qwips.Core.ClientSdk.Multicase.Accounting.Outstandingvouchers;
using Qwips.Core.ClientSdk.Multicase.Accounting.Processbundle;
using Qwips.Core.ClientSdk.Multicase.Accounting.Updatecustomerbalance;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.Core.ClientSdk.Multicase.Accounting {
    /// <summary>
    /// Builds and executes requests for operations under \accounting
    /// </summary>
    public class AccountingRequestBuilder : BaseRequestBuilder {
        /// <summary>The bundles property</summary>
        public BundlesRequestBuilder Bundles { get =>
            new BundlesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The creditnote property</summary>
        public CreditnoteRequestBuilder Creditnote { get =>
            new CreditnoteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The invoice property</summary>
        public InvoiceRequestBuilder Invoice { get =>
            new InvoiceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The invoices property</summary>
        public InvoicesRequestBuilder Invoices { get =>
            new InvoicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The outstandingvouchers property</summary>
        public OutstandingvouchersRequestBuilder Outstandingvouchers { get =>
            new OutstandingvouchersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The processbundle property</summary>
        public ProcessbundleRequestBuilder Processbundle { get =>
            new ProcessbundleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The updatecustomerbalance property</summary>
        public UpdatecustomerbalanceRequestBuilder Updatecustomerbalance { get =>
            new UpdatecustomerbalanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new AccountingRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountingRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounting", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AccountingRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountingRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounting", rawUrl) {
        }
    }
}
